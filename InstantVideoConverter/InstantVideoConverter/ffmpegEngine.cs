using InstantVideoConverter.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace InstantVideoConverter
{
    class ffmpegEngine :IConvert
    {
        private int taskID;
        private Thread conversionThread;
        protected string filePath;
        private bool isWorkCompleted;
        private float progress;
        public delegate void ProgressChanged(IConvert sender, ConvertProgressEventArgs args);
        public event ProgressChanged OnProgressChanged;
        public delegate void ConversionCompleted(IConvert sender, ConversionCompleteEventArgs args);
        public event ConversionCompleted OnConversionCompleted;
        protected List<string> receivedMessagesLog = new List<string>();
        TimeSpan totalMediaDuration = new TimeSpan();
        private Process FFmpegProcess;
        protected Metadata metadata;
        public ffmpegEngine(int taskid, string filepath)
        {
            taskID = taskid;
            filePath = filepath;
            isWorkCompleted = false;
            FFmpegProcess = null;
            progress = 1.0f;
        }

        public Metadata GetMetaData(string filePath)
        {
            string invokeString = "-i " + filePath;
            ProcessStartInfo info = ConvertToProcessStartInfo(invokeString);

            using (FFmpegProcess = new Process())
            {
                FFmpegProcess.StartInfo = info;
                FFmpegProcess.ErrorDataReceived += MetaData_ErrorDataReceived;
                FFmpegProcess.OutputDataReceived += Metadata_OutputDataReceived;
                FFmpegProcess.Start();
                FFmpegProcess.WaitForExit();
            }
            Stop();
            return metadata;
        }

        private void Metadata_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null) return;
            try
            {
                metadata = RegexEngine.GetMetaData(e.Data);
            }
            catch (Exception)
            {
                Stop();
            }
        }

        private void MetaData_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null) return;
            try
            {
                metadata = RegexEngine.GetMetaData(e.Data);
            }
            catch (Exception)
            {
                Stop();
            }
        }

        public Metadata GetMetaData()
        {
            return GetMetaData(this.filePath);
        }
        private ProcessStartInfo ConvertToProcessStartInfo(string invokeString)
        {
            ProcessStartInfo info = new ProcessStartInfo
            {
                Arguments = invokeString,
                FileName = Path.Combine(Environment.CurrentDirectory,Properties.Settings.Default.ffmpeg),
                CreateNoWindow = true,
                RedirectStandardInput = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            return info;
        }
        private void ConversionWork(object opt)
        {
            ConversionOption conversionOption = opt as ConversionOption;
            string invokeString = conversionOption.GetInvokeString();

            ProcessStartInfo sInfo = ConvertToProcessStartInfo(invokeString);
            using (FFmpegProcess = Process.Start(sInfo))
            {
                if (FFmpegProcess == null)
                {
                    throw new InvalidOperationException("Cannot start ffmpeg executable");
                }
                progress = 0.0f;
                FFmpegProcess.ErrorDataReceived += FFmpegProcess_ErrorDataReceived;
            }

        }

        private void FFmpegProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null) return;
            try
            {
                receivedMessagesLog.Insert(0, e.Data);

                ConversionCompleteEventArgs convertCompleteEvent;
                ConvertProgressEventArgs progressEvent;

                if ((progressEvent = RegexEngine.IsProgressData(e.Data)) != null)
                {
                    progressEvent.TotalDuration = totalMediaDuration;
                    
                    OnProgressChanged?.Invoke(this, progressEvent);
                }
                else if ((convertCompleteEvent = RegexEngine.IsConvertCompleteData(e.Data)) != null)
                {
                    convertCompleteEvent.TotalDuration = totalMediaDuration;
                    isWorkCompleted = true;
                    progress = 100.0f;
                    OnConversionCompleted?.Invoke(this, convertCompleteEvent);
                }
            }
            catch (Exception)
            {
                Stop();
            }
        }

        public void Start(ConversionOption opt)
        {
            conversionThread = new Thread(ConversionWork);
            conversionThread.Start(opt);
        }
        public bool IsCompleted
        {
            get
            {
                return isWorkCompleted;
            }
        }
        public void Stop()
        {
            // catch the exception and kill the process since we're in a faulted state

            try
            {
                if(FFmpegProcess != null)
                    this.FFmpegProcess.Kill();
            }
            catch (InvalidOperationException)
            {
                // swallow exceptions that are thrown when killing the process, 
                // one possible candidate is the application ending naturally before we get a chance to kill it
            }
            finally
            {
                this.FFmpegProcess = null;
            }
        }
        public void Pause()
        {
            //not supported yet
        }

        public float GetProgress()
        {
            return progress;
        }

        public bool IsStarted()
        {
            return FFmpegProcess != null;
        }

        public override int GetHashCode()
        {
            return taskID;
        }

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }
    }
}

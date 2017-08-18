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
        private double progress;
        public delegate void ProgressChanged(IConvert sender, ConvertProgressEventArgs args);
        public event ProgressChanged OnProgressChanged;
        public delegate void ConversionCompleted(IConvert sender, ConversionCompleteEventArgs args);
        public event ConversionCompleted OnConversionCompleted;
        protected List<string> receivedMessagesLog = new List<string>();
        private Process FFmpegProcess;
        protected Metadata metadata;
        private DateTime dtStart;
        private DateTime dtComplete;

        public TimeSpan ConversionTime
        {
            get
            {
                return dtComplete - dtStart;
            }
        }

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
            try
            {
                using (FFmpegProcess = new Process())
                {
                    FFmpegProcess.StartInfo = info;
                    FFmpegProcess.Start();
                    string data = FFmpegProcess.StandardError.ReadToEnd();
                    FFmpegProcess.WaitForExit();
                    metadata = RegexEngine.GetMetaData(data);
                    FFmpegProcess = null;
                }
            }
            catch (Exception)
            {
                Stop();
            }
            return metadata;
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
            string invokeString = conversionOption.GetInvokeString(filePath);

            ProcessStartInfo sInfo = ConvertToProcessStartInfo(invokeString);
            using (FFmpegProcess = Process.Start(sInfo))
            {
                if (FFmpegProcess == null)
                {
                    throw new InvalidOperationException("Cannot start ffmpeg executable");
                }
                progress = 0.0f;
                while ( !(FFmpegProcess.HasExited && FFmpegProcess.StandardError.EndOfStream))
                {
                    string line = FFmpegProcess.StandardError.ReadLine();
                    FFmpegProcess_Process_Output(line);
                }
                isWorkCompleted = true;
                progress = 100.0f;
            }
            dtComplete = DateTime.Now;
        }

        private void FFmpegProcess_Process_Output(string data)
        {
            if (data == null) return;
            try
            {
                receivedMessagesLog.Insert(0, data);

                ConversionCompleteEventArgs convertCompleteEvent;
                ConvertProgressEventArgs progressEvent;

                if ((progressEvent = RegexEngine.IsProgressData(data)) != null)
                {
                    progressEvent.TotalDuration = metadata.Duration;
                    progress = progressEvent.ProcessedDuration.TotalSeconds / progressEvent.TotalDuration.TotalSeconds * 100.0;
                    OnProgressChanged?.Invoke(this, progressEvent);
                }
                else if ((convertCompleteEvent = RegexEngine.IsConvertCompleteData(data)) != null)
                {
                    convertCompleteEvent.TotalDuration = metadata.Duration;
                    isWorkCompleted = true;
                    progress = 100.0f;
                    OnConversionCompleted?.Invoke(this, convertCompleteEvent);
                }
            }
            catch (Exception ex)
            {
                Stop();
            }
        }

        public void Start(ConversionOption opt)
        {
            conversionThread = new Thread(ConversionWork);
            conversionThread.Start(opt);
            dtStart = DateTime.Now;
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

        public double GetProgress()
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace InstantVideoConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<VideoConvertTask> Tasks = new List<VideoConvertTask>(128);
        private delegate void UpdateListItem(ListViewItem lvi);
        uint CurrentThreadInProgress = 0;

        private void btn_Start_Click(object sender, EventArgs e)
        {
            //Update all settings before conversion
            UpdateHardwareAcceleration();


            CurrentThreadInProgress = 0;
            uint maxThread = Properties.Settings.Default.max_tasks;
            foreach (VideoConvertTask t in Tasks)
            {
                t.OnProgressChanged += T_OnProgressChanged;
                if(CurrentThreadInProgress < maxThread)
                {
                    t.Start();
                    CurrentThreadInProgress++;
                }
            }
        }

        private ListViewItem TaskToLVI(VideoConvertTask t)
        {
            ListViewItem lvi = new ListViewItem(Path.GetFileName(t.VideoFilePath));
            
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, string.Format("{0}x{1}", t.ConversionOption.VideoOption.Width, t.ConversionOption.VideoOption.Height)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, Path.GetExtension(t.ConversionOption.OutputPath)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, "no change"));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, "Waiting"));
            lvi.Tag = t;
            return lvi;
        }

        private void UpdateTask(ListViewItem lvi)
        {
            if (lvi != null && lvi.Tag != null)
            {
                VideoConvertTask t = lvi.Tag as VideoConvertTask;
                if (t != null)
                {
                    if(this.InvokeRequired)
                    {
                        this.Invoke(new UpdateListItem(UpdateTask), lvi);
                    }else
                    {
                        lvi.SubItems[1].Text = string.Format("{0}x{1}", t.ConversionOption.VideoOption.Width, t.ConversionOption.VideoOption.Height);
                        lvi.SubItems[2].Text = Path.GetExtension(t.ConversionOption.OutputPath);
                        lvi.SubItems[3].Text = "no change";
                        
                        if(t.IsCompleted)
                        {
                            lvi.SubItems[4].Text = string.Format("Completed in {0}", t.ConversionTime);
                            lvi.Tag = null; //no longer needs update...
                        }else
                        {
                            lvi.SubItems[4].Text = t.Progress;
                        }
                    }
                    
                }
            }
            
        }
        private void T_OnProgressChanged(IConvert sender, ConvertProgressEventArgs args)
        {

        }

        private void backgroundWorker_StartWork_DoWork(object sender, DoWorkEventArgs e)
        {
            WorkArgs args = e.Argument as WorkArgs;
            foreach(string f in args.files)
            {
                string newFilePath = Path.Combine(Properties.Settings.Default.OutputPath, Path.GetFileNameWithoutExtension(f) + args.fileExtension);
                VideoConvertTask vt = new VideoConvertTask(args.TaskContainer.Count + 1, f, newFilePath);
                args.TaskContainer.Add(vt);
            }

        }
        class WorkArgs
        {
            public string outputPath;
            public string []files;
            public List<VideoConvertTask> TaskContainer;
            public string fileExtension;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == openFileDialog_PickVideo.ShowDialog())
            {
                string[] files = openFileDialog_PickVideo.FileNames;
                string fileExtension = (this.radioButton_mp4.Checked ? ".mp4" : ".mov");
                WorkArgs args = new WorkArgs
                {
                    outputPath = this.textBox_OutDir.Text,
                    TaskContainer = Tasks,
                    files = files,
                    fileExtension = fileExtension,
                };
                if(!backgroundWorker_AddTask.IsBusy)
                {
                    backgroundWorker_AddTask.RunWorkerAsync(args);
                }
            }
        }

        private void backgroundWorker_AddTask_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach(VideoConvertTask vt in Tasks)
            {
                this.listView_Tasks.Items.Add(TaskToLVI(vt));
            }
            this.listView_Tasks.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(this.textBox_OutDir.Text.Length == 0)
            {
                Properties.Settings.Default.OutputPath = Path.Combine(Environment.CurrentDirectory, "Output");
            }
        }

        private void timer_Progress_Tick(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listView_Tasks.Items)
            {
                VideoConvertTask t = i.Tag as VideoConvertTask;
                if(t != null && t.IsStarted())
                {
                    UpdateTask(i);
                }
            }
        }

        private void UpdateHardwareAcceleration()
        {
            HardwareAcceleration ac;
            if (radioButton_Disable.Checked)
            {
                ac = HardwareAcceleration.Disabled;
            }
            else if (radioButton_CUDA.Checked)
            {
                ac = HardwareAcceleration.cuvid;
            }else if(radioButton_DirectX.Checked)
            {
                ac = HardwareAcceleration.dxva2;
            }
            else
            {
                ac = HardwareAcceleration.qsv;
            }
            foreach (VideoConvertTask vt in Tasks)
            {
                vt.ConversionOption.VideoOption.HardwareAcceleration = ac;
            }
        }
        private void radioButton_Disable_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHardwareAcceleration();
        }
    }
}

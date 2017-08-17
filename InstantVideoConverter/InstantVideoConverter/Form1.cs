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
        uint CurrentThreadInProgress = 0;
        ConversionOption CovOpt = new ConversionOption();
        private void btn_Start_Click(object sender, EventArgs e)
        {
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
            
            lvi.Tag = t;
            return lvi;
        }

        private void UpdateTask(ListViewItem lvi)
        {
            VideoConvertTask v = lvi.Tag as VideoConvertTask;
            if(v!=null)
            {
                
            }
        }
        private void T_OnProgressChanged(IConvert sender, ConvertProgressEventArgs args)
        {
            foreach(ListViewItem i in listView_Tasks.Items)
            {
                if(sender.Equals(i))
                    UpdateTask(i);
            }
        }

        private void backgroundWorker_StartWork_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == openFileDialog_PickVideo.ShowDialog())
            {
                string[] files = openFileDialog_PickVideo.FileNames;
                foreach(string f in files)
                {
                    VideoConvertTask t = new InstantVideoConverter.VideoConvertTask(Tasks.Count + 1, f, CovOpt);
                    Metadata a = t.GetMetaData();
                    string ab = a.ToString();
                }
            }
        }

    }
}

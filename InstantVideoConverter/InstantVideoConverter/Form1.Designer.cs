namespace InstantVideoConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeConversiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metadataInjectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.imageList_Icons = new System.Windows.Forms.ImageList(this.components);
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton_overwrite = new System.Windows.Forms.RadioButton();
            this.radioButton_rename = new System.Windows.Forms.RadioButton();
            this.btn_OutDir = new System.Windows.Forms.Button();
            this.textBox_OutDir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton_mp4 = new System.Windows.Forms.RadioButton();
            this.radioButton_mov = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_Disable = new System.Windows.Forms.RadioButton();
            this.radioButton_Intel = new System.Windows.Forms.RadioButton();
            this.radioButton_CUDA = new System.Windows.Forms.RadioButton();
            this.groupBox_Panorama = new System.Windows.Forms.GroupBox();
            this.comboBox_pano = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_video = new System.Windows.Forms.GroupBox();
            this.checkBox_fixed = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_height = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_width = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listView_Audio = new System.Windows.Forms.ListView();
            this.Track = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Codec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bitrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_MaxTasks = new System.Windows.Forms.NumericUpDown();
            this.listView_Tasks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker_AddTask = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog_PickVideo = new System.Windows.Forms.OpenFileDialog();
            this.timer_Progress = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_Panorama.SuspendLayout();
            this.groupBox_video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1261, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVideoToolStripMenuItem,
            this.removeVideoToolStripMenuItem,
            this.startConversionToolStripMenuItem,
            this.pauseConversionToolStripMenuItem,
            this.resumeConversiToolStripMenuItem,
            this.stopConversionToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addVideoToolStripMenuItem
            // 
            this.addVideoToolStripMenuItem.Name = "addVideoToolStripMenuItem";
            this.addVideoToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.addVideoToolStripMenuItem.Text = "Add Video";
            // 
            // removeVideoToolStripMenuItem
            // 
            this.removeVideoToolStripMenuItem.Name = "removeVideoToolStripMenuItem";
            this.removeVideoToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.removeVideoToolStripMenuItem.Text = "Remove Video";
            // 
            // startConversionToolStripMenuItem
            // 
            this.startConversionToolStripMenuItem.Name = "startConversionToolStripMenuItem";
            this.startConversionToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.startConversionToolStripMenuItem.Text = "Start Conversion";
            // 
            // pauseConversionToolStripMenuItem
            // 
            this.pauseConversionToolStripMenuItem.Name = "pauseConversionToolStripMenuItem";
            this.pauseConversionToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.pauseConversionToolStripMenuItem.Text = "Pause Conversion";
            // 
            // resumeConversiToolStripMenuItem
            // 
            this.resumeConversiToolStripMenuItem.Name = "resumeConversiToolStripMenuItem";
            this.resumeConversiToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.resumeConversiToolStripMenuItem.Text = "Resume Conversion";
            // 
            // stopConversionToolStripMenuItem
            // 
            this.stopConversionToolStripMenuItem.Name = "stopConversionToolStripMenuItem";
            this.stopConversionToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.stopConversionToolStripMenuItem.Text = "Stop Conversion";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metadataInjectorToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.settingsToolStripMenuItem.Text = "Tools";
            // 
            // metadataInjectorToolStripMenuItem
            // 
            this.metadataInjectorToolStripMenuItem.Name = "metadataInjectorToolStripMenuItem";
            this.metadataInjectorToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.metadataInjectorToolStripMenuItem.Text = "Metadata Injector";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.thanksToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // thanksToolStripMenuItem
            // 
            this.thanksToolStripMenuItem.Name = "thanksToolStripMenuItem";
            this.thanksToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.thanksToolStripMenuItem.Text = "Thanks";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 769);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1261, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Stop);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Pause);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Remove);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Start);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Add);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1261, 741);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.TabIndex = 2;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Enabled = false;
            this.btn_Stop.ImageKey = "StopConversion.png";
            this.btn_Stop.ImageList = this.imageList_Icons;
            this.btn_Stop.Location = new System.Drawing.Point(572, 2);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(136, 103);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // imageList_Icons
            // 
            this.imageList_Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Icons.ImageStream")));
            this.imageList_Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Icons.Images.SetKeyName(0, "Add.png");
            this.imageList_Icons.Images.SetKeyName(1, "Pause.png");
            this.imageList_Icons.Images.SetKeyName(2, "Remove.png");
            this.imageList_Icons.Images.SetKeyName(3, "Resume.png");
            this.imageList_Icons.Images.SetKeyName(4, "Start.png");
            this.imageList_Icons.Images.SetKeyName(5, "StartConversion.png");
            this.imageList_Icons.Images.SetKeyName(6, "StopConversion.png");
            // 
            // btn_Pause
            // 
            this.btn_Pause.Enabled = false;
            this.btn_Pause.ImageKey = "Pause.png";
            this.btn_Pause.ImageList = this.imageList_Icons;
            this.btn_Pause.Location = new System.Drawing.Point(429, 2);
            this.btn_Pause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(136, 103);
            this.btn_Pause.TabIndex = 4;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.ImageKey = "Remove.png";
            this.btn_Remove.ImageList = this.imageList_Icons;
            this.btn_Remove.Location = new System.Drawing.Point(147, 2);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(136, 103);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Remove Video";
            this.btn_Remove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Enabled = false;
            this.btn_Start.ImageKey = "StartConversion.png";
            this.btn_Start.ImageList = this.imageList_Icons;
            this.btn_Start.Location = new System.Drawing.Point(287, 2);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(136, 103);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start Conversion";
            this.btn_Start.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.ImageIndex = 0;
            this.btn_Add.ImageList = this.imageList_Icons;
            this.btn_Add.Location = new System.Drawing.Point(4, 2);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(136, 103);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add Video";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listView_Tasks);
            this.splitContainer2.Size = new System.Drawing.Size(1261, 627);
            this.splitContainer2.SplitterDistance = 601;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 625);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.btn_OutDir);
            this.tabPage1.Controls.Add(this.textBox_OutDir);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox_Panorama);
            this.tabPage1.Controls.Add(this.groupBox_video);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(591, 596);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Video";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton_overwrite);
            this.groupBox5.Controls.Add(this.radioButton_rename);
            this.groupBox5.Location = new System.Drawing.Point(12, 346);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(317, 117);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "If File With Same Name Already Exists";
            // 
            // radioButton_overwrite
            // 
            this.radioButton_overwrite.AutoSize = true;
            this.radioButton_overwrite.Checked = true;
            this.radioButton_overwrite.Location = new System.Drawing.Point(9, 62);
            this.radioButton_overwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_overwrite.Name = "radioButton_overwrite";
            this.radioButton_overwrite.Size = new System.Drawing.Size(186, 21);
            this.radioButton_overwrite.TabIndex = 1;
            this.radioButton_overwrite.TabStop = true;
            this.radioButton_overwrite.Text = "Overwrite the existing file";
            this.radioButton_overwrite.UseVisualStyleBackColor = true;
            // 
            // radioButton_rename
            // 
            this.radioButton_rename.AutoSize = true;
            this.radioButton_rename.Location = new System.Drawing.Point(9, 34);
            this.radioButton_rename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_rename.Name = "radioButton_rename";
            this.radioButton_rename.Size = new System.Drawing.Size(172, 21);
            this.radioButton_rename.TabIndex = 0;
            this.radioButton_rename.Text = "Rename the output file";
            this.radioButton_rename.UseVisualStyleBackColor = true;
            // 
            // btn_OutDir
            // 
            this.btn_OutDir.Location = new System.Drawing.Point(123, 269);
            this.btn_OutDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OutDir.Name = "btn_OutDir";
            this.btn_OutDir.Size = new System.Drawing.Size(111, 30);
            this.btn_OutDir.TabIndex = 7;
            this.btn_OutDir.Text = "Change";
            this.btn_OutDir.UseVisualStyleBackColor = true;
            // 
            // textBox_OutDir
            // 
            this.textBox_OutDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_OutDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::InstantVideoConverter.Properties.Settings.Default, "OutputPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_OutDir.Location = new System.Drawing.Point(8, 308);
            this.textBox_OutDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_OutDir.Name = "textBox_OutDir";
            this.textBox_OutDir.ReadOnly = true;
            this.textBox_OutDir.Size = new System.Drawing.Size(570, 22);
            this.textBox_OutDir.TabIndex = 6;
            this.textBox_OutDir.Text = global::InstantVideoConverter.Properties.Settings.Default.OutputPath;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Output Directory";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButton_mp4);
            this.groupBox7.Controls.Add(this.radioButton_mov);
            this.groupBox7.Location = new System.Drawing.Point(8, 200);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(220, 53);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Container Format";
            // 
            // radioButton_mp4
            // 
            this.radioButton_mp4.AutoSize = true;
            this.radioButton_mp4.Checked = true;
            this.radioButton_mp4.Location = new System.Drawing.Point(19, 26);
            this.radioButton_mp4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_mp4.Name = "radioButton_mp4";
            this.radioButton_mp4.Size = new System.Drawing.Size(65, 21);
            this.radioButton_mp4.TabIndex = 1;
            this.radioButton_mp4.TabStop = true;
            this.radioButton_mp4.Text = "*.mp4";
            this.radioButton_mp4.UseVisualStyleBackColor = true;
            // 
            // radioButton_mov
            // 
            this.radioButton_mov.AutoSize = true;
            this.radioButton_mov.Location = new System.Drawing.Point(133, 26);
            this.radioButton_mov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_mov.Name = "radioButton_mov";
            this.radioButton_mov.Size = new System.Drawing.Size(64, 21);
            this.radioButton_mov.TabIndex = 0;
            this.radioButton_mov.Text = "*.mov";
            this.radioButton_mov.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.radioButton_Disable);
            this.groupBox3.Controls.Add(this.radioButton_Intel);
            this.groupBox3.Controls.Add(this.radioButton_CUDA);
            this.groupBox3.Location = new System.Drawing.Point(240, 179);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(197, 114);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hardware Acceleration";
            // 
            // radioButton_Disable
            // 
            this.radioButton_Disable.AutoSize = true;
            this.radioButton_Disable.Location = new System.Drawing.Point(15, 78);
            this.radioButton_Disable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_Disable.Name = "radioButton_Disable";
            this.radioButton_Disable.Size = new System.Drawing.Size(162, 21);
            this.radioButton_Disable.TabIndex = 2;
            this.radioButton_Disable.Text = "Disable ( Uses CPU )";
            this.radioButton_Disable.UseVisualStyleBackColor = true;
            this.radioButton_Disable.CheckedChanged += new System.EventHandler(this.radioButton_Disable_CheckedChanged);
            // 
            // radioButton_Intel
            // 
            this.radioButton_Intel.AutoSize = true;
            this.radioButton_Intel.Checked = true;
            this.radioButton_Intel.Location = new System.Drawing.Point(15, 53);
            this.radioButton_Intel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_Intel.Name = "radioButton_Intel";
            this.radioButton_Intel.Size = new System.Drawing.Size(172, 21);
            this.radioButton_Intel.TabIndex = 1;
            this.radioButton_Intel.TabStop = true;
            this.radioButton_Intel.Text = "Intel QSV (Media SDK)";
            this.radioButton_Intel.UseVisualStyleBackColor = true;
            this.radioButton_Intel.CheckedChanged += new System.EventHandler(this.radioButton_Disable_CheckedChanged);
            // 
            // radioButton_CUDA
            // 
            this.radioButton_CUDA.AutoSize = true;
            this.radioButton_CUDA.Location = new System.Drawing.Point(15, 28);
            this.radioButton_CUDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_CUDA.Name = "radioButton_CUDA";
            this.radioButton_CUDA.Size = new System.Drawing.Size(113, 21);
            this.radioButton_CUDA.TabIndex = 0;
            this.radioButton_CUDA.Text = "Nividia CUDA";
            this.radioButton_CUDA.UseVisualStyleBackColor = true;
            this.radioButton_CUDA.CheckedChanged += new System.EventHandler(this.radioButton_Disable_CheckedChanged);
            // 
            // groupBox_Panorama
            // 
            this.groupBox_Panorama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Panorama.Controls.Add(this.comboBox_pano);
            this.groupBox_Panorama.Controls.Add(this.label6);
            this.groupBox_Panorama.Location = new System.Drawing.Point(316, 34);
            this.groupBox_Panorama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Panorama.Name = "groupBox_Panorama";
            this.groupBox_Panorama.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Panorama.Size = new System.Drawing.Size(269, 128);
            this.groupBox_Panorama.TabIndex = 1;
            this.groupBox_Panorama.TabStop = false;
            this.groupBox_Panorama.Text = "Panorama MetaData";
            // 
            // comboBox_pano
            // 
            this.comboBox_pano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pano.FormattingEnabled = true;
            this.comboBox_pano.Items.AddRange(new object[] {
            "None",
            "Youtube Spherical Video",
            "Youtube Top-Buttom 3D",
            "Youtube Left-Right 3D"});
            this.comboBox_pano.Location = new System.Drawing.Point(19, 53);
            this.comboBox_pano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_pano.Name = "comboBox_pano";
            this.comboBox_pano.Size = new System.Drawing.Size(243, 24);
            this.comboBox_pano.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Template";
            // 
            // groupBox_video
            // 
            this.groupBox_video.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_video.Controls.Add(this.checkBox_fixed);
            this.groupBox_video.Controls.Add(this.label5);
            this.groupBox_video.Controls.Add(this.numericUpDown_height);
            this.groupBox_video.Controls.Add(this.label4);
            this.groupBox_video.Controls.Add(this.numericUpDown_width);
            this.groupBox_video.Controls.Add(this.label3);
            this.groupBox_video.Location = new System.Drawing.Point(8, 25);
            this.groupBox_video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_video.Name = "groupBox_video";
            this.groupBox_video.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_video.Size = new System.Drawing.Size(302, 137);
            this.groupBox_video.TabIndex = 0;
            this.groupBox_video.TabStop = false;
            this.groupBox_video.Text = "Adjust Your Video";
            // 
            // checkBox_fixed
            // 
            this.checkBox_fixed.AutoSize = true;
            this.checkBox_fixed.Checked = true;
            this.checkBox_fixed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_fixed.Location = new System.Drawing.Point(43, 102);
            this.checkBox_fixed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_fixed.Name = "checkBox_fixed";
            this.checkBox_fixed.Size = new System.Drawing.Size(123, 21);
            this.checkBox_fixed.TabIndex = 9;
            this.checkBox_fixed.Text = "Fix precentage";
            this.checkBox_fixed.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "pixels";
            // 
            // numericUpDown_height
            // 
            this.numericUpDown_height.Enabled = false;
            this.numericUpDown_height.Location = new System.Drawing.Point(149, 62);
            this.numericUpDown_height.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_height.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown_height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_height.Name = "numericUpDown_height";
            this.numericUpDown_height.Size = new System.Drawing.Size(71, 22);
            this.numericUpDown_height.TabIndex = 7;
            this.numericUpDown_height.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "x";
            // 
            // numericUpDown_width
            // 
            this.numericUpDown_width.Enabled = false;
            this.numericUpDown_width.Location = new System.Drawing.Point(43, 62);
            this.numericUpDown_width.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_width.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown_width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_width.Name = "numericUpDown_width";
            this.numericUpDown_width.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown_width.TabIndex = 5;
            this.numericUpDown_width.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resize (Width x Height)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(591, 596);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Audio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.listView_Audio);
            this.groupBox6.Location = new System.Drawing.Point(5, 21);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(579, 274);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Audio Channels Found";
            // 
            // listView_Audio
            // 
            this.listView_Audio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Track,
            this.Codec,
            this.Bitrate});
            this.listView_Audio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Audio.FullRowSelect = true;
            this.listView_Audio.Location = new System.Drawing.Point(3, 17);
            this.listView_Audio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Audio.Name = "listView_Audio";
            this.listView_Audio.Size = new System.Drawing.Size(573, 255);
            this.listView_Audio.TabIndex = 0;
            this.listView_Audio.UseCompatibleStateImageBehavior = false;
            this.listView_Audio.View = System.Windows.Forms.View.List;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(591, 596);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Other Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.numericUpDown_MaxTasks);
            this.groupBox4.Location = new System.Drawing.Point(9, 20);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(576, 87);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Multi Tasks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Max Parallel Tasks: ";
            // 
            // numericUpDown_MaxTasks
            // 
            this.numericUpDown_MaxTasks.Location = new System.Drawing.Point(147, 38);
            this.numericUpDown_MaxTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_MaxTasks.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_MaxTasks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_MaxTasks.Name = "numericUpDown_MaxTasks";
            this.numericUpDown_MaxTasks.Size = new System.Drawing.Size(93, 22);
            this.numericUpDown_MaxTasks.TabIndex = 0;
            this.numericUpDown_MaxTasks.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // listView_Tasks
            // 
            this.listView_Tasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_Tasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Tasks.FullRowSelect = true;
            this.listView_Tasks.HideSelection = false;
            this.listView_Tasks.Location = new System.Drawing.Point(0, 0);
            this.listView_Tasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Tasks.MultiSelect = false;
            this.listView_Tasks.Name = "listView_Tasks";
            this.listView_Tasks.Size = new System.Drawing.Size(654, 625);
            this.listView_Tasks.TabIndex = 0;
            this.listView_Tasks.UseCompatibleStateImageBehavior = false;
            this.listView_Tasks.View = System.Windows.Forms.View.Details;
            this.listView_Tasks.SelectedIndexChanged += new System.EventHandler(this.listView_Tasks_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FileName";
            this.columnHeader1.Width = 195;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Video Size";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Target Format";
            this.columnHeader2.Width = 112;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Audio";
            this.columnHeader4.Width = 105;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Progress";
            this.columnHeader5.Width = 194;
            // 
            // backgroundWorker_AddTask
            // 
            this.backgroundWorker_AddTask.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_StartWork_DoWork);
            this.backgroundWorker_AddTask.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_AddTask_RunWorkerCompleted);
            // 
            // openFileDialog_PickVideo
            // 
            this.openFileDialog_PickVideo.Filter = "MP4 files|*.mp4";
            this.openFileDialog_PickVideo.Multiselect = true;
            this.openFileDialog_PickVideo.RestoreDirectory = true;
            this.openFileDialog_PickVideo.Title = "Select your video files";
            // 
            // timer_Progress
            // 
            this.timer_Progress.Enabled = true;
            this.timer_Progress.Interval = 2000;
            this.timer_Progress.Tick += new System.EventHandler(this.timer_Progress_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 791);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Instant Video Convertor  -- Convert your video in ease";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox_Panorama.ResumeLayout(false);
            this.groupBox_Panorama.PerformLayout();
            this.groupBox_video.ResumeLayout(false);
            this.groupBox_video.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox_video;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_height;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_width;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_Panorama;
        private System.Windows.Forms.ComboBox comboBox_pano;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_fixed;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_Disable;
        private System.Windows.Forms.RadioButton radioButton_Intel;
        private System.Windows.Forms.RadioButton radioButton_CUDA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_MaxTasks;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView listView_Audio;
        private System.Windows.Forms.ColumnHeader Track;
        private System.Windows.Forms.ColumnHeader Codec;
        private System.Windows.Forms.ColumnHeader Bitrate;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton_mp4;
        private System.Windows.Forms.RadioButton radioButton_mov;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Pause;
        private System.ComponentModel.BackgroundWorker backgroundWorker_AddTask;
        private System.Windows.Forms.ListView listView_Tasks;
        private System.Windows.Forms.OpenFileDialog openFileDialog_PickVideo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Timer timer_Progress;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton_overwrite;
        private System.Windows.Forms.RadioButton radioButton_rename;
        private System.Windows.Forms.Button btn_OutDir;
        private System.Windows.Forms.TextBox textBox_OutDir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList imageList_Icons;
        private System.Windows.Forms.ToolStripMenuItem addVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startConversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseConversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeConversiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopConversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metadataInjectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanksToolStripMenuItem;
    }
}


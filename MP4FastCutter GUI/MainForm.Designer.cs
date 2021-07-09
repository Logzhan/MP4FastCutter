namespace mp4Cutter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lTrackBar = new UserControls.LTrackBar();
            this.tbVideoTime = new System.Windows.Forms.TextBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FormText = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.我ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.倍速播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayDelta200msec = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayDelta500msec = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayDelta1sec = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayDelta2sec = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayDelta5sec = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMinForm = new System.Windows.Forms.Button();
            this.btnFormMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStartCut = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnGoMore = new System.Windows.Forms.Button();
            this.btnOrinSub = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnEndCut = new System.Windows.Forms.Button();
            this.源文件名导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.源文件名导出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.分段时间名导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMediaSubWithTime = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1487, 780);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnMediaSubWithTime);
            this.panel2.Controls.Add(this.btnEndCut);
            this.panel2.Controls.Add(this.btnStartCut);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.btnGoMore);
            this.panel2.Controls.Add(this.btnOrinSub);
            this.panel2.Controls.Add(this.lTrackBar);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.tbVideoTime);
            this.panel2.Controls.Add(this.trackBar2);
            this.panel2.Location = new System.Drawing.Point(0, 852);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1487, 99);
            this.panel2.TabIndex = 1;
            // 
            // lTrackBar
            // 
            this.lTrackBar.barSubEnd = 0;
            this.lTrackBar.barSubStart = 0;
            this.lTrackBar.L_BarColor = System.Drawing.Color.LightGray;
            this.lTrackBar.L_BarSize = 10;
            this.lTrackBar.L_IsRound = true;
            this.lTrackBar.L_Maximum = 100;
            this.lTrackBar.L_Minimum = 0;
            this.lTrackBar.L_Orientation = UserControls.Orientation.Horizontal_LR;
            this.lTrackBar.L_SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lTrackBar.L_Value = 0;
            this.lTrackBar.Location = new System.Drawing.Point(12, 7);
            this.lTrackBar.Name = "lTrackBar";
            this.lTrackBar.Size = new System.Drawing.Size(1308, 10);
            this.lTrackBar.TabIndex = 11;
            this.lTrackBar.Text = "lTrackBar1";
            this.lTrackBar.Click += new System.EventHandler(this.lTrackBar_Click);
            // 
            // tbVideoTime
            // 
            this.tbVideoTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVideoTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbVideoTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVideoTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbVideoTime.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbVideoTime.Location = new System.Drawing.Point(1364, 2);
            this.tbVideoTime.Name = "tbVideoTime";
            this.tbVideoTime.ReadOnly = true;
            this.tbVideoTime.Size = new System.Drawing.Size(108, 20);
            this.tbVideoTime.TabIndex = 6;
            this.tbVideoTime.Text = "00:00:00/00:00:00";
            this.tbVideoTime.TextChanged += new System.EventHandler(this.tbVideoTime_TextChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.AutoSize = false;
            this.trackBar2.Location = new System.Drawing.Point(1317, 26);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(170, 28);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormText
            // 
            this.FormText.AutoSize = true;
            this.FormText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormText.ForeColor = System.Drawing.Color.LightGray;
            this.FormText.Location = new System.Drawing.Point(8, 10);
            this.FormText.Name = "FormText";
            this.FormText.Size = new System.Drawing.Size(161, 20);
            this.FormText.TabIndex = 5;
            this.FormText.Text = "视频快速分割器  v1.03";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(67, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(115, 56);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.关闭ToolStripMenuItem.Text = "关闭";
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我ToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(100, 30);
            // 
            // 我ToolStripMenuItem
            // 
            this.我ToolStripMenuItem.Name = "我ToolStripMenuItem";
            this.我ToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.我ToolStripMenuItem.Text = "我";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip2);
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 27);
            this.panel3.TabIndex = 10;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.控制ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(872, 28);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.MenuClose,
            this.源文件名导出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.文件ToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.文件ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.LightGray;
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // MenuOpen
            // 
            this.MenuOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.MenuOpen.ForeColor = System.Drawing.Color.LightGray;
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(181, 26);
            this.MenuOpen.Text = "打开";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // MenuClose
            // 
            this.MenuClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.MenuClose.ForeColor = System.Drawing.Color.LightGray;
            this.MenuClose.Name = "MenuClose";
            this.MenuClose.Size = new System.Drawing.Size(181, 26);
            this.MenuClose.Text = "关闭";
            this.MenuClose.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // 控制ToolStripMenuItem
            // 
            this.控制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.倍速播放ToolStripMenuItem,
            this.暂停ToolStripMenuItem,
            this.播放ToolStripMenuItem});
            this.控制ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.控制ToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.控制ToolStripMenuItem.Name = "控制ToolStripMenuItem";
            this.控制ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.控制ToolStripMenuItem.Text = "控制";
            // 
            // 倍速播放ToolStripMenuItem
            // 
            this.倍速播放ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.倍速播放ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayDelta200msec,
            this.PlayDelta500msec,
            this.PlayDelta1sec,
            this.PlayDelta2sec,
            this.PlayDelta5sec});
            this.倍速播放ToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.倍速播放ToolStripMenuItem.Name = "倍速播放ToolStripMenuItem";
            this.倍速播放ToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.倍速播放ToolStripMenuItem.Text = "倍速播放";
            // 
            // 暂停ToolStripMenuItem
            // 
            this.暂停ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
            this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.暂停ToolStripMenuItem.Text = "暂停";
            // 
            // 播放ToolStripMenuItem
            // 
            this.播放ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.播放ToolStripMenuItem.Name = "播放ToolStripMenuItem";
            this.播放ToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.播放ToolStripMenuItem.Text = "播放";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout});
            this.关于ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.关于ToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // MenuAbout
            // 
            this.MenuAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(140, 26);
            this.MenuAbout.Text = "版本信息";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // PlayDelta200msec
            // 
            this.PlayDelta200msec.Name = "PlayDelta200msec";
            this.PlayDelta200msec.Size = new System.Drawing.Size(109, 26);
            this.PlayDelta200msec.Text = "0.2s";
            this.PlayDelta200msec.Click += new System.EventHandler(this.PlayDelta200msec_Click);
            // 
            // PlayDelta500msec
            // 
            this.PlayDelta500msec.Name = "PlayDelta500msec";
            this.PlayDelta500msec.Size = new System.Drawing.Size(109, 26);
            this.PlayDelta500msec.Text = "0.5s";
            this.PlayDelta500msec.Click += new System.EventHandler(this.PlayDelta500msec_Click);
            // 
            // PlayDelta1sec
            // 
            this.PlayDelta1sec.Name = "PlayDelta1sec";
            this.PlayDelta1sec.Size = new System.Drawing.Size(109, 26);
            this.PlayDelta1sec.Text = "1.0s";
            this.PlayDelta1sec.Click += new System.EventHandler(this.PlayDelta1sec_Click);
            // 
            // PlayDelta2sec
            // 
            this.PlayDelta2sec.Name = "PlayDelta2sec";
            this.PlayDelta2sec.Size = new System.Drawing.Size(109, 26);
            this.PlayDelta2sec.Text = "2.0s";
            this.PlayDelta2sec.Click += new System.EventHandler(this.PlayDelta2sec_Click);
            // 
            // PlayDelta5sec
            // 
            this.PlayDelta5sec.Name = "PlayDelta5sec";
            this.PlayDelta5sec.Size = new System.Drawing.Size(109, 26);
            this.PlayDelta5sec.Text = "5.0s";
            this.PlayDelta5sec.Click += new System.EventHandler(this.PlayDelta5sec_Click);
            // 
            // btnMinForm
            // 
            this.btnMinForm.FlatAppearance.BorderSize = 0;
            this.btnMinForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinForm.Image = global::mp4Cutter.Properties.Resources.btn_mini_18px_1;
            this.btnMinForm.Location = new System.Drawing.Point(1357, 4);
            this.btnMinForm.Name = "btnMinForm";
            this.btnMinForm.Size = new System.Drawing.Size(36, 18);
            this.btnMinForm.TabIndex = 4;
            this.btnMinForm.UseVisualStyleBackColor = true;
            this.btnMinForm.Click += new System.EventHandler(this.btnMinForm_Click);
            // 
            // btnFormMax
            // 
            this.btnFormMax.FlatAppearance.BorderSize = 0;
            this.btnFormMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormMax.Image = global::mp4Cutter.Properties.Resources.btn_max_18px;
            this.btnFormMax.Location = new System.Drawing.Point(1402, 5);
            this.btnFormMax.Name = "btnFormMax";
            this.btnFormMax.Size = new System.Drawing.Size(36, 16);
            this.btnFormMax.TabIndex = 3;
            this.btnFormMax.UseVisualStyleBackColor = true;
            this.btnFormMax.Click += new System.EventHandler(this.btnFormMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::mp4Cutter.Properties.Resources.btn_close_18px_1;
            this.btnClose.Location = new System.Drawing.Point(1446, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 18);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStartCut
            // 
            this.btnStartCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStartCut.FlatAppearance.BorderSize = 0;
            this.btnStartCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartCut.ForeColor = System.Drawing.Color.LightGray;
            this.btnStartCut.Image = global::mp4Cutter.Properties.Resources.cut_40px;
            this.btnStartCut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStartCut.Location = new System.Drawing.Point(22, 23);
            this.btnStartCut.Name = "btnStartCut";
            this.btnStartCut.Size = new System.Drawing.Size(88, 70);
            this.btnStartCut.TabIndex = 15;
            this.btnStartCut.Text = "开始剪切";
            this.btnStartCut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStartCut.UseVisualStyleBackColor = true;
            this.btnStartCut.Click += new System.EventHandler(this.btnStartCut_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.ForeColor = System.Drawing.Color.LightGray;
            this.btnReturn.Image = global::mp4Cutter.Properties.Resources.return_40px;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.Location = new System.Drawing.Point(323, 24);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(74, 70);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "回退";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnGoMore
            // 
            this.btnGoMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGoMore.FlatAppearance.BorderSize = 0;
            this.btnGoMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoMore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoMore.ForeColor = System.Drawing.Color.LightGray;
            this.btnGoMore.Image = global::mp4Cutter.Properties.Resources.go_more_40px;
            this.btnGoMore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGoMore.Location = new System.Drawing.Point(412, 24);
            this.btnGoMore.Name = "btnGoMore";
            this.btnGoMore.Size = new System.Drawing.Size(74, 70);
            this.btnGoMore.TabIndex = 13;
            this.btnGoMore.Text = "快进";
            this.btnGoMore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGoMore.UseVisualStyleBackColor = true;
            this.btnGoMore.Click += new System.EventHandler(this.btnGoMore_Click);
            // 
            // btnOrinSub
            // 
            this.btnOrinSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrinSub.FlatAppearance.BorderSize = 0;
            this.btnOrinSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrinSub.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOrinSub.ForeColor = System.Drawing.Color.LightGray;
            this.btnOrinSub.Image = global::mp4Cutter.Properties.Resources.export_40px;
            this.btnOrinSub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrinSub.Location = new System.Drawing.Point(589, 25);
            this.btnOrinSub.Name = "btnOrinSub";
            this.btnOrinSub.Size = new System.Drawing.Size(112, 70);
            this.btnOrinSub.TabIndex = 12;
            this.btnOrinSub.Text = "原文件名导出";
            this.btnOrinSub.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrinSub.UseVisualStyleBackColor = true;
            this.btnOrinSub.Click += new System.EventHandler(this.btnOrinSub_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::mp4Cutter.Properties.Resources.play_b_48px;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlay.ForeColor = System.Drawing.Color.LightGray;
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlay.Location = new System.Drawing.Point(247, 25);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(48, 68);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "播放";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnEndCut
            // 
            this.btnEndCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEndCut.FlatAppearance.BorderSize = 0;
            this.btnEndCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndCut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEndCut.ForeColor = System.Drawing.Color.LightGray;
            this.btnEndCut.Image = global::mp4Cutter.Properties.Resources.cut_40px;
            this.btnEndCut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEndCut.Location = new System.Drawing.Point(129, 23);
            this.btnEndCut.Name = "btnEndCut";
            this.btnEndCut.Size = new System.Drawing.Size(88, 70);
            this.btnEndCut.TabIndex = 16;
            this.btnEndCut.Text = "结束剪切";
            this.btnEndCut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEndCut.UseVisualStyleBackColor = true;
            this.btnEndCut.Click += new System.EventHandler(this.btnEndCut_Click);
            // 
            // 源文件名导出ToolStripMenuItem
            // 
            this.源文件名导出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.源文件名导出ToolStripMenuItem1,
            this.分段时间名导出ToolStripMenuItem});
            this.源文件名导出ToolStripMenuItem.Name = "源文件名导出ToolStripMenuItem";
            this.源文件名导出ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.源文件名导出ToolStripMenuItem.Text = "导出";
            // 
            // 源文件名导出ToolStripMenuItem1
            // 
            this.源文件名导出ToolStripMenuItem1.Name = "源文件名导出ToolStripMenuItem1";
            this.源文件名导出ToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.源文件名导出ToolStripMenuItem1.Text = "源文件名导出";
            // 
            // 分段时间名导出ToolStripMenuItem
            // 
            this.分段时间名导出ToolStripMenuItem.Name = "分段时间名导出ToolStripMenuItem";
            this.分段时间名导出ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.分段时间名导出ToolStripMenuItem.Text = "分段时间名导出";
            // 
            // btnMediaSubWithTime
            // 
            this.btnMediaSubWithTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMediaSubWithTime.FlatAppearance.BorderSize = 0;
            this.btnMediaSubWithTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediaSubWithTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMediaSubWithTime.ForeColor = System.Drawing.Color.LightGray;
            this.btnMediaSubWithTime.Image = global::mp4Cutter.Properties.Resources.export_40px;
            this.btnMediaSubWithTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMediaSubWithTime.Location = new System.Drawing.Point(699, 24);
            this.btnMediaSubWithTime.Name = "btnMediaSubWithTime";
            this.btnMediaSubWithTime.Size = new System.Drawing.Size(112, 70);
            this.btnMediaSubWithTime.TabIndex = 17;
            this.btnMediaSubWithTime.Text = "时间名导出";
            this.btnMediaSubWithTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMediaSubWithTime.UseVisualStyleBackColor = true;
            this.btnMediaSubWithTime.Click += new System.EventHandler(this.btnMediaSubWithTime_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1488, 951);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.FormText);
            this.Controls.Add(this.btnMinForm);
            this.Controls.Add(this.btnFormMax);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "mp4快速剪辑工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbVideoTime;
        private System.Windows.Forms.Button btnPlay;
        private UserControls.LTrackBar lTrackBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFormMax;
        private System.Windows.Forms.Button btnMinForm;
        private System.Windows.Forms.Label FormText;
        private System.Windows.Forms.Button btnOrinSub;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem 我ToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuClose;
        private System.Windows.Forms.ToolStripMenuItem 控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 倍速播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnGoMore;
        private System.Windows.Forms.ToolStripMenuItem PlayDelta200msec;
        private System.Windows.Forms.ToolStripMenuItem PlayDelta500msec;
        private System.Windows.Forms.ToolStripMenuItem PlayDelta1sec;
        private System.Windows.Forms.ToolStripMenuItem PlayDelta2sec;
        private System.Windows.Forms.ToolStripMenuItem PlayDelta5sec;
        private System.Windows.Forms.Button btnStartCut;
        private System.Windows.Forms.Button btnEndCut;
        private System.Windows.Forms.ToolStripMenuItem 源文件名导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 源文件名导出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 分段时间名导出ToolStripMenuItem;
        private System.Windows.Forms.Button btnMediaSubWithTime;
    }
}


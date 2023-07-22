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
            this.button_close = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.textBox_end = new System.Windows.Forms.TextBox();
            this.textBox_start = new System.Windows.Forms.TextBox();
            this.button_add2List = new System.Windows.Forms.Button();
            this.lTrackBar = new UserControls.LTrackBar();
            this.btnEndCut = new System.Windows.Forms.Button();
            this.btnStartCut = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnGoMore = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tbVideoTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_savepath = new System.Windows.Forms.Button();
            this.textBox_savepath = new System.Windows.Forms.TextBox();
            this.checkBox_savepath = new System.Windows.Forms.CheckBox();
            this.checkBox_autoclear = new System.Windows.Forms.CheckBox();
            this.checkBox_exitclear = new System.Windows.Forms.CheckBox();
            this.button_SaveCfg = new System.Windows.Forms.Button();
            this.checkBox_showproccess = new System.Windows.Forms.CheckBox();
            this.textBox_srun = new System.Windows.Forms.TextBox();
            this.checkBox_process = new System.Windows.Forms.CheckBox();
            this.textBox_ffmpeg = new System.Windows.Forms.TextBox();
            this.checkBox_ffmpeg = new System.Windows.Forms.CheckBox();
            this.textBox_cores = new System.Windows.Forms.TextBox();
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
            this.源文件名导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.源文件名导出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.分段时间名导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.倍速播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayDelta200msec = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayDelta500msec = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayDelta1sec = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayDelta2sec = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayDelta5sec = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox_taskcount = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_ClearLog = new System.Windows.Forms.Button();
            this.button_ClearList = new System.Windows.Forms.Button();
            this.btnMinForm = new System.Windows.Forms.Button();
            this.btnFormMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox_timestamp = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1617, 910);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button_close);
            this.panel2.Controls.Add(this.button_open);
            this.panel2.Controls.Add(this.textBox_end);
            this.panel2.Controls.Add(this.textBox_start);
            this.panel2.Controls.Add(this.button_add2List);
            this.panel2.Controls.Add(this.lTrackBar);
            this.panel2.Controls.Add(this.btnEndCut);
            this.panel2.Controls.Add(this.btnStartCut);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.btnGoMore);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.tbVideoTime);
            this.panel2.Location = new System.Drawing.Point(0, 1005);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1622, 155);
            this.panel2.TabIndex = 1;
            // 
            // button_close
            // 
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_close.ForeColor = System.Drawing.Color.LightGray;
            this.button_close.Image = global::mp4Cutter.Properties.Resources.close_40px;
            this.button_close.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_close.Location = new System.Drawing.Point(93, 50);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(77, 78);
            this.button_close.TabIndex = 25;
            this.button_close.Text = "关闭";
            this.button_close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_open
            // 
            this.button_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_open.FlatAppearance.BorderSize = 0;
            this.button_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_open.ForeColor = System.Drawing.Color.LightGray;
            this.button_open.Image = global::mp4Cutter.Properties.Resources.open_40px;
            this.button_open.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_open.Location = new System.Drawing.Point(12, 50);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 78);
            this.button_open.TabIndex = 21;
            this.button_open.Text = "打开";
            this.button_open.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // textBox_end
            // 
            this.textBox_end.Enabled = false;
            this.textBox_end.Location = new System.Drawing.Point(752, 17);
            this.textBox_end.Name = "textBox_end";
            this.textBox_end.ReadOnly = true;
            this.textBox_end.Size = new System.Drawing.Size(120, 35);
            this.textBox_end.TabIndex = 20;
            this.textBox_end.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_start
            // 
            this.textBox_start.Enabled = false;
            this.textBox_start.Location = new System.Drawing.Point(626, 17);
            this.textBox_start.Name = "textBox_start";
            this.textBox_start.ReadOnly = true;
            this.textBox_start.Size = new System.Drawing.Size(120, 35);
            this.textBox_start.TabIndex = 19;
            this.textBox_start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_add2List
            // 
            this.button_add2List.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_add2List.FlatAppearance.BorderSize = 0;
            this.button_add2List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add2List.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_add2List.ForeColor = System.Drawing.Color.LightGray;
            this.button_add2List.Image = global::mp4Cutter.Properties.Resources.export_40px;
            this.button_add2List.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_add2List.Location = new System.Drawing.Point(256, 50);
            this.button_add2List.Name = "button_add2List";
            this.button_add2List.Size = new System.Drawing.Size(112, 78);
            this.button_add2List.TabIndex = 18;
            this.button_add2List.Text = "添加任务";
            this.button_add2List.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_add2List.UseVisualStyleBackColor = true;
            this.button_add2List.Click += new System.EventHandler(this.button_add2List_Click);
            // 
            // lTrackBar
            // 
            this.lTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lTrackBar.Location = new System.Drawing.Point(0, 0);
            this.lTrackBar.Name = "lTrackBar";
            this.lTrackBar.Size = new System.Drawing.Size(1613, 10);
            this.lTrackBar.TabIndex = 11;
            this.lTrackBar.Text = "lTrackBar1";
            this.lTrackBar.Click += new System.EventHandler(this.lTrackBar_Click);
            // 
            // btnEndCut
            // 
            this.btnEndCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEndCut.FlatAppearance.BorderSize = 0;
            this.btnEndCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndCut.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEndCut.ForeColor = System.Drawing.Color.LightGray;
            this.btnEndCut.Image = global::mp4Cutter.Properties.Resources.cut_40px;
            this.btnEndCut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEndCut.Location = new System.Drawing.Point(519, 50);
            this.btnEndCut.Name = "btnEndCut";
            this.btnEndCut.Size = new System.Drawing.Size(148, 78);
            this.btnEndCut.TabIndex = 16;
            this.btnEndCut.Text = "结束时间";
            this.btnEndCut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEndCut.UseVisualStyleBackColor = true;
            this.btnEndCut.Click += new System.EventHandler(this.btnEndCut_Click);
            // 
            // btnStartCut
            // 
            this.btnStartCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStartCut.FlatAppearance.BorderSize = 0;
            this.btnStartCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCut.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartCut.ForeColor = System.Drawing.Color.LightGray;
            this.btnStartCut.Image = global::mp4Cutter.Properties.Resources.cut_40px;
            this.btnStartCut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStartCut.Location = new System.Drawing.Point(417, 50);
            this.btnStartCut.Name = "btnStartCut";
            this.btnStartCut.Size = new System.Drawing.Size(112, 78);
            this.btnStartCut.TabIndex = 15;
            this.btnStartCut.Text = "开始时间";
            this.btnStartCut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStartCut.UseVisualStyleBackColor = true;
            this.btnStartCut.Click += new System.EventHandler(this.btnStartCut_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.ForeColor = System.Drawing.Color.LightGray;
            this.btnReturn.Image = global::mp4Cutter.Properties.Resources.return_40px;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.Location = new System.Drawing.Point(939, 50);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(106, 78);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "后退(-1s)";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnGoMore
            // 
            this.btnGoMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGoMore.FlatAppearance.BorderSize = 0;
            this.btnGoMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoMore.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoMore.ForeColor = System.Drawing.Color.LightGray;
            this.btnGoMore.Image = global::mp4Cutter.Properties.Resources.go_more_40px;
            this.btnGoMore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGoMore.Location = new System.Drawing.Point(1041, 50);
            this.btnGoMore.Name = "btnGoMore";
            this.btnGoMore.Size = new System.Drawing.Size(121, 78);
            this.btnGoMore.TabIndex = 13;
            this.btnGoMore.Text = "前进 (+1s)";
            this.btnGoMore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGoMore.UseVisualStyleBackColor = true;
            this.btnGoMore.Click += new System.EventHandler(this.btnGoMore_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlay.ForeColor = System.Drawing.Color.LightGray;
            this.btnPlay.Image = global::mp4Cutter.Properties.Resources.play_b_48px;
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlay.Location = new System.Drawing.Point(860, 45);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(73, 83);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "播放";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tbVideoTime
            // 
            this.tbVideoTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVideoTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbVideoTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVideoTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbVideoTime.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbVideoTime.Location = new System.Drawing.Point(1401, 16);
            this.tbVideoTime.Name = "tbVideoTime";
            this.tbVideoTime.ReadOnly = true;
            this.tbVideoTime.Size = new System.Drawing.Size(216, 32);
            this.tbVideoTime.TabIndex = 6;
            this.tbVideoTime.Text = "00:00:00/00:00:00";
            this.tbVideoTime.TextChanged += new System.EventHandler(this.tbVideoTime_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox_timestamp);
            this.groupBox1.Controls.Add(this.button_savepath);
            this.groupBox1.Controls.Add(this.textBox_savepath);
            this.groupBox1.Controls.Add(this.checkBox_savepath);
            this.groupBox1.Controls.Add(this.checkBox_autoclear);
            this.groupBox1.Controls.Add(this.checkBox_exitclear);
            this.groupBox1.Controls.Add(this.button_SaveCfg);
            this.groupBox1.Controls.Add(this.checkBox_showproccess);
            this.groupBox1.Controls.Add(this.textBox_srun);
            this.groupBox1.Controls.Add(this.checkBox_process);
            this.groupBox1.Controls.Add(this.textBox_ffmpeg);
            this.groupBox1.Controls.Add(this.checkBox_ffmpeg);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(3, 671);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 386);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项";
            // 
            // button_savepath
            // 
            this.button_savepath.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_savepath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_savepath.Location = new System.Drawing.Point(539, 159);
            this.button_savepath.Name = "button_savepath";
            this.button_savepath.Size = new System.Drawing.Size(69, 35);
            this.button_savepath.TabIndex = 30;
            this.button_savepath.Text = "路径";
            this.button_savepath.UseVisualStyleBackColor = true;
            this.button_savepath.Click += new System.EventHandler(this.button_savepath_Click);
            // 
            // textBox_savepath
            // 
            this.textBox_savepath.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_savepath.Location = new System.Drawing.Point(183, 159);
            this.textBox_savepath.Name = "textBox_savepath";
            this.textBox_savepath.ReadOnly = true;
            this.textBox_savepath.Size = new System.Drawing.Size(344, 34);
            this.textBox_savepath.TabIndex = 29;
            this.textBox_savepath.Text = "<save to same path as source file>";
            // 
            // checkBox_savepath
            // 
            this.checkBox_savepath.AutoSize = true;
            this.checkBox_savepath.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_savepath.Location = new System.Drawing.Point(6, 161);
            this.checkBox_savepath.Name = "checkBox_savepath";
            this.checkBox_savepath.Size = new System.Drawing.Size(124, 31);
            this.checkBox_savepath.TabIndex = 28;
            this.checkBox_savepath.Text = "保存路径";
            this.checkBox_savepath.UseVisualStyleBackColor = true;
            // 
            // checkBox_autoclear
            // 
            this.checkBox_autoclear.AutoSize = true;
            this.checkBox_autoclear.Checked = true;
            this.checkBox_autoclear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_autoclear.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_autoclear.Location = new System.Drawing.Point(183, 269);
            this.checkBox_autoclear.Name = "checkBox_autoclear";
            this.checkBox_autoclear.Size = new System.Drawing.Size(184, 31);
            this.checkBox_autoclear.TabIndex = 27;
            this.checkBox_autoclear.Text = "完成后清除任务";
            this.checkBox_autoclear.UseVisualStyleBackColor = true;
            // 
            // checkBox_exitclear
            // 
            this.checkBox_exitclear.AutoSize = true;
            this.checkBox_exitclear.Checked = true;
            this.checkBox_exitclear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_exitclear.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_exitclear.Location = new System.Drawing.Point(380, 269);
            this.checkBox_exitclear.Name = "checkBox_exitclear";
            this.checkBox_exitclear.Size = new System.Drawing.Size(185, 31);
            this.checkBox_exitclear.TabIndex = 26;
            this.checkBox_exitclear.Text = "退出时清除LOG";
            this.checkBox_exitclear.UseVisualStyleBackColor = true;
            // 
            // button_SaveCfg
            // 
            this.button_SaveCfg.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SaveCfg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_SaveCfg.Location = new System.Drawing.Point(494, 318);
            this.button_SaveCfg.Name = "button_SaveCfg";
            this.button_SaveCfg.Size = new System.Drawing.Size(106, 40);
            this.button_SaveCfg.TabIndex = 5;
            this.button_SaveCfg.Text = "保存配置";
            this.button_SaveCfg.UseVisualStyleBackColor = true;
            this.button_SaveCfg.Click += new System.EventHandler(this.button_SaveCfg_Click);
            // 
            // checkBox_showproccess
            // 
            this.checkBox_showproccess.AutoSize = true;
            this.checkBox_showproccess.Checked = true;
            this.checkBox_showproccess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_showproccess.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_showproccess.Location = new System.Drawing.Point(6, 269);
            this.checkBox_showproccess.Name = "checkBox_showproccess";
            this.checkBox_showproccess.Size = new System.Drawing.Size(144, 31);
            this.checkBox_showproccess.TabIndex = 4;
            this.checkBox_showproccess.Text = "显示进程窗";
            this.checkBox_showproccess.UseVisualStyleBackColor = true;
            // 
            // textBox_srun
            // 
            this.textBox_srun.Location = new System.Drawing.Point(183, 214);
            this.textBox_srun.Name = "textBox_srun";
            this.textBox_srun.Size = new System.Drawing.Size(120, 35);
            this.textBox_srun.TabIndex = 3;
            // 
            // checkBox_process
            // 
            this.checkBox_process.AutoSize = true;
            this.checkBox_process.Checked = true;
            this.checkBox_process.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_process.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_process.Location = new System.Drawing.Point(6, 218);
            this.checkBox_process.Name = "checkBox_process";
            this.checkBox_process.Size = new System.Drawing.Size(164, 31);
            this.checkBox_process.TabIndex = 2;
            this.checkBox_process.Text = "最大多线程数";
            this.checkBox_process.UseVisualStyleBackColor = true;
            // 
            // textBox_ffmpeg
            // 
            this.textBox_ffmpeg.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ffmpeg.Location = new System.Drawing.Point(183, 32);
            this.textBox_ffmpeg.Multiline = true;
            this.textBox_ffmpeg.Name = "textBox_ffmpeg";
            this.textBox_ffmpeg.Size = new System.Drawing.Size(417, 100);
            this.textBox_ffmpeg.TabIndex = 1;
            this.textBox_ffmpeg.Text = "-ss <ss> -t <t> -accurate_seek -i <input> -codec copy -avoid_negative_ts 1 -repor" +
    "t file <logfile> <output>";
            // 
            // checkBox_ffmpeg
            // 
            this.checkBox_ffmpeg.AutoSize = true;
            this.checkBox_ffmpeg.Checked = true;
            this.checkBox_ffmpeg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ffmpeg.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_ffmpeg.Location = new System.Drawing.Point(6, 34);
            this.checkBox_ffmpeg.Name = "checkBox_ffmpeg";
            this.checkBox_ffmpeg.Size = new System.Drawing.Size(162, 31);
            this.checkBox_ffmpeg.TabIndex = 0;
            this.checkBox_ffmpeg.Text = "使用FFmpeg";
            this.checkBox_ffmpeg.UseVisualStyleBackColor = true;
            this.checkBox_ffmpeg.CheckedChanged += new System.EventHandler(this.checkBox_ffmpeg_CheckedChanged);
            // 
            // textBox_cores
            // 
            this.textBox_cores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_cores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_cores.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_cores.ForeColor = System.Drawing.Color.White;
            this.textBox_cores.Location = new System.Drawing.Point(6, 522);
            this.textBox_cores.Name = "textBox_cores";
            this.textBox_cores.ReadOnly = true;
            this.textBox_cores.Size = new System.Drawing.Size(150, 27);
            this.textBox_cores.TabIndex = 23;
            this.textBox_cores.Text = "处理器数量：8";
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
            this.FormText.Location = new System.Drawing.Point(6, -1);
            this.FormText.Name = "FormText";
            this.FormText.Size = new System.Drawing.Size(230, 31);
            this.FormText.TabIndex = 5;
            this.FormText.Text = "Video Splitter 2.0.1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(137, 80);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.关闭ToolStripMenuItem.Text = "关闭";
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我ToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(113, 42);
            // 
            // 我ToolStripMenuItem
            // 
            this.我ToolStripMenuItem.Name = "我ToolStripMenuItem";
            this.我ToolStripMenuItem.Size = new System.Drawing.Size(112, 38);
            this.我ToolStripMenuItem.Text = "我";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip2);
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 50);
            this.panel3.TabIndex = 10;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.控制ToolStripMenuItem,
            this.ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(872, 38);
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
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(77, 34);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // MenuOpen
            // 
            this.MenuOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.MenuOpen.ForeColor = System.Drawing.Color.LightGray;
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(212, 44);
            this.MenuOpen.Text = "Open";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // MenuClose
            // 
            this.MenuClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.MenuClose.ForeColor = System.Drawing.Color.LightGray;
            this.MenuClose.Name = "MenuClose";
            this.MenuClose.Size = new System.Drawing.Size(212, 44);
            this.MenuClose.Text = "Close";
            this.MenuClose.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // 源文件名导出ToolStripMenuItem
            // 
            this.源文件名导出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.源文件名导出ToolStripMenuItem1,
            this.分段时间名导出ToolStripMenuItem});
            this.源文件名导出ToolStripMenuItem.Name = "源文件名导出ToolStripMenuItem";
            this.源文件名导出ToolStripMenuItem.Size = new System.Drawing.Size(212, 44);
            this.源文件名导出ToolStripMenuItem.Text = "Export";
            this.源文件名导出ToolStripMenuItem.Visible = false;
            // 
            // 源文件名导出ToolStripMenuItem1
            // 
            this.源文件名导出ToolStripMenuItem1.Name = "源文件名导出ToolStripMenuItem1";
            this.源文件名导出ToolStripMenuItem1.Size = new System.Drawing.Size(387, 44);
            this.源文件名导出ToolStripMenuItem1.Text = "Use source filename";
            // 
            // 分段时间名导出ToolStripMenuItem
            // 
            this.分段时间名导出ToolStripMenuItem.Name = "分段时间名导出ToolStripMenuItem";
            this.分段时间名导出ToolStripMenuItem.Size = new System.Drawing.Size(387, 44);
            this.分段时间名导出ToolStripMenuItem.Text = "Use filename with time";
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
            this.控制ToolStripMenuItem.Size = new System.Drawing.Size(77, 34);
            this.控制ToolStripMenuItem.Text = "编辑";
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
            this.倍速播放ToolStripMenuItem.Size = new System.Drawing.Size(206, 44);
            this.倍速播放ToolStripMenuItem.Text = "Step";
            // 
            // PlayDelta200msec
            // 
            this.PlayDelta200msec.Name = "PlayDelta200msec";
            this.PlayDelta200msec.Size = new System.Drawing.Size(186, 44);
            this.PlayDelta200msec.Text = "0.2s";
            this.PlayDelta200msec.Click += new System.EventHandler(this.PlayDelta200msec_Click);
            // 
            // PlayDelta500msec
            // 
            this.PlayDelta500msec.Name = "PlayDelta500msec";
            this.PlayDelta500msec.Size = new System.Drawing.Size(186, 44);
            this.PlayDelta500msec.Text = "0.5s";
            this.PlayDelta500msec.Click += new System.EventHandler(this.PlayDelta500msec_Click);
            // 
            // PlayDelta1sec
            // 
            this.PlayDelta1sec.Checked = true;
            this.PlayDelta1sec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlayDelta1sec.Name = "PlayDelta1sec";
            this.PlayDelta1sec.Size = new System.Drawing.Size(186, 44);
            this.PlayDelta1sec.Text = "1.0s";
            this.PlayDelta1sec.Click += new System.EventHandler(this.PlayDelta1sec_Click);
            // 
            // PlayDelta2sec
            // 
            this.PlayDelta2sec.Name = "PlayDelta2sec";
            this.PlayDelta2sec.Size = new System.Drawing.Size(186, 44);
            this.PlayDelta2sec.Text = "2.0s";
            this.PlayDelta2sec.Click += new System.EventHandler(this.PlayDelta2sec_Click);
            // 
            // PlayDelta5sec
            // 
            this.PlayDelta5sec.Name = "PlayDelta5sec";
            this.PlayDelta5sec.Size = new System.Drawing.Size(186, 44);
            this.PlayDelta5sec.Text = "5.0s";
            this.PlayDelta5sec.Click += new System.EventHandler(this.PlayDelta5sec_Click);
            // 
            // 暂停ToolStripMenuItem
            // 
            this.暂停ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
            this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(206, 44);
            this.暂停ToolStripMenuItem.Text = "Pause";
            // 
            // 播放ToolStripMenuItem
            // 
            this.播放ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.播放ToolStripMenuItem.Name = "播放ToolStripMenuItem";
            this.播放ToolStripMenuItem.Size = new System.Drawing.Size(206, 44);
            this.播放ToolStripMenuItem.Text = "Play";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout});
            this.ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.ToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(77, 34);
            this.ToolStripMenuItem.Text = "帮助";
            // 
            // MenuAbout
            // 
            this.MenuAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(194, 44);
            this.MenuAbout.Text = "Help";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(605, 462);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // textBox_taskcount
            // 
            this.textBox_taskcount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_taskcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_taskcount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_taskcount.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_taskcount.ForeColor = System.Drawing.Color.White;
            this.textBox_taskcount.Location = new System.Drawing.Point(6, 480);
            this.textBox_taskcount.Name = "textBox_taskcount";
            this.textBox_taskcount.ReadOnly = true;
            this.textBox_taskcount.Size = new System.Drawing.Size(168, 27);
            this.textBox_taskcount.TabIndex = 26;
            this.textBox_taskcount.Text = "任务： 0/0/0";
            // 
            // button_delete
            // 
            this.button_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_delete.ForeColor = System.Drawing.Color.LightGray;
            this.button_delete.Image = global::mp4Cutter.Properties.Resources.delete_40px;
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_delete.Location = new System.Drawing.Point(291, 480);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(107, 81);
            this.button_delete.TabIndex = 27;
            this.button_delete.Text = "删除任务";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_ClearLog
            // 
            this.button_ClearLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_ClearLog.FlatAppearance.BorderSize = 0;
            this.button_ClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClearLog.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ClearLog.ForeColor = System.Drawing.Color.LightGray;
            this.button_ClearLog.Image = global::mp4Cutter.Properties.Resources.empty_40px;
            this.button_ClearLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ClearLog.Location = new System.Drawing.Point(385, 480);
            this.button_ClearLog.Name = "button_ClearLog";
            this.button_ClearLog.Size = new System.Drawing.Size(112, 81);
            this.button_ClearLog.TabIndex = 25;
            this.button_ClearLog.Text = "清除LOG";
            this.button_ClearLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ClearLog.UseVisualStyleBackColor = true;
            this.button_ClearLog.Click += new System.EventHandler(this.button_ClearLog_Click);
            // 
            // button_ClearList
            // 
            this.button_ClearList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_ClearList.FlatAppearance.BorderSize = 0;
            this.button_ClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClearList.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ClearList.ForeColor = System.Drawing.Color.LightGray;
            this.button_ClearList.Image = global::mp4Cutter.Properties.Resources.empty_40px;
            this.button_ClearList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ClearList.Location = new System.Drawing.Point(489, 480);
            this.button_ClearList.Name = "button_ClearList";
            this.button_ClearList.Size = new System.Drawing.Size(112, 81);
            this.button_ClearList.TabIndex = 22;
            this.button_ClearList.Text = "清空列表";
            this.button_ClearList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ClearList.UseVisualStyleBackColor = true;
            this.button_ClearList.Click += new System.EventHandler(this.button_ClearList_Click);
            // 
            // btnMinForm
            // 
            this.btnMinForm.FlatAppearance.BorderSize = 0;
            this.btnMinForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinForm.Image = global::mp4Cutter.Properties.Resources.btn_mini_18px_1;
            this.btnMinForm.Location = new System.Drawing.Point(2117, 7);
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
            this.btnFormMax.Location = new System.Drawing.Point(2162, 8);
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
            this.btnClose.Location = new System.Drawing.Point(2206, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 18);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.listView1);
            this.panel4.Controls.Add(this.textBox_taskcount);
            this.panel4.Controls.Add(this.button_delete);
            this.panel4.Controls.Add(this.button_ClearLog);
            this.panel4.Controls.Add(this.button_ClearList);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.textBox_cores);
            this.panel4.Location = new System.Drawing.Point(1628, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(614, 1058);
            this.panel4.TabIndex = 28;
            // 
            // checkBox_timestamp
            // 
            this.checkBox_timestamp.AutoSize = true;
            this.checkBox_timestamp.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_timestamp.Location = new System.Drawing.Point(6, 318);
            this.checkBox_timestamp.Name = "checkBox_timestamp";
            this.checkBox_timestamp.Size = new System.Drawing.Size(164, 31);
            this.checkBox_timestamp.TabIndex = 31;
            this.checkBox_timestamp.Text = "文件名时间戳";
            this.checkBox_timestamp.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(2254, 1159);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.FormText);
            this.Controls.Add(this.btnMinForm);
            this.Controls.Add(this.btnFormMax);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Video Splitter 2.0.0";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbVideoTime;
        private System.Windows.Forms.Button btnPlay;
        private UserControls.LTrackBar lTrackBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFormMax;
        private System.Windows.Forms.Button btnMinForm;
        private System.Windows.Forms.Label FormText;
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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_add2List;
        private System.Windows.Forms.TextBox textBox_end;
        private System.Windows.Forms.TextBox textBox_start;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_ClearList;
        private System.Windows.Forms.TextBox textBox_cores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_ffmpeg;
        private System.Windows.Forms.TextBox textBox_ffmpeg;
        private System.Windows.Forms.TextBox textBox_srun;
        private System.Windows.Forms.CheckBox checkBox_process;
        private System.Windows.Forms.CheckBox checkBox_showproccess;
        private System.Windows.Forms.Button button_SaveCfg;
        private System.Windows.Forms.Button button_ClearLog;
        private System.Windows.Forms.CheckBox checkBox_exitclear;
        private System.Windows.Forms.TextBox textBox_taskcount;
        private System.Windows.Forms.CheckBox checkBox_autoclear;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_savepath;
        private System.Windows.Forms.TextBox textBox_savepath;
        private System.Windows.Forms.CheckBox checkBox_savepath;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkBox_timestamp;
    }
}


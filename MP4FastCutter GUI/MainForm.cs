/**--------------------------------------------------------------------------------------------
 * File Name     :  MainForm.cs
 * Description   :  Mp4分割器的主要界面窗体界面程序
 * Time          :  2021/01/13 @logzhan
 * Date          :  2021/06/18 : 
 *                  1.增加窗口的关闭和最小化的函数
 *                  2.增加软件名称V1.0.1版本
 *                  3.优化进度条位置和时间显示位置
 ---------------------------------------------------------------------------------------------**/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Management;
using CCWin;



namespace mp4Cutter
{
    public partial class MainForm : SkinMain
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr ptr);

        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);

        [DllImport("gdi32.dll")]
        public static extern int GetDeviceCaps(
        IntPtr hdc, // handle to DC
        int nIndex // index of capability
        );

        [DllImport("user32.dll")]
        internal static extern bool SetProcessDPIAware();

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("user32.dll", EntryPoint = "ShowWindow", SetLastError = true)]
        static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        delegate bool deleWindowsProc(IntPtr hWnd, string lParam);

        [DllImport("user32.dll")]
        static extern int EnumWindows(deleWindowsProc hWnd, string lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpText, int nCount);




        const int LOGPIXELSX = 88;
        const int LOGPIXELSY = 90;

        private VlcPlayer vlcPlayer;
        private bool vlcPlaying;
        //        private bool isPause;
        private string fileName = null;
        private double st = 0.0;
        private double end;
        private double cut_st = 0.0;
        private double cut_end = 0.0;
        private double deltaTime = 1.0f;
        private int core_count = 1;
        string cfg_ini = "config.ini";
        string cfg_ffmpeg = "-ss <ss> -t <t> -accurate_seek -i <input> -codec copy -avoid_negative_ts 1 <output> -y -progress <logfile> -stats_period 30";

        /*
        public static bool HideCutWindow(IntPtr hWnd, string lParam)
        {
            var sb = new StringBuilder(1024);
            GetWindowText(hWnd, sb, sb.Capacity);

            if (sb.ToString() != String.Empty && sb.ToString().Contains(lParam))
            {
                ShowWindow(hWnd, 0);
                //Console.WriteLine(DateTime.Now.ToString()+" find window !!!");
            }

            return true;
        }*/

        public bool TestFFmpegInstalled()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.Start();

            process.StandardInput.WriteLine("ffmpeg.exe -version");
            process.StandardInput.AutoFlush = true;
            process.StandardInput.WriteLine("exit");
            process.WaitForExit(10000);
            string xverison = process.StandardOutput.ReadToEnd();
            if ((xverison.Contains("version") || xverison.Contains("Version")) && (xverison.Contains("built with gcc"))) return true;
            string message = "Can not find the ffmpeg, do you want to open the page to download it now?";
            string caption = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                System.Diagnostics.Process.Start("http://ffmpeg.org/download.html#build-windows");
                this.Close();
                return true;
            }
            return false;
        }

        /**--------------------------------------------------------------------------
        * Function Name :  startProcess
        * Description   :  通过系统接口调用mp4分割器程序，未来将通过dll方式调用更好
        -------------------------------------------------------------------------**/
        public static int startProcess(string file, string workdirectory, string args,
            ProcessWindowStyle style, int xcpu)
        {
            var procId = 0;
            try
            {
                Process myprocess = new Process();
                //ProcessStartInfo startInfo = new ProcessStartInfo(file, args);
                //startInfo.WindowStyle = style;
                //startInfo.UseShellExecute = false;
                //startInfo.WorkingDirectory = workdirectory;
                //myprocess.StartInfo = startInfo;
                myprocess.StartInfo.FileName = file;
                if (style==ProcessWindowStyle.Hidden) { myprocess.StartInfo.Arguments = args + " 2>NULL";  }
                else { myprocess.StartInfo.Arguments = args; }                
                myprocess.StartInfo.UseShellExecute = false;
                myprocess.StartInfo.WindowStyle = style;
                //myprocess.ProcessorAffinity = (IntPtr)(1 << xcpu - 1);
                //myprocess.EnableRaisingEvents = true;
                //myprocess.Exited += (sender, e) => {  };
                //myprocess.ProcessorAffinity = (System.IntPtr)(1 << xcpu);
                myprocess.Start();
                //Console.WriteLine(DateTime.Now.ToString() + " start cut !!!");
                try
                {
                    procId = myprocess.Id;
                }
                catch
                {
                    procId = 0;
                }
                return procId;
            }
            catch (Exception e0)
            {
                MessageBox.Show("Process start error：" + e0.Message);
                procId = 0;
            }
            return procId;
        }


        /// <summary>
        /// 主要窗体的初始化
        /// </sumary>
        /// <paramname="void">无输入</param>
        /// <returns>
        /// 无
        /// </returns>
        public MainForm()
        {
            // 锁定界面显示DPI
            //ignoreDPI();

            InitializeComponent();

            /* Initialize the vlc player. */
            string pluginPath = System.Environment.CurrentDirectory + "\\vlc\\plugins\\";
            vlcPlayer = new VlcPlayer(pluginPath);
            /* Using panel1 for vlc to render video. */
            IntPtr rendWnd = this.panel1.Handle;
            vlcPlayer.SetRenderWindow((int)rendWnd);

            vlcPlaying = false;

            tbVideoTime.Text = "00:00:00/00:00:00";

            core_count = Environment.ProcessorCount;
            textBox_cores.Text = "ProcessorCount = " + core_count.ToString();
            textBox_srun.Text = core_count.ToString();

            this.Load += delegate
            {
                //Timer
                Timer timer = new Timer();
                timer.Interval = 10000;
                timer.Start();

                timer.Tick += delegate
                {                   
                    int xrun = 0;
                    int trun = this.listView1.Items.Count;
                    int drun = 0;
                    core_count = int.Parse(textBox_srun.Text);
                    for (int i = 0; i < trun; i++)
                    {
                        string task_s = this.listView1.Items[i].SubItems[0].Text;
                        string filepath = this.listView1.Items[i].SubItems[5].Text;
                        string time_s = this.listView1.Items[i].SubItems[1].Text;
                        string time_e = this.listView1.Items[i].SubItems[2].Text;
                        time_s = time_s.Replace(":", "");
                        time_e = time_e.Replace(":", "");

                        string xfilepath = "";
                        if (this.checkBox_savepath.Checked && this.textBox_savepath.Text.Equals("<same as source file>")==false)
                        {
                            xfilepath = this.textBox_savepath.Text;
                        }

                        if(xfilepath.Length==0)
                        {
                            xfilepath = filepath.Substring(0, filepath.LastIndexOf("\\"));
                        }

                        int fp_len = filepath.Length;
                        int fn_s = filepath.LastIndexOf("\\") + 1;
                        int fn_e = filepath.LastIndexOf(".");
                        string fn_ext = "";
                        string fn_name = "";
                        string xfilename = "";
                        if (fn_e > fn_s)
                        {
                            fn_name = filepath.Substring(fn_s, fn_e - fn_s);
                            fn_ext = filepath.Substring(fn_e + 1);
                            xfilename = xfilepath + "\\" + fn_name + "-" + time_s + "-" + time_e + "." + fn_ext;
                        }
                        else
                        {
                            fn_name = filepath.Substring(fn_s);
                            xfilename = xfilepath + "\\" + fn_name + "-" + time_s + "-" + time_e;
                        }


                        if (task_s.Equals(" "))
                        {
                            string ss = this.listView1.Items[i].SubItems[1].Text;
                            string duration = this.listView1.Items[i].SubItems[3].Text;
                            if (xrun >= core_count) continue;

                            int xpid = 0;
                            if (this.checkBox_ffmpeg.Checked)
                            {
                                string logfile = Environment.CurrentDirectory + "\\ffmpeg-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".log";

                                string arg = cfg_ffmpeg;
                                arg = arg.Replace("<ss>", ss);
                                arg = arg.Replace("<t>", duration);
                                arg = arg.Replace("<logfile>", "\"" + logfile + "\"");
                                arg = arg.Replace("<input>", "\"" + filepath + "\"");
                                arg = arg.Replace("<output>", "\"" + xfilename + "\"");
                                //if (! this.checkBox_showproccess.Checked) { arg = arg + " -loglevel quiet"; }
                               
                                if (this.checkBox_showproccess.Checked) { xpid=startProcess("ffmpeg.exe", "", arg, ProcessWindowStyle.Normal, core_count);  }
                                else { xpid=startProcess("ffmpeg.exe", "", arg, ProcessWindowStyle.Hidden, core_count); }
                                
                                this.listView1.Items[i].SubItems[9].Text = logfile;
                                this.listView1.Items[i].SubItems[8].Text = xpid.ToString();
                            }
                            else
                            {
                                string ee = this.listView1.Items[i].SubItems[2].Text;
                                string arg = "-i " + "\"" + filepath + "\"" + "?start=" + ss + "?end=" + ee + " -o " + "\"" + xfilename + "\"";                                
                                if (this.checkBox_showproccess.Checked) { xpid = startProcess("mp4spliter.exe", "", arg, ProcessWindowStyle.Normal, core_count); }
                                else { xpid = startProcess("mp4spliter.exe", "", arg, ProcessWindowStyle.Hidden, core_count); }

                            }
                            this.listView1.Items[i].SubItems[0].Text = "▷";
                            xrun++;
                        }
                        else if (task_s.Equals("▷"))
                        {
                            int xxpid = int.Parse(this.listView1.Items[i].SubItems[8].Text);
                            if (xxpid > 0)
                            {
                                try
                                {
                                    System.Diagnostics.Process proc = System.Diagnostics.Process.GetProcessById(xxpid);
                                    xrun++;
                                    continue;
                                }
                                catch
                                {
                                    xxpid = 0;
                                }
                            }
                            if (xxpid < 1)
                            {
                                string mylogfile = this.listView1.Items[i].SubItems[9].Text;
                                if (File.Exists(mylogfile))
                                {
                                    string[] allLines = System.IO.File.ReadAllLines(mylogfile);
                                    int maxline = allLines.Length;
                                    int iline = maxline - 1;
                                    for(iline=maxline-1;iline>=0;iline--)
                                    {
                                        if (allLines[iline].Contains("progress=")) {
                                            this.listView1.Items[i].SubItems[10].Text = allLines[iline].Substring(allLines[iline].IndexOf("progress=")+9);
                                            if (allLines[iline].Contains("progress=end")) {
                                                this.listView1.Items[i].SubItems[0].Text = "√";
                                                drun++;
                                                if (xrun > 0) xrun--;
                                            }
                                            break;
                                        }
                                    }
                                    if (iline >= 0) continue;
                                }
                                FileInfo xfile = new FileInfo(xfilename);
                                //xfile.CreationTime.ToString()
                                //xfile.LastWriteTime.ToString()
                                //xfile.LastAccessTime.ToString();
                                TimeSpan ts = DateTime.Now - xfile.LastWriteTime;
                                if (ts.TotalSeconds > 60)
                                {
                                    this.listView1.Items[i].SubItems[0].Text = "√";
                                    this.listView1.Items[i].SubItems[10].Text = "Complete";
                                    drun++;
                                    if (xrun > 0) xrun--;
                                    continue;
                                }
                                else
                                {
                                    xrun++;
                                }
                            }

                            /*
                            string results;
                            string wmiQuery = "select CommandLine from Win32_Process where Name='ffmpeg'";
                            int still_run = 0;
                            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(wmiQuery))
                            {
                                using (ManagementObjectCollection retObjectCollection = searcher.Get())
                                {
                                    foreach (ManagementObject retObject in retObjectCollection)
                                    {
                                        results=((string)retObject["CommandLine"]);
                                        Console.WriteLine("ffmpeg: "+ filepath +" results: "+results);
                                        if (results.IndexOf(filepath) >= 0) {
                                            Console.WriteLine("run ffmpeg: " + filepath + " results: " + results);
                                            still_run =1;
                                        }
                                    }

                                }
                            }

                            if (still_run == 0) {
                                this.listView1.Items[i].SubItems[0].Text = "*";
                                if(xrun>0) xrun--;
                            }*/
                            /*
                            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("ffmpeg");//模糊查找进程
                            if (processes.Length > 0) { break; }
                            else
                            {
                                this.listView1.Items[i].SubItems[0].Text = "*";
                            }*/
                        }
                        else if (task_s.Equals("√")) { drun++; continue; }
                    }

                    if (this.checkBox_autoclear.Checked)
                    {
                        trun = this.listView1.Items.Count;
                        for (int i = trun - 1; i >= 0; i--)
                        {
                            if (this.listView1.Items[i].SubItems[0].Text.Equals("√"))
                            {
                                this.listView1.Items[i].Remove();
                            }
                        }
                    }

                    trun = this.listView1.Items.Count;
                    xrun = 0;
                    drun = 0;
                    for (int i = 0; i < trun; i++)
                    {
                        if (this.listView1.Items[i].SubItems[0].Text.Equals("▷"))
                        {
                            xrun++;
                        }
                        else if (this.listView1.Items[i].SubItems[0].Text.Equals("√"))
                        {
                            drun++;
                        }
                    }
                    textBox_taskcount.Text = "Tasks: " + trun.ToString() + "/" + drun.ToString() + "/" + xrun.ToString();
                    /*
                    if (!this.checkBox_showproccess.Checked)
                    {
                        //FindWindowByProcessId
                        //System.IntPtr intptr = FindWindow("ConsoleWindowClass", "WAHAHA");
                        //if (intptr != IntPtr.Zero)
                        //{
                        //    ShowWindow(intptr, 0);//隐藏这个窗口
                        //}
                        //EnumWindows(HideCutWindow, "ffmpeg.exe");
                        if (!this.checkBox_ffmpeg.Checked)
                        {
                            EnumWindows(HideCutWindow, "mp4spliter");
                        }
                        else
                        {
                            EnumWindows(HideCutWindow, "ffmpeg");
                        }
                    }*/

                };
            };

        }
        /// <summary> 通过调用系统的接口,让系统忽略软件的DPI </summary>
        /// <remarks> 需要调用系统级别API </remarks>
        /// <returns> 无 </returns>
        public static int ignoreDPI()
        {
            // 重要
            SetProcessDPIAware();
            IntPtr screenDC = GetDC(IntPtr.Zero);
            int dpi_x = GetDeviceCaps(screenDC, /*DeviceCap.*/LOGPIXELSX);
            int dpi_y = GetDeviceCaps(screenDC, /*DeviceCap.*/LOGPIXELSY);
            ReleaseDC(IntPtr.Zero, screenDC);
            return dpi_x;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (vlcPlaying)
            {
                if (lTrackBar.L_Value == lTrackBar.L_Maximum)
                {
                    lTrackBar.L_Value = 0;
                    vlcPlayer.setPlayTime(lTrackBar.L_Value);
                    lTrackBar.L_Value = (int)vlcPlayer.getPlayTime();
                }
                else
                {
                    lTrackBar.L_Value = lTrackBar.L_Value + 1;
                    UpdatePlayerTime();
                }
            }
        }


        private string GetTimeString(int val)
        {
            int hour = val / 3600;
            val %= 3600;
            int minute = val / 60;
            int second = val % 60;
            return string.Format("{0:00}:{1:00}:{2:00}", hour, minute, second);
        }

        private void UpdatePlayerTime()
        {

            tbVideoTime.Text = string.Format("{0}/{1}",
            GetTimeString(lTrackBar.L_Value),
            GetTimeString(lTrackBar.L_Maximum));
        }


        private string GetTimeFileString(int val)
        {
            int hour = val / 3600;
            val %= 3600;
            int minute = val / 60;
            int second = val % 60;
            string res = hour.ToString() + "_" + minute.ToString() + "_" + second.ToString();
            return res;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //if (is_playinig_)
            //{
            //    vlc_player_.SetPlayTime(trackBar1.Value);

            //    trackBar1.Value = (int)vlc_player_.GetPlayTime();
            //    lTrackBar2.L_Value = (int)vlc_player_.GetPlayTime();
            //}
        }


        /* 播放结束引用 */
        //private void btnEnd_Click(object sender, EventArgs e)
        //{
        //    btnEnd.Text = lTrackBar.L_Value.ToString();
        //    vlcPlayer.Pause();
        //    end = lTrackBar.L_Value;

        //    lTrackBar.barSubEnd = lTrackBar.L_Value;

        //    //if (lTrackBar2.barSubStart > lTrackBar2.L_barSubEnd)
        //    //{
        //    //    lTrackBar2.barSubStart = lTrackBar2.L_barSubEnd;
        //    //}

        //    //isPause = true;
        //}

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (fileName.Length > 0)
            {
                vlcPlayer.Play();
                timer1.Start();
            }
        }



        /**--------------------------------------------------------------------------
         * Function Name :  btnMediaSub_Click
         * Description   :  主界面视频剪切按钮点击事件
         * Revsion       :  2021/12/09@logzhan : 创建初始版本
         *                  2021/01/13@logzhan : 由于文件名包含空格可能mp4spiliter识别
         *                  文件名错误。如iron man 2019.mp4直接传入命令行会导致识别错误。
         *                  为了避免这个错误需要在文件路径名加入双引号。如："aa bb.mp4"
         -------------------------------------------------------------------------**/
        private void btnMediaSub_Click(object sender, EventArgs e)
        {

        }


        /**--------------------------------------------------------------------------
         * Function Name :  lTrackBar_Click
         * Description   :  滑动进度条的点击事件响应, 当滑动进度条拖动到对应的位置后，播
         *                  放器也会播放对应的位置
         -------------------------------------------------------------------------**/
        private void lTrackBar_Click(object sender, EventArgs e)
        {
            if (vlcPlaying)
            {
                // 指定vlc播放器播放指定位置
                vlcPlayer.setPlayTime(lTrackBar.L_Value);
                // 更新进度条位置
                lTrackBar.L_Value = (int)vlcPlayer.getPlayTime();
            }
        }

        private void tbVideoTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrinSub_Click(object sender, EventArgs e)
        {
            if (checkFileTypeSupport(fileName) != true)
            {
                MessageBox.Show("File type is not supported, please try ffmpge.");
                return;
            }

            ProcessWindowStyle style = new ProcessWindowStyle();
            if (st > 0 && end > 0 && end > st)
            {

                string stTime = GetTimeFileString((int)st);
                string edTime = GetTimeFileString((int)end);

                string outputName = System.IO.Path.GetFileName(fileName);
                string outPath = "D:\\";

                string arg = "-i " + "\"" + fileName + "\"" + "?start=" + st.ToString() + "?end=" + end.ToString()
                                   + " -o " + "\"" + outPath + outputName + "\"";
                Console.WriteLine(arg);

                startProcess("mp4spliter.exe", "", arg, style, core_count);

                // 重置剪切进度条的标志
                lTrackBar.barSubStart = 0;
                lTrackBar.barSubEnd = 0;
            }
        }

        private bool checkFileTypeSupport(string fileName)
        {
            if (this.checkBox_ffmpeg.Checked) return true;
            string fileExtension = System.IO.Path.GetExtension(fileName);
            Console.WriteLine(fileExtension);
            if (fileExtension.Equals(".mp4") || fileExtension.Equals(".MP4"))
            {
                return true;
            }
            return false;
        }

        private void btnMinForm_Click(object sender, EventArgs e)
        {
            //最大化: this.WindowState = FormWindowState.Maximized;
            //原始大小: this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFormMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            // 配置Button偏移
            int HEIGHT_PADDING = 3;
            int BUTTON_PADDING = 10;

            int FormWidth = this.Width;
            int FormHeight = this.Height;
            int btnWidth = btnClose.Width;

            // 位置更新
            btnClose.Location = new Point(FormWidth - btnWidth, HEIGHT_PADDING);
            btnFormMax.Location = new Point(btnClose.Location.X - BUTTON_PADDING - btnWidth,
                HEIGHT_PADDING);
            btnMinForm.Location = new Point(btnFormMax.Location.X - BUTTON_PADDING - btnFormMax.Width,
                HEIGHT_PADDING);
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            if (vlcPlaying)
            {
                vlcPlayer.Stop();
                timer1.Stop();
                vlcPlaying = false;
            }
            // 重置剪切进度条的标志
            lTrackBar.barSubStart = 0;
            lTrackBar.barSubEnd = 0;
            textBox_start.Text = "00:00:00";
            textBox_end.Text = "00:00:00";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                vlcPlayer.PlayFile(ofd.FileName);
                fileName = ofd.FileName;

                lTrackBar.L_Maximum = (int)vlcPlayer.Duration();
                lTrackBar.L_Minimum = 0;

                end = vlcPlayer.Duration();
                cut_end = end;
                int iend = (int)end;
                int st_h = iend / 3600;
                string str_h = st_h.ToString();
                if (st_h < 10) str_h = "0" + st_h.ToString();
                int st_m = iend % 3600 / 60;
                string str_m = st_m.ToString();
                if (st_m < 10) str_m = "0" + st_m.ToString();
                int st_s = iend % 3600 % 60;
                string str_s = st_s.ToString();
                if (st_s < 10) str_s = "0" + st_s.ToString();
                textBox_end.Text = str_h + ":" + str_m + ":" + str_s;
                lTrackBar.L_Value = 0;
                timer1.Start();
                vlcPlaying = true;
            }
        }

        private void MenuClose_Click(object sender, EventArgs e)
        {
            if (vlcPlaying)
            {
                vlcPlayer.Stop();
                timer1.Stop();
                vlcPlaying = false;
            }
            // 重置剪切进度条的标志
            lTrackBar.barSubStart = 0;
            lTrackBar.barSubEnd = 0;
            textBox_start.Text = "00:00:00";
            textBox_end.Text = "00:00:00";
            tbVideoTime.Text = "00:00:00/00:00:00";
            fileName = "";
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            Form AboutUs = new AboutForm();
            AboutUs.TopMost = true;
            AboutUs.ShowDialog();
        }
        /// <summary> 回退按钮点击后播放进度回退一定时间 </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            vlcPlayer.Pause();
            double currTime = vlcPlayer.getPlayTime() - deltaTime;
            vlcPlayer.setPlayTime(currTime);
            // 更新滑块位置和时间显示
            lTrackBar.L_Value = (int)vlcPlayer.getPlayTime();
            UpdatePlayerTime();
            // 定时器停止
            timer1.Stop();
        }
        private void btnGoMore_Click(object sender, EventArgs e)
        {
            vlcPlayer.Pause();
            double currTime = vlcPlayer.getPlayTime() + deltaTime;
            vlcPlayer.setPlayTime(currTime);
            // 更新滑块位置和时间显示
            lTrackBar.L_Value = (int)vlcPlayer.getPlayTime();
            UpdatePlayerTime();
            // 定时器停止
            timer1.Stop();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int x = (System.Windows.Forms.SystemInformation.WorkingArea.Width - this.Size.Width) / 2;
            int y = (System.Windows.Forms.SystemInformation.WorkingArea.Height - this.Size.Height) / 2;
            // 窗体的位置由Location属性决定
            this.StartPosition = FormStartPosition.Manual;
            // 窗体的起始位置为(x,y)
            this.Location = (Point)new Size(x, y);

            cfg_ini = Environment.CurrentDirectory + "\\config.ini";
            //if (File.Exists("config.ini"))
            {
                StringBuilder temp = new StringBuilder(1024);
                GetPrivateProfileString("options", "ffmpeg", "true", temp, 1024, cfg_ini);
                this.checkBox_ffmpeg.Checked = bool.Parse(temp.ToString());
                if(this.checkBox_ffmpeg.Checked)
                {
                    this.checkBox_ffmpeg.Checked = TestFFmpegInstalled();
                }
               

                GetPrivateProfileString("options", "ffmpeg_string", "", temp, 1024, cfg_ini);
                if (temp.Length > 0) cfg_ffmpeg = temp.ToString();
                this.textBox_ffmpeg.Text = temp.ToString();


                GetPrivateProfileString("options", "multi-proccess", "true", temp, 1024, cfg_ini);
                this.checkBox_process.Checked = bool.Parse(temp.ToString());
                GetPrivateProfileString("options", "multi-proccess-max", core_count.ToString(), temp, 1024, cfg_ini);
                this.textBox_srun.Text = temp.ToString();

                GetPrivateProfileString("options", "save-to", "false", temp, 1024, cfg_ini);
                this.checkBox_savepath.Checked = bool.Parse(temp.ToString());
                if(this.checkBox_savepath.Checked)
                {
                    GetPrivateProfileString("options", "save-to-path", "<same as source file>", temp, 1024, cfg_ini);
                    if (temp.Length == 0) { this.textBox_savepath.Text = "<same as source file>"; }
                    else { this.textBox_savepath.Text = temp.ToString(); }
                }
                else
                {
                    this.textBox_savepath.Text = "<same as source file>";
                }
               

                GetPrivateProfileString("options", "show-proccess", "true", temp, 1024, cfg_ini);
                this.checkBox_showproccess.Checked = bool.Parse(temp.ToString());
                GetPrivateProfileString("options", "clear-task-auto", "true", temp, 1024, cfg_ini);
                this.checkBox_autoclear.Checked = bool.Parse(temp.ToString());
                GetPrivateProfileString("options", "clear-log-exit", "true", temp, 1024, cfg_ini);
                this.checkBox_exitclear.Checked = bool.Parse(temp.ToString());
            }
            /*
            else
            {
                this.checkBox_ffmpeg.Checked = true;
                this.textBox_ffmpeg.Text = "-ss <ss> -t <t> -accurate_seek -i <input> -codec copy -avoid_negative_ts 1 -report <logfile> <output>";

                this.checkBox_process.Checked = true;
                this.textBox_srun.Text = core_count.ToString();

                this.checkBox_showproccess.Checked = false;
            }*/

            //设置属性
            this.listView1.GridLines = true;  //显示网格线
            this.listView1.FullRowSelect = true;  //显示全行
            this.listView1.MultiSelect = false;  //设置只能单选
            this.listView1.View = View.Details;  //设置显示模式为详细
            this.listView1.HoverSelection = true;  //当鼠标停留数秒后自动选择
            //把列名添加到listview中
            this.listView1.Columns.Add("#", 18);
            this.listView1.Columns.Add("Start-Time", 80);
            this.listView1.Columns.Add("End-Time", 80);
            this.listView1.Columns.Add("Duration", 80);
            this.listView1.Columns.Add("FileName", 200);
            this.listView1.Columns.Add("Path", 500);
            this.listView1.Columns.Add("iStart", 100);
            this.listView1.Columns.Add("iEnd", 100);
            this.listView1.Columns.Add("Pid", 80);
            this.listView1.Columns.Add("Log", 100);
            this.listView1.Columns.Add("Progress", 100);
            textBox_start.Text = "00:00:00";
            textBox_end.Text = "00:00:00";
        }

        private void PlayDelta5sec_Click(object sender, EventArgs e)
        {
            deltaTime = 5.0f;
            this.PlayDelta5sec.Checked = true;
            this.PlayDelta2sec.Checked = false;
            this.PlayDelta1sec.Checked = false;
            this.PlayDelta500msec.Checked = false;
            this.PlayDelta200msec.Checked = false;
            btnGoMore.Text = "Forward (+5s)";
            btnReturn.Text = "Back (-5s)";
        }

        private void PlayDelta200msec_Click(object sender, EventArgs e)
        {
            deltaTime = 0.2f;
            this.PlayDelta5sec.Checked = false;
            this.PlayDelta2sec.Checked = false;
            this.PlayDelta1sec.Checked = false;
            this.PlayDelta500msec.Checked = false;
            this.PlayDelta200msec.Checked = true;
            btnGoMore.Text = "Forward (+0.2s)";
            btnReturn.Text = "Back (-0.2s)";
        }

        private void PlayDelta500msec_Click(object sender, EventArgs e)
        {
            deltaTime = 0.5f;
            this.PlayDelta5sec.Checked = false;
            this.PlayDelta2sec.Checked = false;
            this.PlayDelta1sec.Checked = false;
            this.PlayDelta500msec.Checked = true;
            this.PlayDelta200msec.Checked = false;
            btnGoMore.Text = "Forward (+0.5s)";
            btnReturn.Text = "Back (-0.5s)";
        }

        private void PlayDelta2sec_Click(object sender, EventArgs e)
        {
            deltaTime = 2.0f;
            this.PlayDelta5sec.Checked = false;
            this.PlayDelta2sec.Checked = true;
            this.PlayDelta1sec.Checked = false;
            this.PlayDelta500msec.Checked = false;
            this.PlayDelta200msec.Checked = false;
            btnGoMore.Text = "Forward (+2s)";
            btnReturn.Text = "Back (-2s)";
        }

        private void PlayDelta1sec_Click(object sender, EventArgs e)
        {
            deltaTime = 1.0f;
            this.PlayDelta5sec.Checked = false;
            this.PlayDelta2sec.Checked = false;
            this.PlayDelta1sec.Checked = true;
            this.PlayDelta500msec.Checked = false;
            this.PlayDelta200msec.Checked = false;
            btnGoMore.Text = "Forward (+1s)";
            btnReturn.Text = "Back (-1s)";
        }

        private void btnStartCut_Click(object sender, EventArgs e)
        {
            int st_h = lTrackBar.L_Value / 3600;
            string str_h = st_h.ToString();
            if (st_h < 10) str_h = "0" + st_h.ToString();
            int st_m = lTrackBar.L_Value % 3600 / 60;
            string str_m = st_m.ToString();
            if (st_m < 10) str_m = "0" + st_m.ToString();
            int st_s = lTrackBar.L_Value % 3600 % 60;
            string str_s = st_s.ToString();
            if (st_s < 10) str_s = "0" + st_s.ToString();
            textBox_start.Text = str_h + ":" + str_m + ":" + str_s;
            st = lTrackBar.L_Value;
            cut_st = st;
            lTrackBar.barSubStart = lTrackBar.L_Value;
            //if (lTrackBar2.L_barSubEnd == 0) {
            //    lTrackBar2.L_barSubEnd = lTrackBar2.L_Maximum;
            //}
            // 播放器暂停
            vlcPlayer.Pause();
        }

        private void btnEndCut_Click(object sender, EventArgs e)
        {
            int st_h = lTrackBar.L_Value / 3600;
            string str_h = st_h.ToString();
            if (st_h < 10) str_h = "0" + st_h.ToString();
            int st_m = lTrackBar.L_Value % 3600 / 60;
            string str_m = st_m.ToString();
            if (st_m < 10) str_m = "0" + st_m.ToString();
            int st_s = lTrackBar.L_Value % 3600 % 60;
            string str_s = st_s.ToString();
            if (st_s < 10) str_s = "0" + st_s.ToString();
            textBox_end.Text = str_h + ":" + str_m + ":" + str_s;
            vlcPlayer.Pause();
            end = lTrackBar.L_Value;
            cut_end = end;

            lTrackBar.barSubEnd = lTrackBar.L_Value;
        }

        private void btnMediaSubWithTime_Click(object sender, EventArgs e)
        {
            if (checkFileTypeSupport(fileName) != true)
            {
                MessageBox.Show("File type is not supported, please try ffmpge.");
                return;
            }

            ProcessWindowStyle style = new ProcessWindowStyle();     
            //style= ProcessWindowStyle.Hidden;
            if (st > 0 && end > 0 && end > st)
            {

                string stTime = GetTimeFileString((int)st);
                string edTime = GetTimeFileString((int)end);

                string arg = "-i " + "\"" + fileName + "\"" + "?start=" + st.ToString() + "?end=" + end.ToString()
                                   + " -o D:\\" + stTime + "__" + edTime + ".mp4";
                Console.WriteLine(arg);

                startProcess("mp4spliter.exe", "", arg, style, core_count);

                // 重置剪切进度条的标志
                lTrackBar.barSubStart = 0;
                lTrackBar.barSubEnd = 0;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void button_add2List_Click(object sender, EventArgs e)
        {
            if (checkFileTypeSupport(fileName) != true)
            {
                MessageBox.Show("File type is not supported, please try ffmpge.");
                return;
            }
            string xfilename = fileName.Substring(fileName.LastIndexOf("\\") + 1);


            if (st > 0 && end > 0 && end > st)
            {
                //创建行对象
                ListViewItem li = new ListViewItem(" ");
                //添加同一行的数据
                double xcut = cut_end - cut_st;
                li.SubItems.Add(textBox_start.Text);
                li.SubItems.Add(textBox_end.Text);
                li.SubItems.Add(xcut.ToString());
                li.SubItems.Add(xfilename);
                li.SubItems.Add(fileName);
                li.SubItems.Add(cut_st.ToString());
                li.SubItems.Add(cut_end.ToString());
                li.SubItems.Add("");
                li.SubItems.Add("");
                li.SubItems.Add("");
                //将行对象绑定在listview对象中
                this.listView1.Items.Add(li);

            }
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            if (vlcPlaying)
            {
                vlcPlayer.Stop();
                timer1.Stop();
                vlcPlaying = false;
            }
            // 重置剪切进度条的标志
            lTrackBar.barSubStart = 0;
            lTrackBar.barSubEnd = 0;
            textBox_start.Text = "00:00:00";
            textBox_end.Text = "00:00:00";
            cut_st = 0;
            cut_end = 0;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                vlcPlayer.PlayFile(ofd.FileName);
                fileName = ofd.FileName;

                lTrackBar.L_Maximum = (int)vlcPlayer.Duration();
                lTrackBar.L_Minimum = 0;

                end = vlcPlayer.Duration();
                cut_end = end;
                int iend = (int)end;
                int st_h = iend / 3600;
                string str_h = st_h.ToString();
                if (st_h < 10) str_h = "0" + st_h.ToString();
                int st_m = iend % 3600 / 60;
                string str_m = st_m.ToString();
                if (st_m < 10) str_m = "0" + st_m.ToString();
                int st_s = iend % 3600 % 60;
                string str_s = st_s.ToString();
                if (st_s < 10) str_s = "0" + st_s.ToString();
                textBox_end.Text = str_h + ":" + str_m + ":" + str_s;
                lTrackBar.L_Value = 0;
                timer1.Start();
                vlcPlaying = true;
            }
        }

        private void button_ClearList_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                string xlog = this.listView1.Items[i].SubItems[9].Text;
                if (xlog.Length > 0 && System.IO.File.Exists(xlog))
                {
                    System.IO.File.Delete(xlog);
                }
            }
            this.listView1.Items.Clear();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.listView1.SelectedItems)
            {
                startProcess("notepad.exe", "", item.SubItems[9].Text, ProcessWindowStyle.Normal, core_count);
            }

        }


        private void button_SaveCfg_Click(object sender, EventArgs e)
        {
            WritePrivateProfileString("options", "ffmpeg", this.checkBox_ffmpeg.Checked.ToString(), cfg_ini);
            WritePrivateProfileString("options", "ffmpeg_string", this.textBox_ffmpeg.Text, cfg_ini);

            WritePrivateProfileString("options", "multi-proccess", this.checkBox_process.Checked.ToString(), cfg_ini);
            WritePrivateProfileString("options", "multi-proccess-max", this.textBox_srun.Text, cfg_ini);

            WritePrivateProfileString("options", "save-to", this.checkBox_savepath.Checked.ToString(), cfg_ini);
            WritePrivateProfileString("options", "save-to-path", this.textBox_savepath.Text, cfg_ini);

            WritePrivateProfileString("options", "show-proccess", this.checkBox_showproccess.Checked.ToString(), cfg_ini);
            WritePrivateProfileString("options", "clear-task-auto", this.checkBox_autoclear.Checked.ToString(), cfg_ini);
            WritePrivateProfileString("options", "clear-log-exit", this.checkBox_exitclear.Checked.ToString(), cfg_ini);
        }

        private void button_ClearLog_Click(object sender, EventArgs e)
        {
            DirectoryInfo dyInfo = new DirectoryInfo(Environment.CurrentDirectory);
            //GetDirectories()获取当前目录子目录（当前文件夹中的文件夹）GetFileSystemInfos()返回当前目录的的文件以及子目录
            FileSystemInfo[] fileinfo = dyInfo.GetFileSystemInfos();
            foreach (FileSystemInfo i in fileinfo)
            {
                if (i is DirectoryInfo) //判断是否文件夹
                {
                    //DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                    //subdir.Delete(true); //删除子目录和文件
                }
                else
                {
                    if (i.Extension.Equals(".log"))
                        File.Delete(i.FullName); //删除指定文件
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.checkBox_exitclear.Checked) { return; }
            DirectoryInfo dyInfo = new DirectoryInfo(Environment.CurrentDirectory);
            //GetDirectories()获取当前目录子目录（当前文件夹中的文件夹）GetFileSystemInfos()返回当前目录的的文件以及子目录
            FileSystemInfo[] fileinfo = dyInfo.GetFileSystemInfos();
            foreach (FileSystemInfo i in fileinfo)
            {
                if (i is DirectoryInfo) //判断是否文件夹
                {
                    //DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                    //subdir.Delete(true); //删除子目录和文件
                }
                else
                {
                    if (i.Extension.Equals(".log"))
                    {
                        try
                        {
                            File.Delete(i.FullName); //删除指定文件
                        }
                        catch
                        {
                        }
                    }

                }
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            if (vlcPlaying)
            {
                vlcPlayer.Stop();
                timer1.Stop();
                vlcPlaying = false;
            }
            // 重置剪切进度条的标志
            lTrackBar.barSubStart = 0;
            lTrackBar.barSubEnd = 0;
            textBox_start.Text = "00:00:00";
            textBox_end.Text = "00:00:00";
            tbVideoTime.Text = "00:00:00/00:00:00";
            fileName = "";
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.listView1.SelectedItems)
            {
                this.listView1.Items[item.Index].Remove();
            }
        }

        private void button_savepath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Please select the path";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox_savepath.Text = dialog.SelectedPath;
            }
        }

        private void checkBox_ffmpeg_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBox_ffmpeg.Checked)
            {
                this.checkBox_ffmpeg.Checked = TestFFmpegInstalled();
            }
        }
    }
}

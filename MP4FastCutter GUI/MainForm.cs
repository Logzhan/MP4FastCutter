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
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
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

        const int LOGPIXELSX = 88;
        const int LOGPIXELSY = 90;

        private VlcPlayer vlcPlayer;
        private bool vlcPlaying;
//        private bool isPause;
        private string fileName = null;
        private double st = 0.0;
        private double end;
        private double deltaTime = 1.0f;

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
            ignoreDPI();
            // 初始化系统组件
            InitializeComponent();

            string pluginPath = System.Environment.CurrentDirectory + "\\vlc\\plugins\\";
            vlcPlayer = new VlcPlayer(pluginPath);
            IntPtr render_wnd = this.panel1.Handle;
            vlcPlayer.SetRenderWindow((int)render_wnd);

            tbVideoTime.Text = "00:00:00/00:00:00";

            vlcPlaying = false;
            //isPause = false;

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

        private void UpdatePlayerTime() {

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
            vlcPlayer.Play();
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
         * Function Name :  startProcess
         * Description   :  通过系统接口调用mp4分割器程序，未来将通过dll方式调用更好
         -------------------------------------------------------------------------**/
        public static bool startProcess(string file, string workdirectory, string args, 
            ProcessWindowStyle style)
        {
            try
            {
                Process myprocess = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo(file, args);
               // startInfo.WindowStyle = style;
                //startInfo.WorkingDirectory = workdirectory;
                myprocess.StartInfo = startInfo;
                myprocess.StartInfo.UseShellExecute = false;
                myprocess.Start();
                return true;
            }
            catch (Exception e0)
            {
                MessageBox.Show("启动应用程序时出错！原因：" + e0.Message);
            }
            return false;
        }

        /**--------------------------------------------------------------------------
         * Function Name :  lTrackBar_Click
         * Description   :  滑动进度条的点击事件响应, 当滑动进度条拖动到对应的位置后，播
         *                  放器也会播放对应的位置
         -------------------------------------------------------------------------**/
        private void lTrackBar_Click(object sender, EventArgs e)
        {
            if (vlcPlaying){
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
            if (checkFileTypeSupport(fileName) != true) { 
                MessageBox.Show("文件类型仅支持MP4格式");
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

                startProcess("mp4spliter.exe", "", arg, style);

                // 重置剪切进度条的标志
                lTrackBar.barSubStart = 0;
                lTrackBar.barSubEnd = 0;
            }
        }

        private bool checkFileTypeSupport(string fileName) { 
            string fileExtension = System.IO.Path.GetExtension(fileName);
            Console.WriteLine(fileExtension);
            if (fileExtension.Equals(".mp4") || fileExtension.Equals(".MP4")) {
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
            }else {
                this.WindowState = FormWindowState.Normal;
            } 
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            // 配置Button偏移
            int HEIGHT_PADDING = 3;
            int BUTTON_PADDING = 10;

            int FormWidth  = this.Width;
            int FormHeight = this.Height;
            int btnWidth   = btnClose.Width;

            // 位置更新
            btnClose.Location   = new Point(FormWidth - btnWidth, HEIGHT_PADDING);
            btnFormMax.Location = new Point(btnClose.Location.X - BUTTON_PADDING - btnWidth, 
                HEIGHT_PADDING);
            btnMinForm.Location = new Point(btnFormMax.Location.X - BUTTON_PADDING - btnFormMax.Width,
                HEIGHT_PADDING);
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                vlcPlayer.PlayFile(ofd.FileName);
                fileName = ofd.FileName;

                lTrackBar.L_Maximum = (int)vlcPlayer.Duration();
                lTrackBar.L_Minimum = 0;

                end = vlcPlayer.Duration();
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
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            Form AboutUs = new AboutForm();
            AboutUs.Show();
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
        }

        private void PlayDelta5sec_Click(object sender, EventArgs e)
        {
            deltaTime = 5.0f;
        }

        private void PlayDelta200msec_Click(object sender, EventArgs e)
        {
            deltaTime = 0.2f;
        }

        private void PlayDelta500msec_Click(object sender, EventArgs e)
        {
            deltaTime = 0.5f;
        }

        private void PlayDelta2sec_Click(object sender, EventArgs e)
        {
            deltaTime = 2.0f;
        }

        private void PlayDelta1sec_Click(object sender, EventArgs e)
        {
            deltaTime = 1.0f;
        }

        private void btnStartCut_Click(object sender, EventArgs e)
        {
            btnStartCut.Text = lTrackBar.L_Value.ToString() + "/" + lTrackBar.L_Maximum.ToString();
            st = lTrackBar.L_Value;
            lTrackBar.barSubStart = lTrackBar.L_Value;
            //if (lTrackBar2.L_barSubEnd == 0) {
            //    lTrackBar2.L_barSubEnd = lTrackBar2.L_Maximum;
            //}
            // 播放器暂停
            vlcPlayer.Pause();
        }

        private void btnEndCut_Click(object sender, EventArgs e)
        {
            btnEndCut.Text = lTrackBar.L_Value.ToString();
            vlcPlayer.Pause();
            end = lTrackBar.L_Value;

            lTrackBar.barSubEnd = lTrackBar.L_Value;
        }

        private void btnMediaSubWithTime_Click(object sender, EventArgs e)
        {
            if (checkFileTypeSupport(fileName) != true)
            {
                MessageBox.Show("文件类型仅支持MP4格式");
                return;
            }

            ProcessWindowStyle style = new ProcessWindowStyle();

            if (st > 0 && end > 0 && end > st)
            {

                string stTime = GetTimeFileString((int)st);
                string edTime = GetTimeFileString((int)end);

                string arg = "-i " + "\"" + fileName + "\"" + "?start=" + st.ToString() + "?end=" + end.ToString()
                                   + " -o D:\\" + stTime + "__" + edTime + ".mp4";
                Console.WriteLine(arg);

                startProcess("mp4spliter.exe", "", arg, style);

                // 重置剪切进度条的标志
                lTrackBar.barSubStart = 0;
                lTrackBar.barSubEnd = 0;
            }
        }

    }
}

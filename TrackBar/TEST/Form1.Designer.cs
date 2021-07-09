namespace TEST
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lesliE_TrackBar1 = new LESLIE_UI.LESLIE_TrackBar();
            this.SuspendLayout();
            // 
            // lesliE_TrackBar1
            // 
            this.lesliE_TrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.lesliE_TrackBar1.ForeColor = System.Drawing.Color.Transparent;
            this.lesliE_TrackBar1.L_BarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lesliE_TrackBar1.L_BarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lesliE_TrackBar1.L_BarSize = 20;
            this.lesliE_TrackBar1.L_IsRound = true;
            this.lesliE_TrackBar1.L_Maximum = 100;
            this.lesliE_TrackBar1.L_Minimum = 0;
            this.lesliE_TrackBar1.L_Orientation = LESLIE_UI.Orientation.Horizontal_LR;
            this.lesliE_TrackBar1.L_Value = 0;
            this.lesliE_TrackBar1.Location = new System.Drawing.Point(95, 125);
            this.lesliE_TrackBar1.Name = "lesliE_TrackBar1";
            this.lesliE_TrackBar1.Size = new System.Drawing.Size(339, 20);
            this.lesliE_TrackBar1.TabIndex = 0;
            this.lesliE_TrackBar1.Text = "lesliE_TrackBar1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 463);
            this.Controls.Add(this.lesliE_TrackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LESLIE_UI.LESLIE_TrackBar lesliE_TrackBar1;
    }
}


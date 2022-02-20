namespace mp4Cutter
{
    partial class AboutForm
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
            this.AboutText = new System.Windows.Forms.Label();
            this.VersionContentText = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutText
            // 
            this.AboutText.AutoSize = true;
            this.AboutText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AboutText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AboutText.Location = new System.Drawing.Point(8, 6);
            this.AboutText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AboutText.Name = "AboutText";
            this.AboutText.Size = new System.Drawing.Size(35, 17);
            this.AboutText.TabIndex = 0;
            this.AboutText.Text = "Help";
            this.AboutText.Click += new System.EventHandler(this.label1_Click);
            // 
            // VersionContentText
            // 
            this.VersionContentText.AutoSize = true;
            this.VersionContentText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VersionContentText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VersionContentText.Location = new System.Drawing.Point(40, 61);
            this.VersionContentText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VersionContentText.Name = "VersionContentText";
            this.VersionContentText.Size = new System.Drawing.Size(0, 17);
            this.VersionContentText.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::mp4Cutter.Properties.Resources.btn_close_18px_1;
            this.btnClose.Location = new System.Drawing.Point(240, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 14);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.labelVersion);
            this.MainPanel.Controls.Add(this.AboutText);
            this.MainPanel.Controls.Add(this.btnClose);
            this.MainPanel.Location = new System.Drawing.Point(-2, 2);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(270, 202);
            this.MainPanel.TabIndex = 4;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelVersion.Location = new System.Drawing.Point(25, 47);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(55, 16);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = "labelText";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(268, 205);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.VersionContentText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AboutForm";
            this.Text = "关于";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutText;
        private System.Windows.Forms.Label VersionContentText;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label labelVersion;
    }
}
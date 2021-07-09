using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void lTrackBar1_LValueChanged(object sender, DemoControls.LEventArgs e)
        {
            label1.Text = ((int)e.Value).ToString();
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lTrackBar1.L_Value = trackBar1.Value;
        }
    }
}

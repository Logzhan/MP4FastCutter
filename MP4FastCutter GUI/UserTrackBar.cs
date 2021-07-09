using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vlc.net
{
    public partial class UserTrackBar : Control
    {
        public UserTrackBar()
        {
            InitializeComponent();
        }

        public UserTrackBar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}

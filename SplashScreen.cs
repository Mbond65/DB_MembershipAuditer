using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DBMembershipAuditer
{
    public partial class SplashScreen : Form
    {
        public const double _softwareVersion = 1.0;
        public const string _softwareName = "DB Membership Auditer";
        public Timer _tmr;

        public SplashScreen()
        {
            InitializeComponent();
        }
        public void SplashScreen_Load(object sender, EventArgs e)
        {
          
            _tmr = new Timer();
            _tmr.Interval = 3000;
            _tmr.Start();
            _tmr.Tick += tmr_Tick;
        }
        public void tmr_Tick(object sender, EventArgs e)
        {
            _tmr.Stop();
            MetroForm form = new DropboxMembershipAuditer();
            form.Show();
            this.Hide();
        }
    }
}

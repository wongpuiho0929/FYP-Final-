using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) {
                MessageBox.Show("Check NetWork Connection");
                Environment.Exit(Environment.ExitCode);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
         
    }
}

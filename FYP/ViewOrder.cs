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
    public partial class ViewOrder : Form
    {
        private Main main;

        public ViewOrder(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {

        }
    }
}

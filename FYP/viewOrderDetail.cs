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
    public partial class viewOrderDetail : Form
    {
        private Label lb;
        public viewOrderDetail(Label lb)
        {
            InitializeComponent();
            this.lb = lb;
        }

        private void viewOrderDetail_Load(object sender, EventArgs e)
        {
            txtboxId.Text = lb.Name.ToString();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void lbl_orderId_Click(object sender, EventArgs e)
        {

        }
    }
}

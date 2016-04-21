using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Login
{
    public partial class Refund : Form
    {
        private Main main;
        private String[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public Refund(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void refund_Load(object sender, EventArgs e)
        {
            DataTable dt_student = main.db.query("Select stuid,name,balance,email from student where status = 'refund'");
            dataGridView1.DataSource = dt_student;
           
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
       
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("Content-Type", "application/octet-stream");
                    String s = "http://" + main.db.id.Split(' ')[1] + "/fyp_php/sendEmailRefund.php?money=" + dataGridView1.SelectedRows[i].Cells["balance"].Value.ToString();
                    client.OpenRead(new Uri(s));
                    
                }
                main.db.queny("update student set status = 'freeze' where stuid='"+dataGridView1.SelectedRows[i].Cells["stuid"].Value.ToString()+"'");
            }
            MessageBox.Show("Sent");
            refund_Load(sender, e);
        }

        private void Refund_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.stopRefund();
        }
    }
}

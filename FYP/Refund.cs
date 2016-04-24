using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

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
       
                /*using (WebClient client = new WebClient())
                {
                    client.Headers.Add("Content-Type", "application/octet-stream");
                    String s = "http://" + main.db.id + "/fyp_php/sendEmailRefund.php?email="+dataGridView1.SelectedRows[i].Cells["email"].Value.ToString()+"&money=" + dataGridView1.SelectedRows[i].Cells["balance"].Value.ToString()+"&month="+comboBox1.SelectedItem.ToString();
                    client.OpenRead(new Uri(s));
                    
                }*/
                string param = "email=" + dataGridView1.SelectedRows[i].Cells["email"].Value.ToString() + "&money=" + dataGridView1.SelectedRows[i].Cells["balance"].Value.ToString() + "&month=" + comboBox1.SelectedItem.ToString();
                MessageBox.Show(sendEmail(param, "http://" + main.db.id + "/fyp_php/sendEmailRefund.php"));
                main.db.queny("update student set status = 'freeze' where stuid='"+dataGridView1.SelectedRows[i].Cells["stuid"].Value.ToString()+"'");
            }
            
            
            MessageBox.Show("Sent");
            refund_Load(sender, e);
        }

        private String sendEmail(String param, String url)
        {
            byte[] bs = Encoding.ASCII.GetBytes(param);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = bs.Length;

            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(bs, 0, bs.Length);
            }
            String s = "";
            using (WebResponse wr = req.GetResponse())
            {
                Stream responseStream = wr.GetResponseStream();

                StreamReader reader = new StreamReader(responseStream);
                s = reader.ReadLine();
            }
            return s;
        }


        private void Refund_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.stopRefund();
        }
    }
}

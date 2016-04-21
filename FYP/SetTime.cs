using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.IO;
using System.Xml;

namespace Login
{
    public partial class SetTime : Form
    {
        
        private DateTime s = new DateTime();
        private int time = 24 * 60 / 30;
        private String [] text;
        private DateTime startTime;
        private DateTime endTime;
        private String quota;
        private Main main;

        public SetTime(Main main)
        {
            InitializeComponent();
            this.main = main;
            for (int i = 0; i < time; i++)
            {
                combo_Start.Items.Add(s.ToShortTimeString());
                s = s.AddMinutes(30);
            }
            int qutoa = 10;
            for (int i = 0; i < 10; i++)
            {
                comboBox1.Items.Add(qutoa.ToString());
                qutoa += 10;
            }          
        }

       

        private void SetTime_Load(object sender, EventArgs e)
        {

            startTime = DateTime.Parse(main.getTimefromjson("http://" + main.db.id + "/fyp_php/pc/start.php"));
            endTime = DateTime.Parse(main.getTimefromjson("http://" + main.db.id + "/fyp_php/pc/end.php"));
            quota = main.getTimefromjson("http://"+main.db.id + "/fyp_php/pc/quota.php");
            comboBox1.SelectedItem = quota;
            combo_Start.SelectedItem = startTime.ToShortTimeString();
            combo_End.SelectedItem = endTime.ToShortTimeString();
        }

        private void combo_Start_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s = (time - combo_Start.SelectedIndex);
            combo_End.Items.Clear();
            DateTime startTime = new DateTime();
            for (int i = 0; i < combo_Start.SelectedIndex; i++)
            {
                startTime = startTime.AddMinutes(30);
            }
            startTime = startTime.AddMinutes(30);
            for (int i = 0; i < s-1; i++)
            {
                combo_End.Items.Add(startTime.ToShortTimeString());
                startTime = startTime.AddMinutes(30);
            }


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string param = "action=set&value=" + combo_Start.SelectedItem;
            settimetojson(param, "http://" + main.db.id + "/fyp_php/pc/start.php");
            param = "action=set&value=" + combo_End.SelectedItem;
            settimetojson(param, "http://" + main.db.id + "/fyp_php/pc/end.php");
            param = "action=set&value=" + comboBox1.SelectedItem;
            settimetojson(param, "http://" + main.db.id + "/fyp_php/pc/quota.php");
            this.Close();
        }

        private String settimetojson(String param , String url) {
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
        

        private void SetTime_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void SetTime_FormClosed(object sender, FormClosedEventArgs e)
        {
            Boolean CHAGE = true;
            if (startTime.ToShortTimeString().Equals(combo_Start.SelectedItem.ToString()))
            {
                if (endTime.ToShortTimeString().Equals(combo_End.SelectedItem.ToString())) {
                    if (quota.Equals(comboBox1.SelectedItem.ToString())) {
                        CHAGE = false;
                    }
                }
            }

            if (CHAGE)
            {
                MessageBox.Show("Changed!");
                main.Main_Load(sender, e);
            }
            
        }

        
    }
}

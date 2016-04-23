using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Login
{
    public partial class GroupCountView : Form
    {
        private int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        private int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        private orderView ov;
        private Login login;
        private Database db;
        private Thread thread;
        private CheckBoxEx[] time;
        private CheckBoxEx[] typelist;
        private int x = 0;
        public GroupCountView(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void GroupCountView_Load(object sender, EventArgs e)
        {
            this.Width = screenWidth/2+200;
            this.Height = screenHeight/2+200;
            gb_fiter.Height = this.Height;
            db = new Database();
            db.Connection();
            
            
            ov = new orderView();
            addGBFoodType();
            addTakeTime();
            CountView();
            gb_location();
            thread = new Thread(() =>
            {
                while (++x > 0) ;
            });
            thread.Start();
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Tick += new EventHandler(t_tick);
            t.Interval = 10000;
            t.Start();
        }
        private void gb_location()
        {
            int y = 7;
            this.gb_time.Location = new Point(y, 19);
            this.gb_type.Location = new Point(y, this.gb_time.Location.Y + this.gb_time.Height + 5);
        }
        private void t_tick(object sender, EventArgs e)
        {
            CountView();
        }
        private String sqlControl()
        {
            String cmdText = "SELECT food.name, count(*) as count from orders , orderfood , food ,foodtype where orderfood.orderid = orders.orderid and orderfood.orderDate = orders.orderDate and orderfood.foodid = food.foodid and orders.status = 'processing' and orderfood.orderdate = CURDATE() and foodtype.fTypeId=food.fTypeId ";
            String s = "";
            Boolean check = false;
            for (int i = 0; i < time.Length; i++)
            {
                CheckBoxEx cb = time[i];

                if (cb.Checked == true && (s.Equals("")))
                {
                    s += "'" + cb.Text + "'";
                    if (check == false)
                    {
                        check = true;
                    }
                }
                else if (cb.Checked == true)
                {
                    s += ",'" + cb.Text + "'";
                    if (check == false)
                    {
                        check = true;
                    }
                }
            }
            if (check == true) { cmdText += " AND orders.otaketime in (" + s + ")"; }

             s = "";
            check = false;
            for (int i = 0; i < typelist.Length; i++)
            {
                CheckBoxEx cb = typelist[i];

                if (cb.Checked == true && (s.Equals("")))
                {
                    s += "'" + cb.Text + "'";
                    if (check == false)
                    {
                        check = true;
                    }
                }
                else if (cb.Checked == true)
                {
                    s += ",'" + cb.Text + "'";
                    if (check == false)
                    {
                        check = true;
                    }
                }
            }
            if (check == true) { cmdText += " AND foodtype.name in (" + s + ")"; }


            cmdText += " group by food.name";
            return cmdText;
        }
        private void CountView()
        {
            if (FLP2.Controls.Count > 0)
            {
                FLP2.Controls.Clear();
            }
            
            
            DataTable dt = db.getCountAllFood(sqlControl());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Label lb = new Label();
                lb.Height = screenHeight / 3 / 2;
                lb.Width = (screenWidth - 250) / 3 / 2;
                lb.Name = dt.Rows[i]["name"].ToString();
                lb.BackColor = System.Drawing.ColorTranslator.FromHtml("#CFF3FF");
                lb.BorderStyle = BorderStyle.FixedSingle;
                lb.Font = new System.Drawing.Font("Microsoft JhengHei", 15, System.Drawing.FontStyle.Bold);

                lb.Text += dt.Rows[i]["name"].ToString();
                lb.Text += "\n" + dt.Rows[i]["count"].ToString();
                FLP2.Controls.Add(lb);
            }

        }
        private void addGBFoodType()
        {
            ov.setDt("foodType");
            DataTable dt = ov.getDt();
            int high = 15;
            this.gb_type.Height = 35 * dt.Rows.Count;
            typelist = new CheckBoxEx[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CheckBoxEx cb = new CheckBoxEx();
                cb.Location = new Point(10, high);
                high += 30;
                cb.ClientSize = new Size(30, 30);
                cb.Font = new System.Drawing.Font("Microsoft JhengHei", 12, System.Drawing.FontStyle.Bold);
                cb.Name = "cb_foodType_" + dt.Rows[i].ToString();
                cb.Text = dt.Rows[i]["name"].ToString();
                cb.Tag = dt.Rows[i]["fTypeId"].ToString();
                gb_type.Controls.Add(cb);
                cb.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
                typelist[i] = cb;
            }
        }
        private void addTakeTime()
        {
            DateTime startTime = DateTime.Parse(getTimefromjson("http://" + login.database.id + "/fyp_php/pc/start.php"));
            DateTime endTime = DateTime.Parse(getTimefromjson("http://" + login.database.id + "/fyp_php/pc/end.php"));

            int startHour = startTime.Hour - 1;
            int endHour = endTime.Hour;
            int min = 0;
            int high = 15;
            double height = 32.25;
            int timeRange = (endHour - (startHour)) * 2;
            this.gb_time.Height = (int)(height) * timeRange;
            time = new CheckBoxEx[timeRange];
            for (int i = 0; i < timeRange; i++)
            {
                CheckBoxEx cb = new CheckBoxEx();
                cb.ClientSize = new Size(30, 30);
                cb.Location = new Point(10, high);
                cb.Font = new System.Drawing.Font("Microsoft JhengHei", 18, System.Drawing.FontStyle.Bold);

                if (min == 0)
                {
                    startHour++;
                    String temp = "0" + min.ToString();
                    cb.Text = startHour.ToString() + ":" + temp;
                }
                else
                {
                    cb.Text = startHour.ToString() + ":" + min.ToString();
                }
                high += 30;
                min = (min + 30) % 60;
                cb.Name = "cb_TakeTime_" + i;
                time[i] = cb;

                cb.CheckedChanged += new EventHandler(CheckBoxTime_CheckedChanged);
                gb_time.Controls.Add(cb);

            }
        }

      public String getTimefromjson(String url)
        {
            byte[] bs = Encoding.ASCII.GetBytes("action=get");
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
      private void CheckBoxTime_CheckedChanged(Object sender, EventArgs e)
        {
            CountView();
        }
        private void CheckBox1_CheckedChanged(Object sender, EventArgs e)
        {
            CountView();
        }

        /*private void CountView()
        {
                        
            DataTable dt = db.getDb("foodtype");
            List<String> typelist = new List<string>();
            DataTable dtdata1 = db.getDb2();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                typelist.Add(dt.Rows[i]["ftypeid"].ToString());
            }
            int[] typeCounter = new int[typelist.Count];

            for (int i = 0; i < dtdata1.Rows.Count; i++)
            {
                DataTable dtdata2 = db.getDb2(dtdata1.Rows[i]["orderid"].ToString());
                for (int j = 0; j < dtdata2.Rows.Count; j++)
                {
                    String[] temp = new String[30];
                    for (int k = 0; k < typelist.Count; k++)
                    {
                        if (typelist[k].Equals(dtdata2.Rows[j]["ftypeid"]) )
                        {
                            typeCounter[k]++;
                        }
                        temp[k] = dtdata2.Rows[j]["ftypeid"].ToString();
                    }
                }

            }


            for (int i = 0; i < typelist.Count; i++)
            {
                Label lb = new Label();
                lb.Height = screenHeight / 3/2;
                lb.Width = (screenWidth - 250) / 3/2;
                lb.Name = dt.Rows[i]["name"].ToString();
                lb.BackColor = System.Drawing.ColorTranslator.FromHtml("#CFF3FF");
                lb.BorderStyle = BorderStyle.FixedSingle;
                lb.Font = new System.Drawing.Font("Microsoft JhengHei", 30, System.Drawing.FontStyle.Bold);
                
                lb.Text += dt.Rows[i]["name"].ToString(); 
                lb.Text += "\n" + typeCounter[i].ToString();
                FLP2.Controls.Add(lb);
            }
            
        }*/
        
    }
}

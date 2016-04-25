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
        private DateTime today;
        private String todayString;
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

            today = DateTime.Today;
            todayString = today.ToString("dd-MM-yyyy");
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
            String cmdText = "SELECT food.shortname as name, count(*) as count from orders , orderfood , food ,foodtype where orderfood.orderid = orders.orderid and orderfood.orderDate = orders.orderDate and orderfood.foodid = food.foodid and orders.status = 'processing' and orderfood.orderdate = CURDATE() and foodtype.fTypeId=food.fTypeId ";
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
                lb.Text += "\rQty:" + dt.Rows[i]["count"].ToString();
                FLP2.Controls.Add(lb);
                lb.Click += new EventHandler(PrintGrpMessage_click);
            }

        }
        private void PrintGrpMessage_click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to print these time group order?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Print print = new Print();
                Label lb = (Label)sender;
                String s = "Asia Pacific";
                s += "\r" + lb.Text;
                String[] context = s.Split('\r');
                if (!Directory.Exists(@"C:\\My Documents\\" + todayString + "\\"))
                {
                    DirectoryInfo di = Directory.CreateDirectory(@"C:\\My Documents\\" + todayString + "\\");
                }
                String path = @"C:\\My Documents\\" + todayString + "\\O99999999_99-99-99_(1@1).txt";
                System.IO.File.WriteAllLines(path, context);
                print.print("O99999999_99-99-99_(1@1).txt");
            }
            else
            {
                MessageBox.Show("Printing is Canelled");
            }
        }
        private void PrintMessage_click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to print these time group order?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Print print = new Print();
                String nowTime = DateTime.Now.ToString("HH-mm-ss");
                String nowTime2 = nowTime.Substring(0, 2) + ":" + nowTime.Substring(3, 2) + ":" + nowTime.Substring(6, 2);
                List<CheckBoxEx> lcb = new List<CheckBoxEx>();
                List<CheckBoxEx> tcb = new List<CheckBoxEx>();
                int printcount = 0;
                for (int i = 0; i < time.Length; i++)
                {
                    CheckBoxEx cb = time[i];
                    if (cb.Checked == true)
                        lcb.Add(cb);
                }
                for (int i = 0; i < typelist.Length; i++)
                {
                    CheckBoxEx cb = typelist[i];
                    if (cb.Checked == true)
                        tcb.Add(cb);
                }
                if (lcb.Count > 0)
                {
                    String cmdText = "";
                    if (lcb.Count > 0)
                    {
                        cmdText = "select * FROM orders O, orderFood OF, food F WHERE O.orderDate=OF.orderDate AND O.orderId=OF.orderId AND OF.foodId=F.foodId  and o.status = 'processing'";
                        cmdText += "AND O.oTakeTime in(";
                        for (int i = 0; i < lcb.Count; i++)
                        {
                            if (i != 0)
                            {
                                cmdText += ",";
                            }
                            cmdText += "'" + lcb[i].Text + ":00'";
                        }
                        cmdText += ")";
                    }
                    if (tcb.Count > 0)
                    {
                        cmdText += "AND F.fTypeId IN (";
                        for (int i = 0; i < tcb.Count; i++)
                        {
                            if (i != 0)
                            {
                                cmdText += ",";
                            }
                            cmdText += "'" + tcb[i].Tag + "'";
                        }
                        cmdText += ")";
                    }
                    cmdText += "GROUP BY o.orderid";
                    DataTable dt = db.printGrp(cmdText);
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        printcount++;
                        String counter = "(" + printcount + "/" + dt.Rows.Count + ")";
                        String s = "Asia Pacific";
                        s += "\r" + dt.Rows[j]["orderid"];
                        DataTable orderDt = db.getDb2(dt.Rows[j]["orderid"].ToString());
                        for (int k = 0; k < orderDt.Rows.Count; k++)
                            s += "\r" + orderDt.Rows[k]["shortname"];
                        s += "\rTake Time:" + dt.Rows[j]["otaketime"]; //get order string end
                        s += "\r" + nowTime2;
                        s += "\r" + counter;

                        String[] context = s.Split('\r');
                        if (!Directory.Exists(@"C:\\My Documents\\" + todayString + "\\"))
                        {
                            DirectoryInfo di = Directory.CreateDirectory(@"C:\\My Documents\\" + todayString + "\\");
                        }
                        String path = @"C:\\My Documents\\" + todayString + "\\" + context[1] + "_" + nowTime + "_(" + printcount + "@" + dt.Rows.Count + ").txt";
                        System.IO.File.WriteAllLines(path, context);
                        String filename = (context[1] + "_" + nowTime + "_(" + printcount + "@" + dt.Rows.Count + ").txt");
                        print.print(filename);
                        db.update(context[1], nowTime2);
                    }
                }
                if (lcb.Count == 0)
                {
                    MessageBox.Show("Plesae choose time first!");
                }
            }
            else
            {
                MessageBox.Show("Printing is Canelled");
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
            btn_TimeClear.Location = new Point(120, 15);
            btn_TimeClear.ClientSize = new Size(70, 100);
            btn_GrpPrint.Location = new Point(120, btn_GrpPrint.Location.Y + btn_TimeClear.ClientSize.Height);
            btn_GrpPrint.ClientSize = new Size(70, 100);
            btn_pgop.Location = new Point(120, btn_pgop.Location.Y + (btn_GrpPrint.ClientSize.Height*2));
            btn_pgop.ClientSize = new Size(70, 100);
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

        private void btn_TimeClear_Click(object sender, EventArgs e)
        {
            foreach (CheckBoxEx cb in time)
            {
                if (cb.Checked == true)
                {
                    cb.Checked = false;
                }
            }
        }

        private void btn_pgop_Click(object sender, EventArgs e)
        {
            Print print = new Print();
            List<CheckBoxEx> lcb = new List<CheckBoxEx>();
            List<CheckBoxEx> tcb = new List<CheckBoxEx>();
            for (int i = 0; i < time.Length; i++)
            {
                CheckBoxEx cb = time[i];
                if (cb.Checked == true)
                    lcb.Add(cb);
            }
            for (int i = 0; i < typelist.Length; i++)
            {
                CheckBoxEx cb = typelist[i];
                if (cb.Checked == true)
                    tcb.Add(cb);
            }
            if (lcb.Count == 1)
            {
                String cmdText = "";
                if (lcb.Count > 0)
                {
                    cmdText = "select f.shortName,o.oTakeTime ,COUNT(*) AS COUNT FROM orders O, orderFood OF, food F WHERE O.orderDate=OF.orderDate AND O.orderId=OF.orderId AND OF.foodId=F.foodId  and o.status = 'processing'";
                    cmdText += "AND O.oTakeTime in(";
                    for (int i = 0; i < lcb.Count; i++)
                    {
                        if (i != 0)
                        {
                            cmdText += ",";
                        }
                        cmdText += "'" + lcb[i].Text + ":00'";
                    }
                    cmdText += ")";
                }
                if (tcb.Count > 0)
                {
                    cmdText += "AND F.fTypeId IN (";
                    for (int i = 0; i < tcb.Count; i++)
                    {
                        if (i != 0)
                        {
                            cmdText += ",";
                        }
                        cmdText += "'" + tcb[i].Tag + "'";
                    }
                    cmdText += ")";
                }
                cmdText += "GROUP BY f.foodId";
                DataTable dt = db.printGrp(cmdText);
                String s = "Asia Pacific";
                
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    s += "\r" + dt.Rows[j]["shortname"]+ "-Qty:" + dt.Rows[j]["count"];
                }
                s += "\rTake Time:" + dt.Rows[0]["otaketime"];
                String[] context = s.Split('\r');
                if (!Directory.Exists(@"C:\\My Documents\\" + todayString + "\\"))
                {
                    DirectoryInfo di = Directory.CreateDirectory(@"C:\\My Documents\\" + todayString + "\\");
                }
                String path = @"C:\\My Documents\\" + todayString + "\\O99999999_99-99-99_(1@1).txt";
                System.IO.File.WriteAllLines(path, context);
                print.print("O99999999_99-99-99_(1@1).txt");
            }
            else
            {
                MessageBox.Show("Please choose one time only.");
            }
            
    }

        

        
        
    }
}

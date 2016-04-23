using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System.Drawing.Printing;

namespace Login
{
    public partial class kitchenView : Form
    {
        private int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        private int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        private Reprint rp;
        private GroupCountView gcv;
        private Database db;
        private orderView ov;
        private ListBox lb;
        private Login login;
        private Thread thread;
        private CheckBoxEx[] time;
        private List<Label> labelList;
        private int x = 0;
        private System.Windows.Forms.Button printButton;
        private Font printFont;
        private StreamReader streamToPrint;
        private List<String> timeList = new List<string>();
        private List<String> typeList = new List<string>();
        public kitchenView(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void kitchenView_Load(object sender, EventArgs e)
        {
            this.Width = screenWidth;
            this.Height = screenHeight;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.FLP1.Width = screenWidth - 225;
            this.FLP1.Height = screenHeight;
            this.gb1.Location = new Point(screenWidth - 200, 10);
            this.gb1.Width = 400;
            this.gb1.Height = screenHeight;
            db = new Database();
            db.Connection();
            labelList = new List<Label>();
            rp = new Reprint();
            gcv = new GroupCountView(login);
            gb_width();
            ov = new orderView();
            gbInformation();
            addGBFoodType();
            addTakeTime();
            gb_location();
            orderView();
            thread = new Thread(() =>
            {
                while (++x  > 0) ;
            });
            thread.Start();
             System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Tick += new EventHandler(t_tick);
            t.Interval = 10000;
            t.Start();
            
        }
        private void t_tick(object sender, EventArgs e)
        {
            orderView();
        }
        private void gb_width()
        {
            this.gbFunction.Width = this.gb1.Width;
            this.gb_Information.Width = this.gb1.Width;
            this.gb_foobType.Width = this.gb1.Width;
            this.gb_OrderStatus.Width = this.gb1.Width;
        }
        private void gb_location()
        {
            int y = 7;
            this.gb_Information.Location = new Point(y, 19);
            this.gbFunction.Location = new Point(y, this.gb_Information.Location.Y+this.gb_Information.Height + 10);
            this.gb_foobType.Location = new Point(y, this.gbFunction.Location.Y +this.gbFunction.Height+ 10);
            this.gb_OrderStatus.Location = new Point(y, this.gb_foobType.Location.Y+this.gb_foobType.Height+ 10);
        }
       
        private void orderView()
        {

            if (FLP1.Controls.Count> 0)
            {
                FLP1.Controls.Clear();
            }
           
            ov.setAllDt();
            DataTable AllDt = ov.getAllDt();
            for (int i = 0; i < AllDt.Rows.Count; i++)
            {
                Label lb = new Label();
                lb.Height = screenHeight / 3;
                lb.Width = (screenWidth - 250) / 3;
                lb.Name = AllDt.Rows[i]["orderid"].ToString();
                
                lb.BorderStyle = BorderStyle.FixedSingle;
                lb.Font = new System.Drawing.Font("Microsoft JhengHei", 30, System.Drawing.FontStyle.Bold);
                ov.setAllDt(lb.Name.ToString());
                DataTable orderDetail = ov.getAllDt();
                String s = "";
                s += lb.Name.ToString()+"\r";
                String[] tag = new String[orderDetail.Rows.Count+1];
                for (int j = 0; j < orderDetail.Rows.Count; j++)
                {
                    s+=orderDetail.Rows[j]["shortname"]+"\r";
                    tag[j] = orderDetail.Rows[j]["ftypeid"].ToString();
                }
                String nowTime = DateTime.Now.ToString("HH:mm");
                int currentTime = timeChanger(nowTime);
                String oldotaketime = AllDt.Rows[i]["otaketime"].ToString();
                int otakeTime = timeChanger(oldotaketime);
                if (otakeTime-currentTime > 15) { lb.BackColor = System.Drawing.ColorTranslator.FromHtml("#CFF3FF"); }
                else if (otakeTime - currentTime > 10) { lb.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFF00"); }
                else if (otakeTime - currentTime > 5) { lb.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000"); }
                else { lb.BackColor = System.Drawing.ColorTranslator.FromHtml("#8B0000"); }
                s += "Take Time:"+AllDt.Rows[i]["otaketime"];
                lb.Text = s;
                tag[orderDetail.Rows.Count] = AllDt.Rows[i]["otaketime"].ToString().Substring(0, 5);
                lb.Tag = tag;
                lb.Click += new EventHandler(orderObject_click);
                FLP1.Controls.Add(lb);
                lbl_tov.Text = "Total Order Value:" + AllDt.Rows.Count.ToString();
            }
            control();
        }
        private int timeChanger(String time)
        {
            int inttime=0;
            String[] temp = time.Split(':');
            inttime = (Convert.ToInt16(temp[0]) * 100) + Convert.ToInt16(temp[1]);
            return inttime;
        }

        private void gbInformation()
        {
            int high = 40;
            CheckBoxEx cb = new CheckBoxEx();
            cb.Location = new Point(10, high);
            cb.ClientSize = new Size(30, 30);
            cb.Font = new System.Drawing.Font("Microsoft JhengHei", 12, System.Drawing.FontStyle.Bold);
            cb.Name = "cb_gcv";
            cb.Text = "Count Viewer";
            gb_Information.Controls.Add(cb);
            cb.CheckedChanged += new EventHandler(CheckBox2_CheckedChanged);
            cb = new CheckBoxEx();
            cb.Location = new Point(10, high+31);
            cb.ClientSize = new Size(30, 30);
            cb.Font = new System.Drawing.Font("Microsoft JhengHei", 12, System.Drawing.FontStyle.Bold);
            cb.Name = "cb_reprint";
            cb.Text = "Reprint";
            gb_Information.Controls.Add(cb);
            cb.CheckedChanged += new EventHandler(CheckBox3_CheckedChanged);
        }

        private void orderObject_click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            if (labelList.IndexOf(lb)==-1)
            {
                labelList.Add(lb);
            }
            /*viewOrderDetail vod = new viewOrderDetail(lb);
            vod.Deactivate += delegate
            {
                vod.Close();
            };
            vod.Show();*/
        }
        private void addGBFoodType()
        {
            ov.setDt("foodType");
            DataTable dt = ov.getDt();
            int high = 15;
            this.gb_foobType.Height = 35 * dt.Rows.Count;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CheckBoxEx cb = new CheckBoxEx();
                cb.Location = new Point(10, high);
                high += 30;
                cb.ClientSize = new Size(30, 30);
                cb.Font = new System.Drawing.Font("Microsoft JhengHei", 12, System.Drawing.FontStyle.Bold);
                cb.Name = "cb_foodType_"+dt.Rows[i].ToString();
                cb.Text = dt.Rows[i]["name"].ToString();
                cb.Tag = dt.Rows[i]["fTypeId"].ToString();
                gb_foobType.Controls.Add(cb);
                cb.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            } 
        }
        
        private void addTakeTime()
        {
           DateTime startTime = DateTime.Parse(getTimefromjson("http://" + login.database.id + "/fyp_php/pc/start.php"));
           DateTime endTime = DateTime.Parse(getTimefromjson("http://" + login.database.id + "/fyp_php/pc/end.php"));
           
            int startHour = startTime.Hour-1;
            int endHour = endTime.Hour;
            int min = 0;
            int high = 15;
            double height = 32.25;
            int timeRange = (endHour - (startHour)) * 2;
            this.gbFunction.Height = (int)(height) * timeRange;
            time = new CheckBoxEx[timeRange];
            for (int i = 0; i < timeRange; i++)
            {
                CheckBoxEx cb = new CheckBoxEx();
                cb.ClientSize = new Size(30, 30);
                cb.Location = new Point(10, high);
                cb.Font = new System.Drawing.Font("Microsoft JhengHei", 18, System.Drawing.FontStyle.Bold);
                
                if (min == 0)
                {
                    startHour ++;
                    String temp = "0" + min.ToString();
                    cb.Text = startHour.ToString() + ":" +temp;
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
                gbFunction.Controls.Add(cb);
                
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

        private void CheckBoxTime_CheckedChanged(Object Sender, EventArgs e)
        {
            control();
        }
        private void CheckBox1_CheckedChanged(Object sender, EventArgs e)
        {
            control();
        }
        private void CheckBox2_CheckedChanged(Object sender, EventArgs e)
        {
            CheckBoxEx cb =(CheckBoxEx)sender;
           
                try {
                    if (cb.Checked == true)
                    {
                        gcv.Show();
                    }
                    else
                    {
                        gcv.Hide();
                    }
                }
                catch (Exception ex)
                {
                    gcv = new GroupCountView(login);
                    gcv.Show();
                }
            
            
        }
        private void CheckBox3_CheckedChanged(Object sender, EventArgs e)
        {
            CheckBoxEx cb = (CheckBoxEx)sender;
            try
            {
                if (cb.Checked == true)
                    rp.Show();
                else
                    rp.Hide();
            }
            catch (Exception ex)
            {
                rp = new Reprint();
                rp.Show();
            }

        }

        private void control()
        {
            typeList = new List<string>();
            timeList = new List<string>();
            for (int i = 0; i < time.Length; i++)
            {
                if (time[i].Checked == true)
                {
                    timeList.Add(time[i].Text);
                }
            }
            foreach (Control c in gb_foobType.Controls)
            {
                CheckBoxEx cb = (CheckBoxEx)c;
                if (cb.Checked == true)
                {
                    typeList.Add(cb.Tag.ToString());
                }
            }
           if (timeList.Count + typeList.Count > 1)
            {
                checkType();
                checkTime();
            }
           if (typeList.Count > 0 && timeList.Count==0)
            {
                checkType();
            }
           if (timeList.Count > 0 && typeList.Count == 0)
            {
                checkFullTime();
            }
           if (timeList.Count == 0 && typeList.Count == 0)
           {
               foreach (Control c in FLP1.Controls)
               {
                   Label lb = (Label)c;
                   lb.Show();
               }
           }
        }
        private void checkType()
        {
            
            typeList = new List<string>();
            foreach (Control c in gb_foobType.Controls)
            {
                CheckBoxEx cb = (CheckBoxEx)c;
                if (cb.Checked == true)
                {
                    typeList.Add(cb.Tag.ToString());
                }
            }
            if (typeList.Count == 0 || typeList.Count == gb_foobType.Controls.Count)
            {
                foreach (Control c in FLP1.Controls)
                {
                    Label lb = (Label)c;
                    lb.Show();
                }
                return;
            }
            foreach (Control c in FLP1.Controls)
            {
                Label lb = (Label)c;
                String[] tag = (String[])lb.Tag;
                if (tag.Any(typeList.Contains))
                {
                    lb.Show();
                }
                else
                {
                    lb.Hide();
                }
                
            }
            
        }
        private void checkTime()
        {
            timeList = new List<string>();
            for (int i = 0; i < time.Length; i++)
            {
                if (time[i].Checked == true)
                {
                    timeList.Add(time[i].Text);
                }
            }
            foreach (Control c in FLP1.Controls)
            {
                Label lb = (Label)c;
                String[] tag = (String[])lb.Tag;
                if (timeList.Contains(tag[tag.Length - 1])) { }
                else
                {
                    lb.Hide();
                }
            }
        }
        private void checkFullTime()
        {
            timeList = new List<string>();
            for (int i = 0; i < time.Length; i++)
            {
                if (time[i].Checked == true)
                {
                    timeList.Add(time[i].Text);
                }
            }
            if (timeList.Count == 0 || timeList.Count == time.Length)
            {
                foreach (Control c in FLP1.Controls)
                {
                    Label lb = (Label)c;
                    lb.Show();
                }
                return;
            }

            foreach (Control c in FLP1.Controls)
            {
                Label lb = (Label)c;
                String[] tag = (String[])lb.Tag;
                if (timeList.Contains(tag[tag.Length - 1]))
                {
                    lb.Show();
                }
                else
                {
                    lb.Hide();
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to print these order?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < labelList.Count; i++)
                {
                    String nowTime = DateTime.Now.ToString("HH-mm-ss");
                    String nowTime2 = nowTime.Substring(0, 2) + ":" + nowTime.Substring(3, 2) + ":" + nowTime.Substring(6, 2);
                    String counter = "(" + (i + 1) + "/" + labelList.Count.ToString() + ")";
                    Label lb = labelList[i];
                    String s = lb.Text;
                    s += "\r" + nowTime2;
                    s += "\r" + counter;
                    String[] OrderNo = (String[])lb.Tag;
                    String[] context = s.Split('\r');
                    if (!Directory.Exists(@"C:\\My Documents\\"))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(@"C:\\My Documents\\");
                    }
                    String path = @"C:\\My Documents\\" + context[0] +"_"+nowTime+"_("+(i+1)+"@"+labelList.Count.ToString()+").txt";
                    System.IO.File.WriteAllLines(path, context);
                    print(context[0] + "_" + nowTime + "_(" + (i+1) + "@" + labelList.Count.ToString() + ").txt");
                    db.update(context[0]);
                }
                labelList.Clear();
                orderView();
                MessageBox.Show("Printed");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Print is Canelled");
            }
            
           
        }
        private void print(String fileName)
        {
            try
            {
                streamToPrint = new StreamReader
                   ("C:\\My Documents\\" + fileName);
               
                try
                {
                    printFont = new Font("Arial", 20);
                    PrintDocument pd = new PrintDocument();
                    PaperSize paperSize = new PaperSize("My Envelope", 300, 340);
                    pd.DefaultPageSettings.Margins.Left = 20;
                    pd.DefaultPageSettings.Margins.Top = 10;
                    pd.DefaultPageSettings.PaperSize = paperSize;
                    pd.PrintPage += new PrintPageEventHandler
                       (this.pd_PrintPage);
                    pd.PrinterSettings.PrinterName = "Bullzip PDF Printer";
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;

namespace Login
{
    public partial class Main : Form
    {
        private Login login;
        public Database db;
        private int numOfOrder = 0;
        private Form[] frm ;
        private DateTime startTime;
        private DateTime endTime ;
        private Thread t;
        public Boolean lockEdit = true;

        

        public Main(Login login)
        {
            
            InitializeComponent();
            this.login = login;
            this.db = login.database;
            this.KeyPreview = true;
            
            
            AddValue addValue = new AddValue(this);
            MaintainMenu mMenu = new MaintainMenu(this);
            MaintainMenu_v2 mMenu_v2 = new MaintainMenu_v2(this);
            MaintainUser mUser = new MaintainUser(this);
       
            kitchenView kcv = new kitchenView(login);
            Report report = new Report(this);
            Form[] temp = { addValue, mMenu_v2, mUser, kcv, report };
            frm = temp;
            int count = 0;
            DataTable dt_student = db.getDb("student where status not in('refund','freeze')");
            for (int i = 0; i < dt_student.Rows.Count; i++) {
                DateTime create = DateTime.Parse(dt_student.Rows[i]["createAt"].ToString());
                if (create.AddYears(2).ToShortDateString().Equals(DateTime.Now.ToShortDateString())) {
                    String s = "Update student set status ='refund' where stuid='" + dt_student.Rows[i]["stuid"].ToString() + "'";
                    db.queny(s);
                    count++;
                }
            }
            MessageBox.Show("There are "+count+" students' status change to refund.");

            string subPath = "Menu"; // your code goes here
            System.IO.Directory.CreateDirectory(subPath);
            string menuday = "1Monday";
            System.IO.Directory.CreateDirectory(subPath+"\\"+menuday);
             menuday = "2Tuesday";
            System.IO.Directory.CreateDirectory(subPath + "\\" + menuday);
             menuday = "3Wednesday";
            System.IO.Directory.CreateDirectory(subPath + "\\" + menuday);
             menuday = "4Thursday";
            System.IO.Directory.CreateDirectory(subPath + "\\" + menuday);
             menuday = "5Friday";
            System.IO.Directory.CreateDirectory(subPath + "\\" + menuday);
             menuday = "6Saturday";
            System.IO.Directory.CreateDirectory(subPath + "\\" + menuday);
             menuday = "7Sunday";
            System.IO.Directory.CreateDirectory(subPath + "\\" + menuday);
        }

        public void Main_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Parse(getTimefromjson("http://" + db.id.Split(' ')[1] + "/fyp_php/pc/start.php"));
            endTime = DateTime.Parse(getTimefromjson("http://" + db.id.Split(' ')[1] + "/fyp_php/pc/end.php"));
            label3.Text = startTime.ToShortTimeString() + " - " + endTime.ToShortTimeString();
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            var y = screen.WorkingArea.Width;
            listBox1.Width = y / 2;
            grp_takeOrder.Width = y / 2;
            y = y / 4;
            var x = btn_AddValue.Size.Height;
            Button[] btn = { btn_AddValue, btn_Menu, btn_Staff, btn_ViewOrder};
            for (int i = 0; i < btn.Length; i++) {
                btn[i].Size = new Size(y, x);
            }
            for (int i = 1; i < btn.Length; i++)
            {
                x = btn[i-1].Location.X + btn[i].Size.Width;
                btn[i].Location = new Point(x,3);
            }
            timer1.Start();
            timer2.Start();
            lab_username.Text="Username: " + login.userName;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            this.time.Text = DateTime.Now.ToString();

            if (DateTime.Now > startTime && DateTime.Now < endTime)
            {
                lab_status.BackColor = Color.Red;
                lab_status.Text = "System is Running!!";
                lockEdit = true;
            }
            else {
                lab_status.BackColor = Color.Chartreuse;
                lab_status.Text = "Out of service";
                lockEdit = false;
            }

            if (DateTime.Now.ToLongTimeString().Equals(DateTime.Parse("00:00:00").ToLongTimeString()))
            {
                MessageBox.Show(""+db.dailyChange());
            }

            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DataTable db_orders = db.getDb("orders where status not in('finish') and orderdate = CURDATE()");
            label6.Text = db_orders.Rows.Count.ToString();
            DataTable db_price = db.query("Select Sum(totalPrice) from orders where status not in('cancel') and orderdate = CURDATE()");
            if (db_price.Rows[0][0].ToString().Equals("") || db_price.Rows[0][0].ToString() == "" || db_price.Rows[0][0].ToString() == null)
            {
                label9.Text = "$0";
            }
            else { label9.Text = "$" + db_price.Rows[0][0].ToString(); }
            DataTable db_Student = db.query("SELECT status,count(*) FROM `student` group by `status`");
            label12.Text = "0";
            label14.Text = "0";
            label16.Text = "0";
            label18.Text = "0";
            for (int i = 0; i < db_Student.Rows.Count; i++) {
                if (db_Student.Rows[i][0].ToString().Equals("approve")) {
                    label12.Text = db_Student.Rows[i][1].ToString();
                }
                else if (db_Student.Rows[i][0].ToString().Equals("freeze"))
                {
                    label16.Text = db_Student.Rows[i][1].ToString();
                }
                else if (db_Student.Rows[i][0].ToString().Equals("processing"))
                {
                    label14.Text = db_Student.Rows[i][1].ToString();
                }
                else if (db_Student.Rows[i][0].ToString().Equals("refund")) {
                    label18.Text = db_Student.Rows[i][1].ToString();
                }
            }

            label10.Text = int.Parse(label12.Text) + int.Parse(label14.Text) + int.Parse(label16.Text) + int.Parse(label18.Text) + "";
            if (label9.Text == "") {
                label9.Text = "$0";
            }
            for (int i = numOfOrder; i < db_orders.Rows.Count; i++)
            {   
                String s = db_orders.Rows[i]["stuid"].ToString();
                String oid = db_orders.Rows[i]["orderId"].ToString();
                s += "  " + oid;
                s += "  at  " + db_orders.Rows[i]["oTakeTime"].ToString();
                s += ": order ";

                DataTable db_orderFood = db.getDb("orderfood where orderid = '" + oid + "' and orderdate = CURDATE()");
                if (db_orderFood.Rows.Count > 1)
                {
                    for (int k = 0; k < db_orderFood.Rows.Count; k++)
                    {
                        String fid = db_orderFood.Rows[k]["foodId"].ToString();
                        DataTable db_food = db.getDb("food where foodid='" + fid + "'");
                        s += "  "+db_food.Rows[0]["shortname"];
                    }
                }
                else {
                    String fid = db_orderFood.Rows[0]["foodId"].ToString();
                    DataTable db_food = db.getDb("food where foodid='" + fid + "'");
                    s += "  " +db_food.Rows[0]["shortname"];
                }
              
                listBox1.Items.Insert(0,s);
                numOfOrder++;
            }
          
            /* ---generate total refund student money------
             DataTable dt_History = db.getDb("stuhistory ");
           
            int totalMoney = 0;
            for (int i = 0; i < dt_History.Rows.Count; i++)
            {
                totalMoney += Convert.ToInt32(dt_History.Rows[i]["balance"].ToString());
            }
           
            lab_TotalMoney.Text = "Total of Student Money:  " + totalMoney;
             ----------------------------------------------------------------*/
        }





        //--------------------------Close Action ----------------------------//
        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.txt_password.Text = "";
            login.Show();
            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            login.txt_password.Text = "";
            login.Show();
        }

        private void Close_MouseHover(object sender, EventArgs e)
        {
            Close.BackColor = Color.CadetBlue;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackColor = SystemColors.Control;
        }
        //-------------------------------------------------------------------//

        private void btn_AddValue_Click(object sender, EventArgs e)
        {
            showForm(0);
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            showForm(1);
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            showForm(2);
        }

        private void btn_ViewOrder_Click(object sender, EventArgs e)
        {
            Screen[] sc; 
            sc = Screen.AllScreens;
            frm[3].Left = sc[0].Bounds.Left;
            frm[3].Top = sc[0].Bounds.Top;
            frm[3].StartPosition = FormStartPosition.Manual;
            try
            {
                frm[3].Show();
            } catch{
                frm[3] = new kitchenView(login);
                frm[3].Show();
            }
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            showForm(4);
        }

        private void showForm(int i) {
            frm[i].ShowDialog();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            showForm(5);
        }

        

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.F5) {
                listBox1.Items.Clear();
                numOfOrder = 0;
                DataTable db_orders = db.getDb("orders where status not in('finish')");

                for (int i = numOfOrder; i < db_orders.Rows.Count; i++)
                {
                    String s = db_orders.Rows[i]["stuid"].ToString();
                    String oid = db_orders.Rows[i]["orderId"].ToString();
                    s += "  " + oid;
                    s += "  at  " + db_orders.Rows[i]["oTakeTime"].ToString();
                    s += ": order ";

                    DataTable db_orderFood = db.getDb("orderfood where orderid = '" + oid + "'");
                    if (db_orderFood.Rows.Count > 1)
                    {
                        for (int k = 0; k < db_orderFood.Rows.Count; k++)
                        {
                            String fid = db_orderFood.Rows[k]["foodId"].ToString();
                            DataTable db_food = db.getDb("food where foodid='" + fid + "'");
                            s += "  " + db_food.Rows[0]["shortname"];
                        }
                    }
                    else
                    {
                        String fid = db_orderFood.Rows[0]["foodId"].ToString();
                        DataTable db_food = db.getDb("food where foodid='" + fid + "'");
                        s += "  " + db_food.Rows[0]["shortname"];
                    }

                    listBox1.Items.Insert(0, s);
                    numOfOrder++;
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pic_refund_Click(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(Refund));
            t.Start();
            
        }

        public void Refund()
        {
            Application.Run(new Refund(this));
        }

        public void stopRefund()
        {

            
            
        }

        private void pic_setTime_Click(object sender, EventArgs e)
        {
            SetTime s = new SetTime(this);
            s.ShowDialog();
        }

        private void pic_DB_Click(object sender, EventArgs e)
        {
            OldDataToDB ODTD = new OldDataToDB(this);
            ODTD.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void pic_confirm_Click(object sender, EventArgs e)
        {
            Staff s = new Staff(login);
            s.ShowDialog();
        }

        

        

       

    }
}

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
    public partial class AddValue : Form
    {
        private Main main;
        private double total;
        private Database db;
        private DataTable dt_Student;
        private double balance;

        public AddValue( Main main)
        {
            InitializeComponent();
            this.main = main;
            this.KeyPreview = true;
            lab_total.Text = "Total : " + total;
            db = main.db;
        }

        private void AddValue_Load(object sender, EventArgs e)
        {
            total = 0;
            lab_total.Text = "Total : " + total;
            txt_studID.Text = "";
            lab_Info.Text = "Info";
            txt_studID.Enabled = true;
            this.ActiveControl = txt_studID;
            ListBox_History.Items.Clear();
        }

       

        private void txt_studID_TextChanged(object sender, EventArgs e)
        {
            showHistory();
        }

        private void showHistory() {
            dt_Student = db.getDb("Student");
            ListBox_History.Items.Clear();
            for (int i = 0; i < dt_Student.Rows.Count; i++)
            {
                if (txt_studID.Text.Equals(dt_Student.Rows[i]["stuId"]))
                {
                    lab_Info.Text = "Student Name : \n" + dt_Student.Rows[i]["name"];
                    lab_Info.Text += "\nStudent Balance : \n" + dt_Student.Rows[i]["balance"];
                    txt_studID.Enabled = false;
                    balance = Convert.ToDouble(dt_Student.Rows[i]["balance"].ToString());
                    DataTable db_History = db.getDb("stuhistory where stuid ='" + txt_studID.Text + "'");
                    for (int k = 0; k < db_History.Rows.Count; k++)
                    {
                        String s = db_History.Rows[k][0].ToString() + "\t\t" + db_History.Rows[k][2].ToString() + "\t\t" + db_History.Rows[k][3].ToString();
                        ListBox_History.Items.Add(s);
                    }
                }
            } 
        }
        //-----------------------Add function---------------------------------//
        private void btn_50_Click(object sender, EventArgs e)
        {
            addValue(50);
        }

        private void btn_100_Click(object sender, EventArgs e)
        {
            addValue(100);
        }

        private void btn_500_Click(object sender, EventArgs e)
        {
            addValue(500);
        }

        private void addValue(int i)
        {
            total += i;
            lab_total.Text = "Total : " + total;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            double temp = total;
            total += balance;
            if (total > 998)
            {
                MessageBox.Show("Balance cannot larger than 998");
                AddValue_Load(sender, e);
            }else if(txt_studID.Text==""){
                MessageBox.Show("Please scan one more time.");
               AddValue_Load( sender,  e);
            }
            else
            {
                String s = "Update student set balance=" + total + " where stuid='" + txt_studID.Text + "';";
                db.queny("Update student set balance=" + total + " where stuid='" + txt_studID.Text + "';");
                total = 0;
                lab_total.Text = "Total : " + total;
                DataTable changeData = db.getDb("Student where stuid='" + txt_studID.Text + "';");
                lab_Info.Text = "Student Name : \n" + changeData.Rows[0]["name"];
                lab_Info.Text += "\nStudent Balance : \n" + changeData.Rows[0]["balance"];
                balance = Convert.ToDouble(changeData.Rows[0]["balance"].ToString());
                s = "INSERT INTO stuHistory(datetime, stuId, action, balance) VALUES( NOW(),'" + txt_studID.Text + "', 'Add Value'," + temp + ");";
                db.queny(s);
                showHistory();
               
            }
        }

        private void AddValue_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode==Keys.Escape) {
                AddValue_Load(sender, e);
            }
        }

        //----------------------- End Add function---------------------------------//
    }
}

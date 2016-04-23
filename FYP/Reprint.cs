using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Reprint : Form
    {
        private DateTime today ;
        private String todayString;
        private Database db;
        private kitchenView kv;
        public Reprint(kitchenView kv)
        {
            InitializeComponent();
            this.kv = kv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String orderNo = tb_ono.Text;
            String hours = cb_hour.Text;
            String mins = cb_min.Text;
            String second =cb_second.Text;
            string path = @"C:\\My Documents\\" + todayString + "\\";
            string[] files = Directory.GetFiles(@"C:\\My Documents\\" + todayString + "\\", "*.txt");
            List<String> filterFiles = new List<String>();
            lv_listFile.Items.Clear();
            if (!orderNo.Equals(""))
            {
                for (int i = 0; i < files.Length; i++)
                {
                    if (files[i].Contains(orderNo))
                    {
                        filterFiles.Add(files[i]);
                        string name = Path.GetFileName(files[i]);
                        ListViewItem lv = deconde(name);
                        lv_listFile.Items.Add(lv);

                    }
                }
            }
            else if (!cb_time_choose.Text.Equals(""))
            {
                String[] sqlprinttime = cb_time_choose.Text.Split(':');
                String filename = sqlprinttime[0] + "-" + sqlprinttime[1] + "-" + sqlprinttime[2];
                for (int i = 0; i < files.Length; i++)
                {
                    if (files[i].Contains(filename))
                    {
                        filterFiles.Add(files[i]);
                        string name = Path.GetFileName(files[i]);
                        ListViewItem lv = deconde(name);
                        lv_listFile.Items.Add(lv);

                    }
                }
            }
            else
            {
                String checkTimeString = "";
                if (!hours.Equals(""))
                    checkTimeString += hours;
                if (!mins.Equals("") && !hours.Equals(""))
                    checkTimeString += "-" + mins;
                else if (!mins.Equals(""))
                    checkTimeString += mins;
                if (!second.Equals("") && (!mins.Equals("") || !hours.Equals("")))
                    checkTimeString += "-" + second;
                else if (!second.Equals(""))
                    checkTimeString += second;
                
                for (int i = 0; i < files.Length; i++)
                {
                    if (files[i].Contains(checkTimeString))
                    {
                        filterFiles.Add(files[i]);
                        string name = Path.GetFileName(files[i]);
                        ListViewItem lv = deconde(name);
                        lv_listFile.Items.Add(lv);

                    }
                }
            }
            
            
        }
        private ListViewItem deconde(String filename)
        {
            ListViewItem lv = new ListViewItem();
            lv.Tag = filename;
            String oid = filename.Substring(0, 9);
            String time = filename.Substring(10, 8);
            int countMax =filename.IndexOf(')') - filename.IndexOf('(');
            String count = filename.Substring(filename.IndexOf('(')+1, countMax-1);
            String[] countMaxMin = count.Split('@');
            String[] time2 = time.Split('-');
            lv.SubItems.Add(oid);
            lv.SubItems.Add(time2[0]+":"+time2[1]+":"+time2[2]);
            lv.SubItems.Add(countMaxMin[0]+"/"+countMaxMin[1]);
            return lv;
        }
        private void Reprint_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            today = DateTime.Today;
            todayString = today.ToString("dd-MM-yyyy");
            db = new Database();
            db.Connection();
            addHours();
            addChoose();
            cb_time_choose.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_hour.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_min.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_second.DropDownStyle = ComboBoxStyle.DropDownList;
            lv_listFile.MultiSelect = true;
            lv_listFile.CheckBoxes = true;
        }
        private void addHours()
        {
            cb_hour.Items.Add("");
            cb_min.Items.Add("");
            cb_second.Items.Add("");
            for (int i = 0; i < 24; i++)
            {
                if (i < 10)
                {
                    String temp = "0" + i.ToString();
                    cb_hour.Items.Add(temp);
                }
                else 
                cb_hour.Items.Add(i.ToString());
            }
            for (int i = 0; i < 60; i++)
            {
                if (i < 10)
                {
                    String temp = "0" + i.ToString();
                    cb_min.Items.Add(temp);
                    cb_second.Items.Add(temp);
                }
                else
                {
                    cb_second.Items.Add(i.ToString());
                    cb_min.Items.Add(i.ToString());
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Do you want to print these order?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem lv in lv_listFile.CheckedItems)
                {
                    StringBuilder newFile = new StringBuilder();
                    string[] file = File.ReadAllLines(@"C:\\My Documents\\" + todayString + "\\" + lv.Tag);
                    file[0] = "Asia Pacific-Reprint";
                    String path = @"C:\\My Documents\\" + todayString + "\\" + lv.Tag;
                    System.IO.File.WriteAllLines(path, file);
                    Print print = new Print();
                    print.print(lv.Tag.ToString());
                }
                MessageBox.Show("Printed");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Print is Canelled");
            }
        }
        private void addChoose()
        {
            DataTable dt =db.getPrintTime();
            cb_time_choose.Items.Add("");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!dt.Rows[i]["printtime"].Equals("NULL"))
                {
                    cb_time_choose.Items.Add(dt.Rows[i]["printtime"]);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in lv_listFile.Items)
            {
                lv.Checked=true;
            }
        }

    }
}

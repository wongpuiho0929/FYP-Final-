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
    public partial class addFood : Form
    {
        private String fid;
        private Main main;
        private DataTable dt_foodtype;
        private DateTime date;
        private String photoPath;
        private MaintainMenu_v2 m_v2;
        private Boolean foodAddChick = false;

        public addFood(String fid, Main main, DateTime date, MaintainMenu_v2 m_v2)
        {
            InitializeComponent();
            this.fid = fid;
            this.main = main;
            this.date = date;
            this.m_v2 = m_v2;

            dt_foodtype = main.db.getDb("foodtype");
            for (int i = 0; i < dt_foodtype.Rows.Count; i++)
            {
                combo_FoodType.Items.Add(dt_foodtype.Rows[i]["name"].ToString());
            }

            /*if (date.ToShortDateString().Equals(DateTime.Today.ToShortDateString()))
            {
                dt_foodtype = main.db.getDb("foodtype");
                for (int i = 0; i < dt_foodtype.Rows.Count; i++)
                {
                    combo_FoodType.Items.Add(dt_foodtype.Rows[i]["name"].ToString());
                }
            }
            else {
                String dd = date.Day.ToString();
                String mm = date.Month.ToString();
                String yyyy = date.Year.ToString();
                String fileName = "";
                String[] temp = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i].Equals(date.DayOfWeek.ToString()))
                    {
                        fileName = i + 1 + temp[i];
                    }
                }
                fileName += "\\" + dd + "_" + mm + "_" + yyyy + ".xlsx";

                dt_foodtype = readXlsx(fileName, "foodtype");
                for (int i = 0; i < dt_foodtype.Rows.Count; i++)
                {
                    String name = dt_foodtype.Rows[i]["name"].ToString();
                    combo_FoodType.Items.Add(dt_foodtype.Rows[i]["name"].ToString());
                }

            }*/
        }


        private DataTable readXlsx(String fileName,String tableName)
        {

            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.DataSet DtSet;
                System.Data.OleDb.OleDbDataAdapter MyCommand;
                String appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\menu\\";
                String menu = "["+tableName+"$]";
                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;Data Source='" + appPath + fileName + "';Extended Properties=Excel 12.0;");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from " + menu, MyConnection);
                MyCommand.TableMappings.Add("Table", "TestTable");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                MyConnection.Close();
                return DtSet.Tables[0];
            }
            catch
            {
                String[] temp = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                String s = "";
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i].Equals(date.DayOfWeek.ToString()))
                    {
                        s = i + 1 + temp[i];
                    }
                }
                DataTable a = readXlsx(s + "\\test.xlsx",tableName);
                return a;
            }
        }

        private void addFood_Load(object sender, EventArgs e)
        {
            if (main.lockEdit)
            {
                tabControl1.Enabled = false;
            }
            else {
                tabControl1.Enabled = true;
            }
            txt_id.Text = fid;
            txt_id.Enabled = false;
            dt_foodtype = main.db.getDb("foodtype");
            DataTable dt_food = main.db.getDb("food where foodid = '" + fid + "'");
            showdata(dt_food);
            /*if (date.ToShortDateString().Equals(DateTime.Today.ToShortDateString()))
            {
                dt_foodtype = main.db.getDb("foodtype");
                DataTable dt_food = main.db.getDb("food where foodid = '" + fid + "'");
                showdata(dt_food);
            }
            else {
                String dd = date.Day.ToString();
                String mm = date.Month.ToString();
                String yyyy = date.Year.ToString();
                String fileName = "";
                String[] temp = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i].Equals(date.DayOfWeek.ToString()))
                    {
                        fileName = i + 1 + temp[i];
                    }
                }
                fileName += "\\" + dd + "_" + mm + "_" + yyyy + ".xlsx";

                DataTable a = readXlsx(fileName,"food");
                DataTable b = a.Clone();
                for (int i = 0; i < a.Rows.Count; i++) {
                    if (a.Rows[i]["foodid"].ToString().Equals(fid)) {
                        b.ImportRow(a.Rows[i]);
                    }
                }
                showdata(b);         
            }*/
           


        }

        private void showdata(DataTable dt_food) {
            txt_Name.Text = dt_food.Rows[0]["name"].ToString();
            txt_shortName.Text = dt_food.Rows[0]["shortName"].ToString();
            num_price.Value = Convert.ToDecimal(dt_food.Rows[0]["price"].ToString());
            num_SPrice.Value = Convert.ToDecimal(dt_food.Rows[0]["sprice"].ToString());
            num_DQTY.Value = Convert.ToDecimal(dt_food.Rows[0]["dqty"].ToString());
            num_QTY.Value = Convert.ToDecimal(dt_food.Rows[0]["qty"].ToString());
            combo_ISShow.SelectedItem = dt_food.Rows[0]["isShow"].ToString();
            String ftpyeid = dt_food.Rows[0]["ftypeid"].ToString();
            for (int i = 0; i < dt_foodtype.Rows.Count; i++)
            {
                if (ftpyeid.Equals(dt_foodtype.Rows[i]["ftypeid"]))
                {
                    combo_FoodType.SelectedItem = dt_foodtype.Rows[i]["name"].ToString();
                }
            }
            try
            {

                pictureBox1.ImageLocation = "http://" + main.db.id + "/fyp_php/" + dt_food.Rows[0]["img"].ToString();
            }
            catch (System.IO.FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("Change"))
            {
                button1.Text = "Save";
                flowLayoutPanel1.Visible = true;
                flowLayoutPanel1.BackgroundImage = null;
                pictureBox1.Visible = false;
                m_v2.Hide();
                main.Hide();
               
                
            }
            else
            {
                if (flowLayoutPanel1.BackgroundImage == null)
                {
                    MessageBox.Show("Please input a picture");
                    return;
                }
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("Content-Type", "application/octet-stream");
                    String s = "http://"+main.db.id+"/fyp_php/uploadImgGet.php?action=image&which=" + fid;
                    client.UploadFile(new Uri(s), "POST", @photoPath);
                    MessageBox.Show("Updated"); 
                   
                }
                button1.Text = "Change";
                main.Show();
                m_v2.Show();
            }
        } 

        private void pic_Img_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pic_Img_DragDrop(object sender, DragEventArgs e)
        {
            String[] s = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            flowLayoutPanel1.BackgroundImage = Image.FromFile(s[0]);
            photoPath = s[0];
       
             
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String FName = txt_Name.Text;
            String FsName = txt_shortName.Text;
            String imgName = "image/"+txt_id.Text+".jpg";
            Double price = Convert.ToDouble(num_price.Value);
            Double SPrice = Convert.ToDouble(num_SPrice.Value);
            int qty = Convert.ToInt32(num_QTY.Value);
            int dqty = Convert.ToInt32(num_DQTY.Value);
            String Ftype = combo_FoodType.SelectedItem.ToString();
            DataTable chkbox = main.db.query("SELECT ftypeid from foodtype where name = '"+Ftype +"'");
            Ftype = chkbox.Rows[0][0].ToString();
            String FID = txt_id.Text;
            String s = "";
            String isShow = combo_ISShow.SelectedItem.ToString();
            if (foodAddChick)
            {
                s = "INSERT INTO `food` (`foodId`, `name`,`shortname`,`img`, `price`, `sPrice`, `qty`, `dQty`, `fTypeId`) VALUES('" + FID + "', '" + FName + "','" + FsName + "','" + imgName + "'," + price + "," + SPrice + "," + qty + "," + dqty + ", '" + Ftype + "')";
            }
            else
            {
                
                s = "UPDATE `food` SET `name`='" + FName + "',`shortname`='" + FsName + "',`img`='" + imgName + "',`price`=" + price + ",`sPrice`=" + SPrice + ",`qty`=" + qty + ",`dQty`=" + dqty + ",`fTypeId`='" + Ftype + "',`isShow`='" + isShow + " 'WHERE foodid='" + FID + "';";
            }

            main.db.queny(s);
            MessageBox.Show(s.Split(' ')[0] +"is successful");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            lab_History.Text = "History of" + txt_id.Text + " - " + txt_Name.Text;

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addFood_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
            m_v2.Show();
        }
        /*-------------------------------------------------------------------------------------*/

        

    }
}

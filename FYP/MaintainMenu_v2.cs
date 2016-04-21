using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Login
{
    public partial class MaintainMenu_v2 : Form
    {
        protected Main main;
        private CheckBox[] chkboxs;
        private List<GroupBox> listgrpbox = new List<GroupBox>();
        private String fileName;
        System.Data.OleDb.OleDbConnection MyConnection;
        System.Data.DataSet DtSet;
        System.Data.OleDb.OleDbDataAdapter MyCommand;

        public MaintainMenu_v2(Main main)
        {
            InitializeComponent();
            this.main = main;
            YesterdayOrder();
            
            CheckBox[] temp = { chk_Mon, chk_Tue, chk_Wed, chk_Thu, chk_Fri, chk_Sat, chk_Sun };
            string menuday = "1Monday";
            temp[0].Tag = menuday; 
            menuday = "2Tuesday";
            temp[1].Tag = menuday; 
            menuday = "3Wednesday";
            temp[2].Tag = menuday; 
            menuday = "4Thursday";
            temp[3].Tag = menuday; 
            menuday = "5Friday";
            temp[4].Tag = menuday; 
            menuday = "6Saturday";
            temp[5].Tag = menuday; 
            menuday = "7Sunday";
            temp[6].Tag = menuday; 
            chkboxs = temp;
            
            
            
        }

        private void YesterdayOrder() {
            DateTime date = DateTime.Today;
            date = date.AddDays(-1);
            String s = "Update orders set status='NoOneTake' where status='processing' and orderDate ='" + date.Year+"-"+date.Month+"-"+date.Day+"'";
            main.db.queny(s);
           

        }

        private void MaintainMenu_v2_Load(object sender, EventArgs e)
        {
           /*DataTable dt = main.db.getDb("foodType");
            int x = 10;
            for(int i=0;i<dt.Rows.Count;i++){
                Label lab = new Label();
                String hidden = dt.Rows[i]["ftypeid"].ToString();
                lab.Text = dt.Rows[i]["name"].ToString();
                lab.Tag = hidden;
                lab.Location = new Point(10,x);
                lab.Font = new Font("Comic Sans MS",12);
                lab.MouseDown += new MouseEventHandler(labMouseDown);
                lab.MouseUp += new MouseEventHandler(labMouseMove);
                x += 50;
                grp_AddFood.Controls.Add(lab);
                
            }*/
            DateRangeEventArgs e1 = new DateRangeEventArgs(DateTime.Today, DateTime.Today);
            monthCalendar1_DateSelected(sender, e1);
           
            
        }

       

        private DataTable readXlsx(String tableName,String wherecause) {

              try
            {
              
                String appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\menu\\";
                String menu = "["+tableName+"$]"+wherecause;
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
                    if (temp[i].Equals(monthCalendar1.SelectionStart.DayOfWeek.ToString()))
                    {
                        s = i + 1 + temp[i];
                    }
                }
                fileName = s + "\\test.xlsx";
                DataTable a  = readXlsx(tableName,wherecause);
              
                return a;
            }
              

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
           
            lab_menuof.Text = "Menu of: "+monthCalendar1.SelectionStart.Date.ToShortDateString();
            String dd = monthCalendar1.SelectionStart.Day.ToString();
            String mm = monthCalendar1.SelectionStart.Month.ToString();
            String yyyy = monthCalendar1.SelectionStart.Year.ToString();
            fileName = "";
            String[] temp = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < temp.Length; i++)
            {
                chkboxs[i].Checked = false;
                if (temp[i].Equals(monthCalendar1.SelectionStart.DayOfWeek.ToString()))
                {
                    fileName = i + 1 + temp[i];
                    chkboxs[i].Checked = true;
                }
            }
            fileName += "\\" + dd + "_" + mm + "_" + yyyy + ".xlsx";
           
            DataTable dt_menu = readXlsx("menu","where isshow='Y'");
            if (fileName.Contains("test"))
            {
                lab_Type.Text = "Menu Type : Default";
            }
            else {
                lab_Type.Text = "Menu Type : Independent";
            }
            listgrpbox.Clear();
            for (int i = 0; i < dt_menu.Rows.Count; i++)
            {

                Label lab = new Label();
                Label hidden = new Label();
                GroupBox grp = new GroupBox();
                grp.Name = "grp";
                hidden.Visible = false;
                hidden.Text = dt_menu.Rows[i]["menuid"].ToString();
                if (dt_menu.Rows[i]["isshow"].ToString().Equals("N"))
                {
                    lab.BackColor = Color.Gray;
                }
                else
                {
                    lab.BackColor = Color.Transparent;
                }
                lab.Text = dt_menu.Rows[i]["name"].ToString();
                lab.AutoSize = true;
                lab.Font = new Font("Comic Sans MS", 15);
                grp.Size = new Size(1200, 150);
                grp.Click += new EventHandler(this.groupBox_Clcik);
                grp.DoubleClick += new EventHandler(this.groupBox_DoubleClcik);

                grp.Tag = hidden;
                grp.Controls.Add(lab);
                DataTable dt_menufood = readXlsx("menufood","where menuid='" + dt_menu.Rows[i]["menuid"] + "'");
                int y = 10;
                for (int t = 0; t < dt_menufood.Rows.Count; t++)
                {
                    DataTable dt_food = main.db.getDb( "food where ftypeid = '" + dt_menufood.Rows[t]["ftypeid"] + "'");
                    for (int k = 0; k < dt_food.Rows.Count; k++)
                    {

                        PictureBox pictureBox1 = new PictureBox();
                        try
                        {
                            pictureBox1.ImageLocation = "http://"+main.db.id.Split(' ')[1]+"/fyp_php/" + dt_food.Rows[k]["img"].ToString();
                        }
                        catch (System.IO.FileNotFoundException)
                        {

                        }
                        pictureBox1.Size = new Size(100, 100);
                        pictureBox1.Location = new Point(y, 30);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Click += new EventHandler(picBox_Click);
                        String s = dt_food.Rows[k]["foodid"].ToString();
                        pictureBox1.Tag = s;
                        y += 150;
                        grp.Controls.Add(pictureBox1);

                    }
                }
                listgrpbox.Add(grp);
            }
                flowLayoutPanel1.Controls.Clear();
                foreach (GroupBox a in listgrpbox)
                {

                    flowLayoutPanel1.Controls.Add(a);
                }
            
        }

        private void picBox_Click(object sender,EventArgs e) {
            String date = monthCalendar1.SelectionStart.Date.ToShortDateString();
            addFood food = new addFood(((PictureBox)sender).Tag.ToString(),main,monthCalendar1.SelectionStart,this);
            food.ShowDialog();
        }

        private void btn_foodlist_Click(object sender, EventArgs e)
        {
            MaintainMenu menu = new MaintainMenu(main);
            menu.ShowDialog();

        }

        private void btn_genXML_Click(object sender, EventArgs e)
        {
            String appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (DialogResult.Yes == MessageBox.Show("Do you want to add a menu of " + monthCalendar1.SelectionStart.Date.ToShortDateString() + "?", "title", MessageBoxButtons.YesNo))
            {
                String dd = monthCalendar1.SelectionStart.Day.ToString();
                String mm = monthCalendar1.SelectionStart.Month.ToString();
                String yyyy = monthCalendar1.SelectionStart.Year.ToString();

                String filetest = dd + "_" + mm + "_" + yyyy + ".xlsx";
                GenXlsx createXlsx = new GenXlsx(filetest,main,monthCalendar1.SelectionStart.DayOfWeek.ToString(),this);
                createXlsx.ShowDialog();
                /*Excel.Application app;
                Excel.Worksheet wsh;
                Excel.Workbook book;

                app = new Excel.Application();
                book = app.Workbooks.Add();
                wsh = (Excel.Worksheet)book.Worksheets.get_Item(1);
                wsh.Name = "Food";
                DataTable dt_food = main.db.getDb("food");
                genXMLData(dt_food, wsh);
                wsh = (Excel.Worksheet)book.Worksheets.Add();
                wsh.Name = "Menu";
                DataTable dt_menu = main.db.getDb("menu");
                genXMLData(dt_menu, wsh);
                wsh = (Excel.Worksheet)book.Worksheets.Add();
                wsh.Name = "MenuFood";
                DataTable dt_menufood = main.db.getDb("menufood");
                genXMLData(dt_menufood, wsh);
                wsh = (Excel.Worksheet)book.Worksheets.Add();
                wsh.Name = "foodtype";
                DataTable dt_foodtype = main.db.getDb("foodtype");
                genXMLData(dt_foodtype, wsh);

                for (int i = 1; i < book.Worksheets.Count + 1; i++)
                {
                    Excel.Worksheet wsh1;
                    wsh1 = (Excel.Worksheet)book.Worksheets.get_Item(i);
                    wsh1.Columns.AutoFit();
                    Marshal.FinalReleaseComObject(wsh1);

                }

                foreach (CheckBox a in chkboxs)
                {
                    if (a.Checked)
                    {
                        book.SaveAs(appPath + "\\menu\\" + a.Tag.ToString() + "\\" + filetest);

                    }
                }

                if (wsh != null)
                {
                    Marshal.FinalReleaseComObject(wsh);
                }
                if (book != null)
                {
                    book.Close(false); //忽略尚未存檔內容，避免跳出提示卡住
                    Marshal.FinalReleaseComObject(book);
                }
                if (app != null)
                {
                    app.Workbooks.Close();
                    app.Quit();
                    Marshal.FinalReleaseComObject(app);
                }*/
            }
            else {
                MessageBox.Show("Please select a date of menu.");
            }

            /*Excel.Range chartRange;
            object misValue = System.Reflection.Missing.Value;
            Excel.ChartObjects xlCharts = (Excel.ChartObjects)wsh.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            chartRange = wsh.get_Range("d1", "f7");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered; */
        }

       
        

        private void groupBox_DoubleClcik(object sender, EventArgs e)
        {
            foreach (GroupBox a in listgrpbox)
            {
                a.BackColor = Color.FloralWhite;
            }
            ((GroupBox)sender).BackColor = Color.PapayaWhip;
            foreach (GroupBox a in listgrpbox)
            {
                if (a.BackColor == Color.PapayaWhip)
                {
                    DataTable dt_menu = main.db.getDb("menu where menuid='" + ((Label)(a.Tag)).Text + "'");
                    addMenuType addMenu = new addMenuType(dt_menu,main,this);
                    addMenu.ShowDialog();
                }
            }
        }

        private void groupBox_Clcik(object sender, EventArgs e) {
            foreach (GroupBox a in listgrpbox) {
                a.BackColor = Color.FloralWhite;
            }
            ((GroupBox)sender).BackColor = Color.PapayaWhip;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeMenu cMenu = new ChangeMenu(main);
            cMenu.ShowDialog();
        }
      
    }
    
}

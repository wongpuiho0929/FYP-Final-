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
    public partial class GenXlsx : Form
    {

        private String fileName;
        private Main main;
        private String dayOfweek;
        private List<FlowLayoutPanel> panels= new List<FlowLayoutPanel>();
        private MaintainMenu_v2 m_v2;
        private int numofrow = 0;

        public GenXlsx(String fileName, Main main, String dayOfweek, MaintainMenu_v2 m_v2)
        {
            InitializeComponent();
            this.fileName = fileName;
            this.main = main;
            this.dayOfweek = dayOfweek;
            this.m_v2 = m_v2;
            tableLayoutPanel1.AutoScroll = true;
            label1.Text = "This menu will be named :"+fileName;
            label1.Font = new Font("Comic Sans MS", 12);
            DataTable dt = main.db.getDb("foodType");
            int x = 50;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Label lab = new Label();
                String hidden = dt.Rows[i]["ftypeid"].ToString();
                lab.Text = dt.Rows[i]["name"].ToString();
                lab.Tag = hidden;
                lab.Location = new Point(500, x);
                lab.Font = new Font("Comic Sans MS", 12);
                lab.MouseDown += new MouseEventHandler(labMouseDown);
                x += 30;
                tabControl1.TabPages[0].Controls.Add(lab);
            }

        }

        private void labMouseDown(object sender, MouseEventArgs e)
        {
            ((Label)sender).DoDragDrop(((Label)sender).Text, DragDropEffects.Copy);
        }


        private DataTable readXlsx(String path,String tableName,String wherecause)
        {
            System.Data.OleDb.OleDbConnection MyConnection;
            System.Data.DataSet DtSet;
            System.Data.OleDb.OleDbDataAdapter MyCommand;
            String appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\menu\\"+path+"\\test.xlsx";
            String menu = "["+tableName+"$]"+wherecause;
            MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;Data Source='" + appPath  + "';Extended Properties=Excel 12.0;");
            MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from " + menu, MyConnection);
            MyCommand.TableMappings.Add("Table", "TestTable");
            DtSet = new System.Data.DataSet();
            MyCommand.Fill(DtSet);
            MyConnection.Close();
            return DtSet.Tables[0];
        }

        private void GenXlsx_Load(object sender, EventArgs e)
        {
            panels.Clear();
            if (DialogResult.Yes == MessageBox.Show("Base on the default menu?", "Create Menu", MessageBoxButtons.YesNo))
            {

                String s = SaveFilePath();
                DataTable dt_menu = readXlsx(s,"Menu","where isshow='Y'");
                int x = 50;
                for (int i = 0; i < dt_menu.Rows.Count; i++) {
                    FlowLayoutPanel panel = new FlowLayoutPanel();
                    panel.AllowDrop = true;
                    panel.AutoScroll = true;
                    panel.Location = new Point(30, x);
                    x += 150;
                    Label lab = new Label();
                    lab.Text = dt_menu.Rows[i]["name"].ToString();
                    lab.Tag = dt_menu.Rows[i]["menuid"].ToString();
                    lab.Font = new Font("Comic san MS",12);
                    lab.Dock = DockStyle.Top;
                    lab.AutoSize = true;
                    panel.Controls.Add(lab);
                    panel.Size = new Size(280, 100);
                    panel.FlowDirection = FlowDirection.TopDown;
                    panel.BackColor = Color.Azure;
                    panel.DragEnter += new DragEventHandler(grp_DragEnter);
                    panel.DragDrop += new DragEventHandler(grp_DragDrop);
                    tabControl1.TabPages[0].Controls.Add(panel);
                    DataTable dt_menufood = readXlsx(s, "MenuFood","where menuid='"+dt_menu.Rows[i]["menuid"].ToString()+"'");
                    for (int k = 0; k < dt_menufood.Rows.Count; k++)
                    {
                        Label lab1 = new Label();
                        DataTable dt_foodType = main.db.getDb("foodType where ftypeid='"+dt_menufood.Rows[k]["ftypeid"].ToString()+"'");
                        lab1.Text = dt_foodType.Rows[0]["name"].ToString();
                        lab1.Tag = dt_foodType.Rows[0]["ftypeid"].ToString();
                        lab1.Font = new Font("Comic Sans MS", 15);
                        lab1.Click += new EventHandler(lab_Click);
                        panel.Controls.Add(lab1);
                        
                    }
                    panels.Add(panel);
                }
              
                
            }
            else {
                /*-------------------------tabpage3---------------------------------------*/
                tabControl1.SelectedIndex = 2;
                DataTable dt_menu = main.db.getDb("Menu");
                for (int i = 0; i < dt_menu.Rows.Count; i++)
                {
                    chkList_Menu.Items.Add(dt_menu.Rows[i]["name"].ToString());
                    
                }
            }
        }

        private void lab_Click(object sender, EventArgs e) {
            ((Label)sender).Dispose();
            MessageBox.Show("1");
        }

        private void grp_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;    
        }

        private void grp_DragDrop(object sender, DragEventArgs e) {
            Label lab = new Label();
            lab.Text = (string)e.Data.GetData(DataFormats.Text);
            DataTable dt = main.db.getDb("foodtype where name ='"+lab.Text+"'");
            lab.Tag = dt.Rows[0]["ftypeid"].ToString();
            lab.Font = new Font("Comic Sans MS", 15);
            lab.Click += new EventHandler(lab_Click);
            ((Panel)sender).Controls.Add(lab);
        }
   

    private void btn_addMenutype_Click(object sender, EventArgs e)
        {
            addMenuType addMenu = new addMenuType(main,m_v2);
            addMenu.ShowDialog();
        }

    private void button1_Click(object sender, EventArgs e)
    {
        passData(panels);
        tabControl1.SelectedTab = tabControl1.TabPages[1];
        
    }

     /*------------------------------tabpage2--------------------------------------------------*/

    private void passData(List<FlowLayoutPanel> panels)
    {
        this.tableLayoutPanel1.CellPaint += new TableLayoutCellPaintEventHandler(tableLayoutPanel1_CellPaint);
        numofrow = 0;
        for (int i = 0; i < panels.Count; i++)
        {
            String menuName = "";
            String menuid = "";
            String foodType = "";
            String foodTypeid = "";
            int index = -1;
            foreach (Control a in panels[i].Controls )
            {
                index++;
                if (index ==0)
                {
                    menuName = ((Label)a).Text;
                    menuid = ((Label)a).Tag.ToString();
                   
                }
                else
                {
                    foodType += ((Label)a).Text + "\n";
                    foodTypeid += ((Label)a).Tag.ToString()+" ";
                }
            }
            Label lab = new Label();
            lab.Font = new Font("Comic sans MS", 19);
            lab.Tag = menuid;
            lab.AutoSize = true;
            Label lab2 = new Label();
            lab2.Font = new Font("Comic sans MS", 15);
            lab2.AutoSize = true;
            lab2.Tag = foodTypeid;
            lab.Text = menuName;
            tableLayoutPanel1.Controls.Add(lab, 0, i);
            lab2.Text = foodType;
            tableLayoutPanel1.Controls.Add(lab2, 1, i);
            numofrow++;
        }
       

    }
    public void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
    {
        if (e.Row%2==0)
        {
            Graphics g = e.Graphics;
            Rectangle r = e.CellBounds;
            g.FillRectangle(Brushes.Azure, r);
        }
    }
    private void button2_Click(object sender, EventArgs e)
    {
        Excel.Application app;
        Excel.Worksheet wsh;
        Excel.Workbook book;

        app = new Excel.Application();
        book = app.Workbooks.Add();

        wsh = (Excel.Worksheet)book.Worksheets.get_Item(1);
        wsh.Name = "Menu";
        DataTable dt_menu = main.db.getDb("menu");
        DataTable dt_menufood = main.db.getDb("menufood");
        DataColumn[] key = { dt_menu.Columns["menuid"]};
        dt_menu.PrimaryKey = key;
        foreach (DataRow a in dt_menu.Rows) { 
            a.SetField("isShow","N");
        }
        for (int i = 0; i < numofrow; i++) { 
            Label lab = (Label)tableLayoutPanel1.GetControlFromPosition(0,i);
            dt_menu.Rows.Find(lab.Tag).SetField("isShow","Y");
            for (int k = 0; k < dt_menufood.Rows.Count; k++) {
                MessageBox.Show(dt_menufood.Rows[k]["menuid"].ToString()+lab.Tag.ToString());
                if (dt_menufood.Rows[k]["menuid"].ToString().Equals(lab.Tag.ToString()))
                    {
                        dt_menufood.Rows[k].Delete();
                        dt_menufood.AcceptChanges();
                        k--;
                    }
               
            }
            Label lab2 = (Label)tableLayoutPanel1.GetControlFromPosition(1,i);
            String[] split = { " "};
            String[] temp = lab2.Tag.ToString().Split(split,StringSplitOptions.RemoveEmptyEntries);
            foreach (String a in temp) {
                DataRow row = dt_menufood.NewRow();
                row["menuid"] = lab.Tag;
                row["ftypeid"] = a;
                row["many"] = 1;
                dt_menufood.Rows.Add(row);
            }

       
           
            
        }
       genXMLData(dt_menu, wsh);

       wsh = (Excel.Worksheet)book.Worksheets.Add();
       wsh.Name = "MenuFood";
      


       genXMLData(dt_menufood, wsh);

        String s = SaveFilePath();
        String appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        for (int i = 1; i < book.Worksheets.Count + 1; i++)
        {
            Excel.Worksheet wsh1;
            wsh1 = (Excel.Worksheet)book.Worksheets.get_Item(i);
            wsh1.Columns.AutoFit();
            Marshal.FinalReleaseComObject(wsh1);

        }
        book.SaveAs(appPath + "\\menu\\" + s + "\\" + fileName);
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
        }
    }
    private void genXMLData(DataTable dt, Excel.Worksheet wsh)
    {

        for (int col = 0; col < dt.Columns.Count; col++)
        {
            wsh.Cells[1, col + 1] = dt.Columns[col].ToString();
            wsh.Cells[1, col + 1].Font.Bold = true;
        }
        wsh.Cells.AutoFilter(1,
                Type.Missing,
                Excel.XlAutoFilterOperator.xlAnd,
                Type.Missing,
                true);

        for (int rows = 0; rows < dt.Rows.Count; rows++)
        {
            for (int col = 0; col < dt.Rows[rows].ItemArray.Length; col++)
            {
                wsh.Cells[rows + 2, col + 1].NumberFormat = "@";
                wsh.Cells[rows + 2, col + 1] = dt.Rows[rows][col].ToString();

            }
        }
    }
    /*------------------------tabpage3--------------------------------------*/

    private void btn_Next_Click(object sender, EventArgs e)
    {
        
        String s = "";
        for (int i = 0; i < chkList_Menu.CheckedItems.Count;i++ )
        {
            String a = chkList_Menu.CheckedItems[i].ToString();
            if (i == chkList_Menu.CheckedItems.Count - 1)
            {
                s += "'" + a + "'";
            }
            else
            {
                s += "'" + a + "',";
            }
        }
        DataTable dt_menu = main.db.getDb("menu where name in ("+s+")");
        int x = 50;
        for (int i = 0; i < dt_menu.Rows.Count; i++)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.AllowDrop = true;
            panel.AutoScroll = true;
            panel.Location = new Point(30, x);
            x += 150;
            Label lab = new Label();
            lab.Text = dt_menu.Rows[i]["name"].ToString();
            lab.Tag = dt_menu.Rows[i]["menuid"].ToString();
            lab.Font = new Font("Comic san MS", 12);
            lab.Dock = DockStyle.Top;
            lab.AutoSize = true;
            panel.Controls.Add(lab);
            panel.Size = new Size(280, 100);
            panel.FlowDirection = FlowDirection.TopDown;
            panel.BackColor = Color.Azure;
            panel.DragEnter += new DragEventHandler(grp_DragEnter);
            panel.DragDrop += new DragEventHandler(grp_DragDrop);
            tabControl1.TabPages[0].Controls.Add(panel);
            DataTable dt_menufood = main.db.getDb("MenuFood where menuid='"+ dt_menu.Rows[i]["menuid"].ToString() + "'");
            for (int k = 0; k < dt_menufood.Rows.Count; k++)
            {
                Label lab1 = new Label();
                DataTable dt_foodType = main.db.getDb("foodType where ftypeid='"+dt_menufood.Rows[k]["ftypeid"].ToString() + "'");
                lab1.Text = dt_foodType.Rows[0]["name"].ToString();
                lab1.Tag = dt_foodType.Rows[0]["ftypeid"].ToString();
                panel.Controls.Add(lab1);

            }
            panels.Add(panel);
        }
        tabControl1.SelectedIndex = 0;
    }
    
  
    private String SaveFilePath() {
        String[] temp = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        String s = "";
        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i].Equals(dayOfweek))
            {
                s = i + 1 + temp[i];
            }
        }
        return s;
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    }
}

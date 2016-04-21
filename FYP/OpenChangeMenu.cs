using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Login
{
    public partial class OpenChangeMenu : Form
    {
        private String sendFileName;
        protected Main main;
        

        public OpenChangeMenu(String sendFileName,Main main)
        {
            InitializeComponent();
            this.sendFileName = sendFileName;
            this.main = main;
        }

        private void OpenChangeMenu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = insertDataSet("[Menu$]");
            dataGridView2.DataSource = insertDataSet("[Food$]");
            dataGridView3.DataSource = insertDataSet("[MenuFood$]");
            dataGridView4.DataSource = insertDataSet("[FoodType$]");
            MessageBox.Show("Menu: \n\t"+checkdiff(dataGridView1, "Menu")+"Row(s) has been changed"+"\n"
                + "Food: \n\t"+checkdiff(dataGridView2, "Food") + "Row(s) has been changed\n"
                + "MenuFood: \n\t"+checkdiff(dataGridView3, "MenuFood") + "Row(s) has been changed\n"
                + "FoodType: \n\t" + checkdiff(dataGridView4, "FoodType") + "Row(s) has been changed");
        }

        private DataTable insertDataSet(String tableName) {

            System.Data.OleDb.OleDbConnection MyConnection;
            System.Data.DataSet DtSet;
            System.Data.OleDb.OleDbDataAdapter MyCommand;
            String appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\menu\\";
            MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;Data Source='" + appPath + sendFileName + "';Extended Properties=Excel 12.0;");

            MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from "+tableName, MyConnection);
            MyCommand.TableMappings.Add("Table", "TestTable");
            DtSet = new System.Data.DataSet();
            MyCommand.Fill(DtSet);
            MyConnection.Close();
            return DtSet.Tables[0];
        }

        private int checkdiff(DataGridView dgv,String dataTableName) {
            int i = 0;
            DataTable dt_currentTable= main.db.getDb(dataTableName);
            DataTable willChangeTable = (DataTable)dgv.DataSource;
            for (int k = 0; k < willChangeTable.Rows.Count; k++) { 
                for(int t=0;t<dt_currentTable.Columns.Count;t++){
                        if (!dt_currentTable.Rows[k][t].ToString().Equals(willChangeTable.Rows[k][t].ToString()))
                        {
                            dgv.Rows[k].DefaultCellStyle.ForeColor = Color.Red;
                            i++;
                            break;
                        }
                        if (willChangeTable.Rows.Count != dt_currentTable.Rows.Count)
                        {
                            int temp=dt_currentTable.Rows.Count-willChangeTable.Rows.Count;
                            for (int p = willChangeTable.Rows.Count; p < willChangeTable.Rows.Count + temp;p++ )
                            {
                                DataTable dt = willChangeTable;
                                DataRow row = dt_currentTable.Rows[p];
                                dt.ImportRow(row);
                                dgv.DataSource = dt;
                                dgv.Rows[p].DefaultCellStyle.ForeColor = Color.Green;
                                i++;
                                break;
                            }
                        }
                    

                }
            }
                return i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                if (dataGridView1.Rows[i].DefaultCellStyle.ForeColor == Color.Red)
                {
                    DataGridViewCellCollection row = dataGridView1.Rows[i].Cells;
                    String s = "UPDATE `menu` SET `name`='" + row["name"].Value.ToString() + "',`shortName`='" + row["shortName"].Value.ToString() + "',`price`=" + row["price"].Value.ToString() + ",`mCateId`='" + row["mCateId"].Value.ToString() + "',`isShow`='" + row["isshow"].Value.ToString() + "' WHERE menuID='" + row["menuid"].Value.ToString() + "';";
                    main.db.queny(s);
                }
            }
        }
    }
}

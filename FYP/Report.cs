using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;


namespace Login
{
    public partial class Report : Form
    {

        private Main main;
        private System.Data.DataTable table = new System.Data.DataTable();

        public Report( Main main)
        {
            InitializeComponent();
            this.main = main;
            
        }

        private void Report_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ExportToExcel();  
        }

        public System.Data.DataTable ExportToExcel()
        {
            
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Sex", typeof(string));
            table.Columns.Add("Subject1", typeof(int));
            table.Columns.Add("Subject2", typeof(int));
            table.Columns.Add("Subject3", typeof(int));
            table.Columns.Add("Subject4", typeof(int));
            table.Columns.Add("Subject5", typeof(int));
            table.Columns.Add("Subject6", typeof(int));
            table.Rows.Add(1, "Amar", "M", 78, 59, 72, 95, 83, 77);
            table.Rows.Add(2, "Mohit", "M", 76, 65, 85, 87, 72, 90);
            table.Rows.Add(3, "Garima", "F", 77, 73, 83, 64, 86, 63);
            table.Rows.Add(4, "jyoti", "F", 55, 77, 85, 69, 70, 86);
            table.Rows.Add(5, "Avinash", "M", 87, 73, 69, 75, 67, 81);
            table.Rows.Add(6, "Devesh", "M", 92, 87, 78, 73, 75, 72);
            return table;
            
        }  

        private void button1_Click(object sender, EventArgs e)
        {
            String filetest = "test.xlsx";
            Excel.Application app;
            Excel.Worksheet wsh;
            Excel.Workbook book;

            app = new Excel.Application();
            book = app.Workbooks.Add();
            wsh = (Excel.Worksheet)book.Worksheets.get_Item(1);
            for (int col = 0; col < table.Columns.Count; col++)
            {
                wsh.Cells[1, col+1] = table.Columns[col].ToString();
                wsh.Cells[1,col+1].Font.Bold = true;
            }
            wsh.Cells.AutoFilter(1,
                    Type.Missing,
                    Excel.XlAutoFilterOperator.xlAnd,
                    Type.Missing,
                    true);
            for (int rows = 0; rows < table.Rows.Count; rows++) {
                for (int col = 0;col < table.Rows[rows].ItemArray.Length; col++)
                {
                    wsh.Cells[rows + 2, col + 1] = table.Rows[rows][col].ToString();
                }
            }
            Excel.Range chartRange;
            object misValue = System.Reflection.Missing.Value;
            Excel.ChartObjects xlCharts = (Excel.ChartObjects)wsh.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            chartRange = wsh.get_Range("d1", "f7");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered; 

            book.SaveAs(filetest);
            book.Close();
            app.Quit();
        }

        
    }
}

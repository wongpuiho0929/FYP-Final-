using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class OldDataToDB : Form
    {
        private Main main;

        public OldDataToDB(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void OldDataToDB_Load(object sender, EventArgs e)
        {
            DataTable a = main.db.getDb("student where status = 'freeze'");
            dataGridView1.DataSource = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*MySqlCommand acmd = new MySqlCommand("DROP TABLE IF EXISTS `student2`;CREATE TABLE `student2`(" +
	        "`stuId` varchar(10) NOT NULL,"+
	        "`password` varchar(30) NOT NULL,"+
	        "`name` varchar(30) NOT NULL,"+
	        "`balance` numeric(5,1) NOT NULL DEFAULT 0,"+
	        "`email` varchar(30) NOT NULL,"+
	        "`status` varchar(10) NOT NULL DEFAULT 'processing',"+
	        "`freezeDay` date NOT NULL,"+
	        "PRIMARY KEY (`stuId`)"+
            ") CHARACTER SET = utf8;",
            main.db.cnn);
            main.db.cnn.Open();
            acmd.ExecuteNonQuery();
            main.db.cnn.Close();*/
            DataTable a = main.db.getDb("student where status = 'freeze'");
            DataTable newDB = main.db.getDb("student2");
            
            for (int i = 0; i < a.Rows.Count; i++)
            {
                newDB.ImportRow(a.Rows[i]);
            }
            
            
        }

    }
}

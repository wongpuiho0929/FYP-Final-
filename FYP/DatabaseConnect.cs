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
    public partial class DatabaseConnect : Form
    {
        Login login;

        public DatabaseConnect(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.changeConnection(textBox1.Text,textBox2.Text,textBox3.Text);
            db.Connection();
            try
            {
                db.getDb("staff");
                login.database = db;
                MessageBox.Show("Connected");
                login.btn_login.Enabled = true;
                this.Close();
            }
            catch (Exception ) {
                MessageBox.Show("try again.");
            }
            
            
        }
    }
}

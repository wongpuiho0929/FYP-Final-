using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;


namespace Login
{
    public partial class Login : Form
    {
        public String userName;
        private Main main;
        public Database database;
        

        public Login()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(2500);
            InitializeComponent();
            t.Abort();
            database = new Database();
            database.Connection();
            
        }
        public void SplashScreen() {
            Application.Run(new SplashScreen());
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Boolean login = false;
            DataTable db_account = database.getDb("staff");
            for (int i = 0; i < db_account.Rows.Count;i++ ){
                if (txt_userName.Text.Equals(db_account.Rows[i]["userName"].ToString()) && txt_password.Text.Equals(db_account.Rows[i]["password"].ToString()))
                {
                    userName = db_account.Rows[i]["userName"].ToString();
                    main = new Main(this);
                    this.Hide();
                    main.Show();
                    login = true;
                    
                }
            }
            if(!login)
                MessageBox.Show("Login fail.Please Check your username and password");
          
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            try
            {
               database.getDb("staff");
            }
            catch (Exception )
            {
                MessageBox.Show("Cannot connect to server.");
                btn_login.Enabled = false;
                DatabaseConnect dbc = new DatabaseConnect(this);
                dbc.Show();

            }
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btn_login_Click(sender, e);
            }
        }
    }
}

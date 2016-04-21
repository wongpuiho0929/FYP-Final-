using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Login
{
    public partial class ChangeMenu : Form
    {
        private String sendFolderName;
        private Main main;
        public ChangeMenu(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void r_Mon_CheckedChanged(object sender, EventArgs e)
        {
            lab_menuin.Text = "Menu in Monday folder";
            findMenu("1Monday");
        }

        private void r_Tue_CheckedChanged(object sender, EventArgs e)
        {
            lab_menuin.Text = "Menu in Tuesday folder";
            findMenu("2Tuesday");
        }

        private void e_wed_CheckedChanged(object sender, EventArgs e)
        {
            lab_menuin.Text = "Menu in Wednesday folder";
            findMenu("3Wednesday");
        }

        private void r_Thu_CheckedChanged(object sender, EventArgs e)
        {
            lab_menuin.Text = "Menu in Thursday folder";
            findMenu("4Thursday");
        }

        private void r_fri_CheckedChanged(object sender, EventArgs e)
        {
            lab_menuin.Text = "Menu in Friday folder";
            findMenu("5Friday");
        }

        private void r_sat_CheckedChanged(object sender, EventArgs e)
        {
            lab_menuin.Text = "Menu in Saturday folder";
            findMenu("6Saturday");
        }

        private void r_Sun_CheckedChanged(object sender, EventArgs e)
        {
            lab_menuin.Text = "Menu in Sunday folder";
            findMenu("7Sunday");
        }

        private void findMenu(String folderName) {
            listBox1.Items.Clear();
            listBox1.Font = new Font("Comic Sans MS ", 19);
            listBox1.Enabled = true;
            String appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            String[] dirs = Directory.GetFiles(appPath+"\\menu\\"+folderName,"*.xls");
            foreach(String a in dirs){
                listBox1.Items.Add(a.Substring(a.IndexOf(folderName)));
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sendFolderName = listBox1.SelectedItem.ToString();
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = "Menu\\"+sendFolderName;
            String s1 = "Menu\\"+sendFolderName.Substring(0,sendFolderName.IndexOf("\\"))+"\\test.xlsx";
            try
            {
                System.IO.File.Replace(s, s1,"a");
            }
            catch (Exception) {
                
                MessageBox.Show("Please try it again!");
            }
                
              
        }

        private void ChangeMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

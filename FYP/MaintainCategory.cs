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
    public partial class MaintainCategory : Form
    {

        Main main;
        Database db;

        public MaintainCategory(Main main)
        {
            InitializeComponent();
            this.main = main;
            db = main.db;
        }

        private void MaintainCategory_Load(object sender, EventArgs e)
        {
            DataTable dt_MenuCategory = db.getDb("MenuCategory");
            dataGridView1.DataSource = dt_MenuCategory;
       }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                txt_MCID.Text = row.Cells[0].Value.ToString();
                txt_MCName.Text = row.Cells[2].Value.ToString();
                comboBox1.SelectedIndex = comboBox1.Items.IndexOf(row.Cells[3].Value.ToString());
            }
            catch (Exception)
            {
            }
        }

        private void btn_maintain_Click(object sender, EventArgs e)
        {
            btn_Save.Visible = true;
            Enable(true);
        }

        private void Enable(Boolean s) {
            txt_MCName.Enabled = s;
            comboBox1.Enabled = s;
            btn_Cancel.Visible = s;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            String MCID = txt_MCID.Text;
            String MCName = txt_MCName.Text;
            String isShow = comboBox1.SelectedItem.ToString();
            String s = "UPDATE `MenuCategory` SET `name`='" + MCName + "', isShow='" + isShow + "'WHERE mCateId='" + MCID + "';";
            db.queny(s);
            btn_Save.Visible = false;
            Enable(false);
            MaintainCategory_Load(sender,e);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataTable dt_MC = db.getDb("menuCategory order by mCateID ASC");
            String MCID = dt_MC.Rows[dt_MC.Rows.Count - 1]["mCateID"].ToString();
            String str = "" + (Convert.ToInt32(MCID.Substring(2)) + 1);
            String pad = "00000000";
            String ans = pad.Substring(0, pad.Length - str.Length) + str;
            String MCIDnum = "MC" + ans;
            txt_MCID.Text = MCIDnum;
            txt_MCName.Text = "";
            btn_addSave.Visible = true;
            Enable(true);
        }

        private void btn_addSave_Click(object sender, EventArgs e)
        {
            String MCID = txt_MCID.Text;
            String MCName = txt_MCName.Text;
            String isShow = comboBox1.SelectedItem.ToString();
            String s = "INSERT INTO `menucategory`(`mCateId`, `name`, `isShow`) VALUES ('"+MCID+"','"+MCName+"','"+isShow+"')";
            btn_addSave.Visible = false;
            db.queny(s);
            Enable(false);
            MaintainCategory_Load(sender, e);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Enable(false);
            btn_addSave.Visible = false;
            btn_Save.Visible = false;
        }

    }
}

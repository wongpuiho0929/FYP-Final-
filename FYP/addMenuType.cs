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
    public partial class addMenuType : Form
    {
        private DataTable dt;
        private Main main;
        private DataTable dt_menuCategory;
        private String photoPath;
        private MaintainMenu_v2 m_v2;

        public addMenuType(DataTable dt, Main main, MaintainMenu_v2 m_v2)
        {
            InitializeComponent();
            this.dt = dt;
            this.main = main;
            this.m_v2 = m_v2;
            dt_menuCategory = main.db.getDb("menucategory");
        }
        public addMenuType(Main main,MaintainMenu_v2 m_v2)
        {
            InitializeComponent();
            this.main = main;
            this.m_v2 = m_v2;
            dt_menuCategory = main.db.getDb("menucategory");
        }

        private void addChange_Load(object sender, EventArgs e)
        {
            DataTable dt_menuCategory = main.db.getDb("menucategory");
            combo_Category.Items.Clear();
            for (int i = 0; i < dt_menuCategory.Rows.Count; i++) {
                combo_Category.Items.Add(dt_menuCategory.Rows[i]["name"].ToString());
            }
               
            if (dt != null)
            {
                txt_id.Text = dt.Rows[0]["menuid"].ToString();
                txt_id.Enabled = false;
                txt_Name.Text = dt.Rows[0]["name"].ToString();
                txt_shortName.Text = dt.Rows[0]["shortName"].ToString();
                for (int k = 0; k < dt_menuCategory.Rows.Count; k++)
                {
                    if (dt_menuCategory.Rows[k]["mCateid"].Equals(dt.Rows[0]["mCateid"].ToString()))
                    {
                        combo_Category.SelectedIndex = combo_Category.Items.IndexOf(dt_menuCategory.Rows[k]["name"].ToString());
                        break;
                    }
                }
                if (dt.Rows[0]["price"].ToString() == "" || dt.Rows[0]["price"].ToString() == null)
                {
                    num_price.Value = 0;
                    chk_null.Checked = true;
                }
                else
                {
                    num_price.Value = Convert.ToDecimal(dt.Rows[0]["price"].ToString());
                }
                if (dt.Rows[0]["img"].ToString() == "" || dt.Rows[0]["img"].ToString() == null)
                {
                    //nothing to do
                }
                else
                {
                    try
                    {
                        pictureBox1.ImageLocation = "http://" + main.db.id + "/fyp_php/" + dt.Rows[0]["img"].ToString();
                    }
                    catch (System.IO.FileNotFoundException) { 
                    
                    }
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                comboBox1.SelectedItem = dt.Rows[0]["isShow"].ToString();
            }
            else {
                DataTable dt_menu = main.db.getDb("menu order by menuid ASC");
                String MID = dt_menu.Rows[dt_menu.Rows.Count - 1]["menuid"].ToString();
                String str = "" + (Convert.ToInt32(MID.Substring(1)) + 1);
                String pad = "00000000";
                String ans = pad.Substring(0, pad.Length - str.Length) + str;
                String MIDnum = "M" + ans;
                txt_id.Text = MIDnum;
                txt_Name.Text = "";
                txt_shortName.Text = "";
                combo_Category.SelectedIndex = 0;
                comboBox1.SelectedIndex = 0;
                num_price.Value = 0;
                chk_null.Checked = false;

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

        private void chk_null_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_null.Checked)
            {
                num_price.Enabled = false;
            }
            else {
                num_price.Enabled = true;
            }
        }


        private void btn_category_Click(object sender, EventArgs e)
        {
            MaintainCategory MC = new MaintainCategory(main);
            MC.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String id = "";
               for (int i = 0; i < dt_menuCategory.Rows.Count; i++)
            {
                if (dt_menuCategory.Rows[i]["name"].Equals(combo_Category.SelectedItem.ToString()))
                {
                     id = dt_menuCategory.Rows[i]["mCateId"].ToString();
                    break;
                }
            }

            if (dt != null)
            {
                if (!chk_null.Checked)
                {
                    String s = "UPDATE `menu` SET `name`='"+txt_Name.Text+"',`shortName`='"+txt_shortName.Text+"',`price`="+num_price.Value.ToString()+",`mCateId`='"+id+"',`isShow`='"+comboBox1.SelectedItem.ToString() +"' WHERE `menuId`='"+txt_id.Text+"'";
                    main.db.queny(s);


                }
                else
                {
                    String s = "UPDATE `menu` SET `name`='" + txt_Name.Text + "',`shortName`='" + txt_shortName.Text + "',`price`= null," + "`mCateId`='" + id + "',`isShow`='" + comboBox1.SelectedItem.ToString() + "' WHERE `menuId`='" + txt_id.Text + "'";
                    main.db.queny(s);
                }

                if (flowLayoutPanel1.BackgroundImage != null){
                    String s = "update menu set img='image/"+txt_id.Text+".jpg' where menuid='"+txt_id.Text+"'";
                    main.db.queny(s);
                }
            }
            else
            {
                if (!chk_null.Checked)
                {
                    String s = "INSERT INTO `menu`(`menuId`, `name`,`shortname`, `price`, `mCateId`, `isShow`) VALUES ('" + txt_id.Text + "','" + txt_Name.Text + "','" + txt_shortName.Text + "'," + num_price.Value.ToString() + ",'" + id + "','" + comboBox1.SelectedItem.ToString() + "')";
                    main.db.queny(s);


                }
                else
                {
                    String s = "INSERT INTO `menu`(`menuId`, `name`,`shortname`, `price`, `mCateId`, `isShow`) VALUES ('" + txt_id.Text + "','" + txt_Name.Text + "','" + txt_shortName.Text + "',null,'" + id + "','" + comboBox1.SelectedItem.ToString() + "')";
                    main.db.queny(s);
                }
                MaintainMenuFood mf = new MaintainMenuFood(main,txt_id.Text);
                mf.ShowDialog();
                DialogResult YesNo = MessageBox.Show("Add again?", "Add Menu Type", MessageBoxButtons.YesNo);
                if (YesNo == DialogResult.Yes)
                {
                    addChange_Load(sender, e);
                }
                else
                {
                    this.Close();
                }
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
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("Content-Type", "application/octet-stream");
                    String s = "http://"+main.db.id+"/fyp_php/uploadImgGet.php?action=image&which=" + txt_id.Text;
                    client.UploadFile(new Uri(s), "POST", @photoPath);
                    MessageBox.Show("Updated");
                }
                button1.Text = "Change";
                flowLayoutPanel1.Visible = false;
                pictureBox1.Visible = true;
                main.Show();
                m_v2.Show();
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_shortName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void combo_Category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void num_price_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedIndex = 1;
            lab_History.Text = "History of" + txt_id.Text +" - " + txt_Name.Text;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

       

        
    }
}

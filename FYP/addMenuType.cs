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
        private List<Label> labels = new List<Label>();
        private List<NumericUpDown> nums = new List<NumericUpDown>();

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
            //-------------tab2-------------------------------------//
            int intialTop = 60;
            DataTable dt_menufood = main.db.query("Select foodtype.name ,menufood.many from menufood , foodtype where menufood.ftypeid = foodtype.ftypeid and menuid = '"+txt_id.Text+"'");

            for (int i = 0; i < dt_menufood.Rows.Count; i++)
            {
                Label s = new Label();
                NumericUpDown num = new NumericUpDown();
                s.Left = 5;
                num.Left = 150;
                s.Top = intialTop;
                num.Top = intialTop;
                s.Name = "Label" + i;
                num.Name = "number" + i;
                s.Text = dt_menufood.Rows[i]["name"].ToString();
                num.Minimum = 1;
                num.Maximum = 10;
                tabControl1.TabPages[1].Controls.Add(s);
                tabControl1.TabPages[1].Controls.Add(num);
                labels.Add(s);
                nums.Add(num);
                intialTop += 50;
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
                MessageBox.Show("UPDATE successfil");
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
                if (flowLayoutPanel1.BackgroundImage == null) {
                    MessageBox.Show("Please input a picture");
                    return;
                }
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("Content-Type", "application/octet-stream");
                    String s = "http://"+main.db.id+"/fyp_php/uploadImgGet.php?action=image&which=" + txt_id.Text;
                    client.UploadFile(new Uri(s), "POST", @photoPath);
                    MessageBox.Show("Updated");
                }
                button1.Text = "Change";
                main.Show();
                m_v2.Show();
            }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedIndex = 1;
            lab_History.Text = "Food of" + txt_id.Text +" - " + txt_Name.Text;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }


        private void addMenuType_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
            m_v2.Show();
        }

       
       

        
    }
}

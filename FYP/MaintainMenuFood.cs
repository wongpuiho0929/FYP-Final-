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
    public partial class MaintainMenuFood : Form
    {
        private Main menu;
        private Database db;
        private String txt_MenuID;
        private List<Label> labels = new List<Label>();
        private List<NumericUpDown> nums = new List<NumericUpDown>();

        public MaintainMenuFood(Main menu, String txt_MenuID)
        {
            InitializeComponent();
            this.menu = menu;
            db = menu.db;
            this.txt_MenuID = txt_MenuID;
        }

        private void MaintainMenuFood_Load(object sender, EventArgs e)
        {
            DataTable dt_FoodType = db.getDb("FoodType");
            for (int i = 0; i < dt_FoodType.Rows.Count; i++)
            {
                chkedListBox_FoodType.Items.Add(dt_FoodType.Rows[i]["name"]);
            }
        }

        private void btn_NEXT_Click(object sender, EventArgs e)
        {
            
            int intialTop = 60;
            for(int i=0;i<chkedListBox_FoodType.CheckedItems.Count;i++){
                Label s = new Label();
                NumericUpDown num = new NumericUpDown();
                s.Left = 5;
                num.Left = 150;
                s.Top = intialTop;
                num.Top = intialTop;
                s.Name = "Label" + i;
                num.Name = "number" + i;
                s.Text = chkedListBox_FoodType.CheckedItems[i].ToString();
                num.Minimum = 1;
                num.Maximum = 10;
                panel1.Controls.Add(s);
                panel1.Controls.Add(num);
                labels.Add(s);
                nums.Add(num);
                intialTop += 50;
            }
            lab_NumberOfIem.Dock = DockStyle.Top;
            panel1.Dock = DockStyle.Fill;
            btn_Save.Dock = DockStyle.Bottom;
            btn_Save.Visible = true;
            lab_NumberOfIem.Visible = true;
            panel1.Visible = true;
            chkedListBox_FoodType.Visible = false;
            lab_FType.Visible = false;
            btn_NEXT.Visible = false;
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_FoodType = db.getDb("FoodType");
                String s1 = "DELETE FROM `menufood` WHERE menuId = '" + txt_MenuID + "'";
                db.queny(s1);
                for (int i = 0; i < labels.Count; i++)
                {
                    String FTName = labels[i].Text.ToString();
                    String FTID = "";
                    for (int k = 0; k < dt_FoodType.Rows.Count; k++)
                    {
                        if (FTName.Equals(dt_FoodType.Rows[k]["name"].ToString()))
                        {
                            FTID = dt_FoodType.Rows[k]["fTypeId"].ToString();
                        }
                    }
                    int numOfItems = Convert.ToInt32(nums[i].Value.ToString());

                    String s2 = "INSERT INTO `menuFood` (`menuId`, `fTypeId`, `many`) VALUES ('" + txt_MenuID + "', '" + FTID + "'," + numOfItems + ")";
                    db.queny(s2);
                }
                MessageBox.Show("Successful");
                this.Close();
            }
            catch (Exception) {
                MessageBox.Show("Please check your data");
            }
            
        }


    }
}

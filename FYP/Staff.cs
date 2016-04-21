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
    public partial class Staff : Form
    {
        private List<CheckBox> CheckBoxes = new List<CheckBox>();
        private Login login;
        public Database db;


        public Staff(Login login)
        {
            InitializeComponent();
            this.login = login;
            this.db = login.database;
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            DataTable dt_TakeTime = db.query("Select oTaketime from orders where status not in ('finish') and orderdate = CURDATE() group by oTaketime");
            int numberOfTime = dt_TakeTime.Rows.Count;
            if (combo_time.Items.Count != numberOfTime)
            {
                combo_time.Items.Clear();
                for (int i = 0; i < dt_TakeTime.Rows.Count; i++)
                {
                    combo_time.Items.Add(dt_TakeTime.Rows[i][0].ToString());
                }

            }

        }
        private void combo_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable dt_order = db.query("SELECT orders.orderid,orders.stuid,orderfood.foodid,food.name from food,orders,orderfood where orders.orderid = orderfood.orderid and orderfood.foodid = food.foodid and orders.oTakeTime='" + combo_time.SelectedItem.ToString()+"'");
            try
            {
                DataTable dt_order = db.query("SELECT orderid,stuid,status from orders where oTakeTime='" + combo_time.SelectedItem.ToString() + "' and orderdate = CURDATE()");
                dataGridView1.DataSource = dt_order;
            }
            catch (Exception ex)
            {
                if (combo_time.Items.Count == 0)
                {
                    MessageBox.Show("Do not have any order.");
                }
                else
                {
                    combo_time.SelectedIndex = 0;
                }
            }

        }

        private void btn_take_Click(object sender, EventArgs e)
        {
            grp_order.Visible = true;
            txt_studid.Enabled = false;
            DataTable dt_order = db.query("SELECT food.name from orders , orderfood , food where orderfood.orderid = orders.orderid and orderfood.orderDate = orders.orderDate and orderfood.foodid = food.foodid and orderfood.orderid = '"+txt_studid.Text+"' and orderfood.orderdate = CURDATE() ");
            int intialLeft = 30;
            int top = 30;
            
            for (int i = 0; i < dt_order.Rows.Count; i++)
            {
                CheckBox chk = new CheckBox();
                chk.Left = intialLeft;
                chk.Top = top;
                top += 30;
                chk.Text = dt_order.Rows[i][0].ToString();
                chk.Name = "chk_" + chk.Text;
                chk.AutoSize = true;
                grp_order.Controls.Add(chk);
                CheckBoxes.Add(chk);

            }
            
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

            String s = "Update orders set status ='finish' , takeTime = CURTIME() where orderid='" + txt_studid.Text + "'";
            db.queny(s);
            CheckBoxes.Clear();
            grp_order.Visible = false;
            txt_studid.Text = "";
            txt_studid.Enabled = true;
            MessageBox.Show("Confirm");
            combo_time_SelectedIndexChanged(sender, e);
         
        }
    }
}

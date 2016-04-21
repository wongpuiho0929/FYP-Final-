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
    public partial class MaintainUser : Form
    {
        private Main main;
        private Database db;
        

        public MaintainUser(Main main)
        {
            InitializeComponent();
            this.main = main;
            db = main.db;
        }

        private void MaintainUser_Load(object sender, EventArgs e)
        {
            
        }

        private void rBtn_All_CheckedChanged(object sender, EventArgs e)
        {
            DGV_Show.Dock = DockStyle.Fill;
            DataTable dt_data = new DataTable();
            dt_data.Columns.Add("Name", typeof(String));
            dt_data.Columns.Add("Position", typeof(String));
            DataTable dt_Student = db.query("Select stuid,status from student");
            DataTable dt_Staff = db.query("Select username,position from staff");
            int numberOfStud = 0;
            for (int i = 0; i < dt_Student.Rows.Count; i++)
            {
                DataRow s = dt_data.NewRow();
                s[0] = dt_Student.Rows[i][0].ToString();
                s[1] = dt_Student.Rows[i][1].ToString();
                dt_data.Rows.Add(s);
            }
            numberOfStud = dt_data.Rows.Count;
            for (int i = 0; i < dt_Staff.Rows.Count; i++)
            {
                
                DataRow s = dt_data.NewRow();
                s[0] = dt_Staff.Rows[i][0].ToString();
                s[1] = dt_Staff.Rows[i][1].ToString();
                dt_data.Rows.Add(s);
            }
            DGV_Show.DataSource = dt_data;
            for(int i=numberOfStud;i<DGV_Show.Rows.Count;i++){
                DGV_Show.Rows[i].DefaultCellStyle.BackColor = Color.Tomato;
            }
            grpbox_Staff.Visible = false;
            grpbox_Student.Visible = false;
        }

        private void rBtn_Student_CheckedChanged(object sender, EventArgs e)
        {
            DGV_Show.Dock = DockStyle.Top;
            DataTable dt_Student = db.getDb("student");
            DGV_Show.DataSource = dt_Student;
            grpbox_Staff.Visible = false;
            grpbox_Student.Visible = true;
         
        }

        private void rBtn_Staff_CheckedChanged(object sender, EventArgs e)
        {
            DGV_Show.Dock = DockStyle.Top;
            DataTable dt_Staff = db.getDb("Staff");
            DGV_Show.DataSource = dt_Staff;
            grpbox_Staff.Visible = true;
            grpbox_Student.Visible = false;

        }

        private void btn_AddStaff_Click(object sender, EventArgs e)
        {
            trueFalse(true);
            txt_userName.Text = "";
            txt_staffName.Text = "";
            txt_password.Text = "";
            combo_position.SelectedIndex = 0;
            
        }

        private void trueFalse(Boolean s) {
            txt_password.Enabled = s;
            txt_staffName.Enabled = s;
            txt_userName.Enabled = s;
            combo_position.Enabled = s;
            btn_cancel.Visible = s;
            btn_save.Visible = s;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            trueFalse(false);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                String s = " INSERT INTO `staff` (`username`, `password`, `position`, `name`) VALUES('" + txt_userName.Text + "', '" + txt_password.Text + "', '" + combo_position.SelectedItem.ToString() + "', '" + txt_staffName.Text + "')";
                db.queny(s);
                rBtn_Staff_CheckedChanged(sender, e);
                trueFalse(false);
            }
            catch (Exception) {
                MessageBox.Show("Have this member already!");
            }
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DGV_Show.Dock = DockStyle.Top;
            try
            {
                int number;
                if (rBtn_All.Checked)
                {

                    if (!Int32.TryParse(DGV_Show.SelectedRows[0].Cells[0].Value.ToString(), out number))
                    {

                        DataTable dt_staff = db.getDb("staff where username='" + DGV_Show.SelectedRows[0].Cells[0].Value.ToString() + "'");

                        if (dt_staff.Rows.Count != 0)
                        {
                            DGV_Show.DataSource = dt_staff;
                            filldataStaff(DGV_Show);
                            grpbox_Staff.Visible = true;
                            grpbox_Student.Visible = false;
                        }
                    }
                    else
                    {

                        DataTable dt_student = db.getDb("student where stuid='" + DGV_Show.SelectedRows[0].Cells[0].Value.ToString() + "'");
                        if (dt_student.Rows.Count != 0)
                        {
                            DGV_Show.DataSource = dt_student;
                            filldataStudent(DGV_Show);
                            grpbox_Student.Visible = true;
                            grpbox_Staff.Visible = false;
                        }
                    }
                }
                else if (rBtn_Student.Checked) {
                    DataTable dt_student = db.getDb("student where stuid='" + DGV_Show.SelectedRows[0].Cells["stuid"].Value.ToString() + "'");
                    if (dt_student.Rows.Count != 0)
                    {
                        DGV_Show.DataSource = dt_student;
                        filldataStudent(DGV_Show);
                        grpbox_Student.Visible = true;
                        grpbox_Staff.Visible = false;
                    }
                }else if(rBtn_Staff.Checked){

                    DataTable dt_staff = db.getDb("staff where username='" + DGV_Show.SelectedRows[0].Cells[0].Value.ToString() + "'");

                    if (dt_staff.Rows.Count != 0)
                    {
                        DGV_Show.DataSource = dt_staff;
                        filldataStaff(DGV_Show);
                        grpbox_Staff.Visible = true;
                        grpbox_Student.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void filldataStudent(DataGridView dt) {
            btn_back.Visible = true;
            txt_studName.Text = dt.SelectedRows[0].Cells["name"].Value.ToString();
            txt_studid.Text = dt.SelectedRows[0].Cells["stuid"].Value.ToString();
            txt_stuPassword.Text = dt.SelectedRows[0].Cells["password"].Value.ToString();
            num_balance.Value = Decimal.Parse(dt.SelectedRows[0].Cells["balance"].Value.ToString());
            txt_email.Text = dt.SelectedRows[0].Cells["email"].Value.ToString();
            if (dt.SelectedRows[0].Cells["status"].Value.ToString().Equals("approve")) {
                rBtn_A.Checked = true;
            }else if(dt.SelectedRows[0].Cells["status"].Value.ToString().Equals("freeze")){
                rBtn_F.Checked = true;
            }
            else if (dt.SelectedRows[0].Cells["status"].Value.ToString().Equals("processing"))
            {
                rBtn_P.Checked = true;
            }
        }

        private void filldataStaff(DataGridView dt) {
            btn_back.Visible = true;
            txt_userName.Text = dt.SelectedRows[0].Cells["userName"].Value.ToString();
            txt_password.Text = dt.SelectedRows[0].Cells["password"].Value.ToString();
            combo_position.SelectedItem = dt.SelectedRows[0].Cells["position"].Value.ToString();
            txt_staffName.Text = dt.SelectedRows[0].Cells["name"].Value.ToString();
        }

        private void btn_maintain_Click(object sender, EventArgs e)
        {
            String s = "UPDATE `student` SET status ='";
            if (rBtn_A.Checked) {
                s += "approve'";
            }else if(rBtn_F.Checked){
                s += "freeze'";
            }else if(rBtn_P.Checked){
                s += "processing'";
            }
            s += "where stuid='"+txt_studid.Text+"'";
            db.queny(s);
            DataTable dt_student = db.getDb("student where stuid='" + txt_studid.Text + "'");
            DGV_Show.DataSource = dt_student;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (rBtn_All.Checked) {
                rBtn_All_CheckedChanged(sender, e);
            }
            else if (rBtn_Staff.Checked) {
                rBtn_Staff_CheckedChanged(sender, e);
            }
            else if (rBtn_Student.Checked) {
                rBtn_Student_CheckedChanged(sender, e);
            }
            btn_back.Visible = false;
        }
        
    }
}

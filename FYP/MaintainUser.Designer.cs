namespace Login
{
    partial class MaintainUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lab_Search = new System.Windows.Forms.Label();
            this.lab_Name = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.rBtn_Student = new System.Windows.Forms.RadioButton();
            this.rBtn_All = new System.Windows.Forms.RadioButton();
            this.rBtn_Staff = new System.Windows.Forms.RadioButton();
            this.grpbox_Staff = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.combo_position = new System.Windows.Forms.ComboBox();
            this.txt_staffName = new System.Windows.Forms.TextBox();
            this.lab_StaffName = new System.Windows.Forms.Label();
            this.lab_position = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lab_Password = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.lab_userName = new System.Windows.Forms.Label();
            this.btn_AddStaff = new System.Windows.Forms.Button();
            this.DGV_Show = new System.Windows.Forms.DataGridView();
            this.grpbox_Student = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtn_F = new System.Windows.Forms.RadioButton();
            this.rBtn_A = new System.Windows.Forms.RadioButton();
            this.rBtn_P = new System.Windows.Forms.RadioButton();
            this.btn_maintain = new System.Windows.Forms.Button();
            this.num_balance = new System.Windows.Forms.NumericUpDown();
            this.lab_balance = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lab_email = new System.Windows.Forms.Label();
            this.txt_studName = new System.Windows.Forms.TextBox();
            this.lab_StudentName = new System.Windows.Forms.Label();
            this.txt_stuPassword = new System.Windows.Forms.TextBox();
            this.lab_passwordStudent = new System.Windows.Forms.Label();
            this.txt_studid = new System.Windows.Forms.TextBox();
            this.lab_stuid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpbox_Staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).BeginInit();
            this.grpbox_Student.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_balance)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lab_Search);
            this.splitContainer1.Panel1.Controls.Add(this.lab_Name);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpbox_Staff);
            this.splitContainer1.Panel2.Controls.Add(this.DGV_Show);
            this.splitContainer1.Panel2.Controls.Add(this.grpbox_Student);
            this.splitContainer1.Size = new System.Drawing.Size(978, 659);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.textBox1.Location = new System.Drawing.Point(18, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 32);
            this.textBox1.TabIndex = 6;
            // 
            // lab_Search
            // 
            this.lab_Search.AutoSize = true;
            this.lab_Search.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Underline);
            this.lab_Search.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lab_Search.Location = new System.Drawing.Point(199, 246);
            this.lab_Search.Name = "lab_Search";
            this.lab_Search.Size = new System.Drawing.Size(68, 24);
            this.lab_Search.TabIndex = 5;
            this.lab_Search.Text = "Search";
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.lab_Name.Location = new System.Drawing.Point(8, 178);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(166, 24);
            this.lab_Name.TabIndex = 3;
            this.lab_Name.Text = "Account Name/ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_back);
            this.groupBox1.Controls.Add(this.rBtn_Student);
            this.groupBox1.Controls.Add(this.rBtn_All);
            this.groupBox1.Controls.Add(this.rBtn_Staff);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose User Type";
            // 
            // btn_back
            // 
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_back.Location = new System.Drawing.Point(213, 17);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 38);
            this.btn_back.TabIndex = 49;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // rBtn_Student
            // 
            this.rBtn_Student.AutoSize = true;
            this.rBtn_Student.Location = new System.Drawing.Point(5, 62);
            this.rBtn_Student.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rBtn_Student.Name = "rBtn_Student";
            this.rBtn_Student.Size = new System.Drawing.Size(95, 28);
            this.rBtn_Student.TabIndex = 2;
            this.rBtn_Student.Text = "Student";
            this.rBtn_Student.UseVisualStyleBackColor = true;
            this.rBtn_Student.CheckedChanged += new System.EventHandler(this.rBtn_Student_CheckedChanged);
            // 
            // rBtn_All
            // 
            this.rBtn_All.AutoSize = true;
            this.rBtn_All.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.rBtn_All.Location = new System.Drawing.Point(6, 26);
            this.rBtn_All.Name = "rBtn_All";
            this.rBtn_All.Size = new System.Drawing.Size(51, 28);
            this.rBtn_All.TabIndex = 1;
            this.rBtn_All.Text = "All";
            this.rBtn_All.UseVisualStyleBackColor = true;
            this.rBtn_All.CheckedChanged += new System.EventHandler(this.rBtn_All_CheckedChanged);
            // 
            // rBtn_Staff
            // 
            this.rBtn_Staff.AutoSize = true;
            this.rBtn_Staff.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.rBtn_Staff.Location = new System.Drawing.Point(6, 97);
            this.rBtn_Staff.Name = "rBtn_Staff";
            this.rBtn_Staff.Size = new System.Drawing.Size(75, 28);
            this.rBtn_Staff.TabIndex = 2;
            this.rBtn_Staff.Text = "Staff";
            this.rBtn_Staff.UseVisualStyleBackColor = true;
            this.rBtn_Staff.CheckedChanged += new System.EventHandler(this.rBtn_Staff_CheckedChanged);
            // 
            // grpbox_Staff
            // 
            this.grpbox_Staff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbox_Staff.Controls.Add(this.btn_cancel);
            this.grpbox_Staff.Controls.Add(this.btn_save);
            this.grpbox_Staff.Controls.Add(this.combo_position);
            this.grpbox_Staff.Controls.Add(this.txt_staffName);
            this.grpbox_Staff.Controls.Add(this.lab_StaffName);
            this.grpbox_Staff.Controls.Add(this.lab_position);
            this.grpbox_Staff.Controls.Add(this.txt_password);
            this.grpbox_Staff.Controls.Add(this.lab_Password);
            this.grpbox_Staff.Controls.Add(this.txt_userName);
            this.grpbox_Staff.Controls.Add(this.lab_userName);
            this.grpbox_Staff.Controls.Add(this.btn_AddStaff);
            this.grpbox_Staff.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.grpbox_Staff.Location = new System.Drawing.Point(10, 407);
            this.grpbox_Staff.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpbox_Staff.Name = "grpbox_Staff";
            this.grpbox_Staff.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpbox_Staff.Size = new System.Drawing.Size(628, 341);
            this.grpbox_Staff.TabIndex = 38;
            this.grpbox_Staff.TabStop = false;
            this.grpbox_Staff.Text = "Staff";
            this.grpbox_Staff.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_cancel.Location = new System.Drawing.Point(490, 198);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(106, 38);
            this.btn_cancel.TabIndex = 49;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_save.Location = new System.Drawing.Point(356, 198);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(106, 38);
            this.btn_save.TabIndex = 48;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // combo_position
            // 
            this.combo_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_position.Enabled = false;
            this.combo_position.FormattingEnabled = true;
            this.combo_position.Items.AddRange(new object[] {
            "manager",
            "staff"});
            this.combo_position.Location = new System.Drawing.Point(15, 164);
            this.combo_position.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_position.Name = "combo_position";
            this.combo_position.Size = new System.Drawing.Size(106, 32);
            this.combo_position.TabIndex = 47;
            // 
            // txt_staffName
            // 
            this.txt_staffName.Enabled = false;
            this.txt_staffName.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_staffName.Location = new System.Drawing.Point(151, 160);
            this.txt_staffName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_staffName.Name = "txt_staffName";
            this.txt_staffName.Size = new System.Drawing.Size(446, 32);
            this.txt_staffName.TabIndex = 46;
            // 
            // lab_StaffName
            // 
            this.lab_StaffName.AutoSize = true;
            this.lab_StaffName.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lab_StaffName.Location = new System.Drawing.Point(148, 140);
            this.lab_StaffName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_StaffName.Name = "lab_StaffName";
            this.lab_StaffName.Size = new System.Drawing.Size(92, 19);
            this.lab_StaffName.TabIndex = 45;
            this.lab_StaffName.Text = "Staff Name:";
            // 
            // lab_position
            // 
            this.lab_position.AutoSize = true;
            this.lab_position.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lab_position.Location = new System.Drawing.Point(12, 140);
            this.lab_position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_position.Name = "lab_position";
            this.lab_position.Size = new System.Drawing.Size(63, 19);
            this.lab_position.TabIndex = 43;
            this.lab_position.Text = "Position:";
            // 
            // txt_password
            // 
            this.txt_password.Enabled = false;
            this.txt_password.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_password.Location = new System.Drawing.Point(151, 68);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(446, 32);
            this.txt_password.TabIndex = 42;
            // 
            // lab_Password
            // 
            this.lab_Password.AutoSize = true;
            this.lab_Password.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lab_Password.Location = new System.Drawing.Point(148, 49);
            this.lab_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Password.Name = "lab_Password";
            this.lab_Password.Size = new System.Drawing.Size(73, 19);
            this.lab_Password.TabIndex = 41;
            this.lab_Password.Text = "Password:";
            // 
            // txt_userName
            // 
            this.txt_userName.Enabled = false;
            this.txt_userName.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_userName.Location = new System.Drawing.Point(15, 68);
            this.txt_userName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(106, 32);
            this.txt_userName.TabIndex = 40;
            // 
            // lab_userName
            // 
            this.lab_userName.AutoSize = true;
            this.lab_userName.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lab_userName.Location = new System.Drawing.Point(12, 49);
            this.lab_userName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_userName.Name = "lab_userName";
            this.lab_userName.Size = new System.Drawing.Size(82, 19);
            this.lab_userName.TabIndex = 39;
            this.lab_userName.Text = "UserName:";
            // 
            // btn_AddStaff
            // 
            this.btn_AddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddStaff.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_AddStaff.Location = new System.Drawing.Point(15, 237);
            this.btn_AddStaff.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_AddStaff.Name = "btn_AddStaff";
            this.btn_AddStaff.Size = new System.Drawing.Size(106, 68);
            this.btn_AddStaff.TabIndex = 38;
            this.btn_AddStaff.Text = "Add";
            this.btn_AddStaff.UseVisualStyleBackColor = true;
            this.btn_AddStaff.Click += new System.EventHandler(this.btn_AddStaff_Click);
            // 
            // DGV_Show
            // 
            this.DGV_Show.AllowUserToAddRows = false;
            this.DGV_Show.AllowUserToDeleteRows = false;
            this.DGV_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Show.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Show.BackgroundColor = System.Drawing.Color.Azure;
            this.DGV_Show.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Show.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Show.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_Show.Location = new System.Drawing.Point(0, 0);
            this.DGV_Show.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGV_Show.MultiSelect = false;
            this.DGV_Show.Name = "DGV_Show";
            this.DGV_Show.ReadOnly = true;
            this.DGV_Show.RowTemplate.Height = 27;
            this.DGV_Show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Show.Size = new System.Drawing.Size(649, 402);
            this.DGV_Show.TabIndex = 2;
            this.DGV_Show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grpbox_Student
            // 
            this.grpbox_Student.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbox_Student.Controls.Add(this.groupBox2);
            this.grpbox_Student.Controls.Add(this.num_balance);
            this.grpbox_Student.Controls.Add(this.lab_balance);
            this.grpbox_Student.Controls.Add(this.txt_email);
            this.grpbox_Student.Controls.Add(this.lab_email);
            this.grpbox_Student.Controls.Add(this.txt_studName);
            this.grpbox_Student.Controls.Add(this.lab_StudentName);
            this.grpbox_Student.Controls.Add(this.txt_stuPassword);
            this.grpbox_Student.Controls.Add(this.lab_passwordStudent);
            this.grpbox_Student.Controls.Add(this.txt_studid);
            this.grpbox_Student.Controls.Add(this.lab_stuid);
            this.grpbox_Student.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.grpbox_Student.Location = new System.Drawing.Point(9, 407);
            this.grpbox_Student.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpbox_Student.Name = "grpbox_Student";
            this.grpbox_Student.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpbox_Student.Size = new System.Drawing.Size(628, 324);
            this.grpbox_Student.TabIndex = 1;
            this.grpbox_Student.TabStop = false;
            this.grpbox_Student.Text = "Student";
            this.grpbox_Student.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtn_F);
            this.groupBox2.Controls.Add(this.rBtn_A);
            this.groupBox2.Controls.Add(this.rBtn_P);
            this.groupBox2.Controls.Add(this.btn_maintain);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.groupBox2.Location = new System.Drawing.Point(15, 253);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(466, 56);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status Type:";
            // 
            // rBtn_F
            // 
            this.rBtn_F.AutoSize = true;
            this.rBtn_F.Location = new System.Drawing.Point(280, 27);
            this.rBtn_F.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rBtn_F.Name = "rBtn_F";
            this.rBtn_F.Size = new System.Drawing.Size(72, 23);
            this.rBtn_F.TabIndex = 2;
            this.rBtn_F.TabStop = true;
            this.rBtn_F.Text = "freeze";
            this.rBtn_F.UseVisualStyleBackColor = true;
            // 
            // rBtn_A
            // 
            this.rBtn_A.AutoSize = true;
            this.rBtn_A.Location = new System.Drawing.Point(146, 27);
            this.rBtn_A.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rBtn_A.Name = "rBtn_A";
            this.rBtn_A.Size = new System.Drawing.Size(77, 23);
            this.rBtn_A.TabIndex = 1;
            this.rBtn_A.TabStop = true;
            this.rBtn_A.Text = "approve";
            this.rBtn_A.UseVisualStyleBackColor = true;
            // 
            // rBtn_P
            // 
            this.rBtn_P.AutoSize = true;
            this.rBtn_P.Location = new System.Drawing.Point(28, 27);
            this.rBtn_P.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rBtn_P.Name = "rBtn_P";
            this.rBtn_P.Size = new System.Drawing.Size(95, 23);
            this.rBtn_P.TabIndex = 0;
            this.rBtn_P.TabStop = true;
            this.rBtn_P.Text = "processing";
            this.rBtn_P.UseVisualStyleBackColor = true;
            // 
            // btn_maintain
            // 
            this.btn_maintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maintain.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.btn_maintain.Location = new System.Drawing.Point(380, 17);
            this.btn_maintain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_maintain.Name = "btn_maintain";
            this.btn_maintain.Size = new System.Drawing.Size(65, 34);
            this.btn_maintain.TabIndex = 37;
            this.btn_maintain.Text = "change";
            this.btn_maintain.UseVisualStyleBackColor = true;
            this.btn_maintain.Click += new System.EventHandler(this.btn_maintain_Click);
            // 
            // num_balance
            // 
            this.num_balance.DecimalPlaces = 1;
            this.num_balance.Enabled = false;
            this.num_balance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_balance.Location = new System.Drawing.Point(151, 155);
            this.num_balance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.num_balance.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_balance.Name = "num_balance";
            this.num_balance.Size = new System.Drawing.Size(98, 32);
            this.num_balance.TabIndex = 59;
            // 
            // lab_balance
            // 
            this.lab_balance.AutoSize = true;
            this.lab_balance.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lab_balance.Location = new System.Drawing.Point(148, 132);
            this.lab_balance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_balance.Name = "lab_balance";
            this.lab_balance.Size = new System.Drawing.Size(62, 19);
            this.lab_balance.TabIndex = 58;
            this.lab_balance.Text = "Balance:";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_email.Location = new System.Drawing.Point(15, 215);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(446, 32);
            this.txt_email.TabIndex = 57;
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lab_email.Location = new System.Drawing.Point(12, 195);
            this.lab_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(48, 19);
            this.lab_email.TabIndex = 56;
            this.lab_email.Text = "Email:";
            // 
            // txt_studName
            // 
            this.txt_studName.Enabled = false;
            this.txt_studName.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_studName.Location = new System.Drawing.Point(15, 152);
            this.txt_studName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_studName.Name = "txt_studName";
            this.txt_studName.Size = new System.Drawing.Size(106, 32);
            this.txt_studName.TabIndex = 54;
            // 
            // lab_StudentName
            // 
            this.lab_StudentName.AutoSize = true;
            this.lab_StudentName.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lab_StudentName.Location = new System.Drawing.Point(12, 132);
            this.lab_StudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_StudentName.Name = "lab_StudentName";
            this.lab_StudentName.Size = new System.Drawing.Size(108, 19);
            this.lab_StudentName.TabIndex = 53;
            this.lab_StudentName.Text = "Student Name:";
            // 
            // txt_stuPassword
            // 
            this.txt_stuPassword.Enabled = false;
            this.txt_stuPassword.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_stuPassword.Location = new System.Drawing.Point(151, 79);
            this.txt_stuPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_stuPassword.Name = "txt_stuPassword";
            this.txt_stuPassword.Size = new System.Drawing.Size(446, 32);
            this.txt_stuPassword.TabIndex = 51;
            // 
            // lab_passwordStudent
            // 
            this.lab_passwordStudent.AutoSize = true;
            this.lab_passwordStudent.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lab_passwordStudent.Location = new System.Drawing.Point(148, 59);
            this.lab_passwordStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_passwordStudent.Name = "lab_passwordStudent";
            this.lab_passwordStudent.Size = new System.Drawing.Size(73, 19);
            this.lab_passwordStudent.TabIndex = 50;
            this.lab_passwordStudent.Text = "Password:";
            // 
            // txt_studid
            // 
            this.txt_studid.Enabled = false;
            this.txt_studid.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_studid.Location = new System.Drawing.Point(15, 79);
            this.txt_studid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_studid.Name = "txt_studid";
            this.txt_studid.Size = new System.Drawing.Size(106, 32);
            this.txt_studid.TabIndex = 49;
            // 
            // lab_stuid
            // 
            this.lab_stuid.AutoSize = true;
            this.lab_stuid.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lab_stuid.Location = new System.Drawing.Point(12, 59);
            this.lab_stuid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_stuid.Name = "lab_stuid";
            this.lab_stuid.Size = new System.Drawing.Size(89, 19);
            this.lab_stuid.TabIndex = 48;
            this.lab_stuid.Text = "Student ID:";
            // 
            // MaintainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(978, 659);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MaintainUser";
            this.Text = "MaintainUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MaintainUser_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbox_Staff.ResumeLayout(false);
            this.grpbox_Staff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).EndInit();
            this.grpbox_Student.ResumeLayout(false);
            this.grpbox_Student.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_balance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton rBtn_Staff;
        private System.Windows.Forms.RadioButton rBtn_All;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rBtn_Student;
        private System.Windows.Forms.GroupBox grpbox_Student;
        private System.Windows.Forms.Button btn_maintain;
        private System.Windows.Forms.GroupBox grpbox_Staff;
        private System.Windows.Forms.DataGridView DGV_Show;
        private System.Windows.Forms.Button btn_AddStaff;
        private System.Windows.Forms.TextBox txt_staffName;
        private System.Windows.Forms.Label lab_StaffName;
        private System.Windows.Forms.Label lab_position;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lab_Password;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label lab_userName;
        private System.Windows.Forms.ComboBox combo_position;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.NumericUpDown num_balance;
        private System.Windows.Forms.Label lab_balance;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.TextBox txt_studName;
        private System.Windows.Forms.Label lab_StudentName;
        private System.Windows.Forms.TextBox txt_stuPassword;
        private System.Windows.Forms.Label lab_passwordStudent;
        private System.Windows.Forms.TextBox txt_studid;
        private System.Windows.Forms.Label lab_stuid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtn_F;
        private System.Windows.Forms.RadioButton rBtn_A;
        private System.Windows.Forms.RadioButton rBtn_P;
        private System.Windows.Forms.Button btn_back;


    }
}
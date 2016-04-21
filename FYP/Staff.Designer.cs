namespace Login
{
    partial class Staff
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
            this.grp_takeOrder = new System.Windows.Forms.GroupBox();
            this.grp_order = new System.Windows.Forms.GroupBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.grp_StudentInfo = new System.Windows.Forms.GroupBox();
            this.txt_studid = new System.Windows.Forms.TextBox();
            this.btn_take = new System.Windows.Forms.Button();
            this.lab_studentID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lab_TakeTime = new System.Windows.Forms.Label();
            this.combo_time = new System.Windows.Forms.ComboBox();
            this.grp_takeOrder.SuspendLayout();
            this.grp_order.SuspendLayout();
            this.grp_StudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_takeOrder
            // 
            this.grp_takeOrder.Controls.Add(this.grp_order);
            this.grp_takeOrder.Controls.Add(this.grp_StudentInfo);
            this.grp_takeOrder.Controls.Add(this.dataGridView1);
            this.grp_takeOrder.Controls.Add(this.lab_TakeTime);
            this.grp_takeOrder.Controls.Add(this.combo_time);
            this.grp_takeOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_takeOrder.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.grp_takeOrder.Location = new System.Drawing.Point(0, 0);
            this.grp_takeOrder.Name = "grp_takeOrder";
            this.grp_takeOrder.Size = new System.Drawing.Size(1116, 832);
            this.grp_takeOrder.TabIndex = 6;
            this.grp_takeOrder.TabStop = false;
            this.grp_takeOrder.Text = "Take Order";
            // 
            // grp_order
            // 
            this.grp_order.Controls.Add(this.btn_Confirm);
            this.grp_order.Location = new System.Drawing.Point(13, 563);
            this.grp_order.Name = "grp_order";
            this.grp_order.Size = new System.Drawing.Size(1091, 257);
            this.grp_order.TabIndex = 7;
            this.grp_order.TabStop = false;
            this.grp_order.Text = "Order";
            this.grp_order.Visible = false;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Confirm.Location = new System.Drawing.Point(3, 209);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(1085, 45);
            this.btn_Confirm.TabIndex = 0;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // grp_StudentInfo
            // 
            this.grp_StudentInfo.Controls.Add(this.txt_studid);
            this.grp_StudentInfo.Controls.Add(this.btn_take);
            this.grp_StudentInfo.Controls.Add(this.lab_studentID);
            this.grp_StudentInfo.Location = new System.Drawing.Point(13, 373);
            this.grp_StudentInfo.Name = "grp_StudentInfo";
            this.grp_StudentInfo.Size = new System.Drawing.Size(1091, 183);
            this.grp_StudentInfo.TabIndex = 6;
            this.grp_StudentInfo.TabStop = false;
            // 
            // txt_studid
            // 
            this.txt_studid.Location = new System.Drawing.Point(5, 77);
            this.txt_studid.Name = "txt_studid";
            this.txt_studid.Size = new System.Drawing.Size(223, 35);
            this.txt_studid.TabIndex = 4;
            // 
            // btn_take
            // 
            this.btn_take.Location = new System.Drawing.Point(6, 132);
            this.btn_take.Name = "btn_take";
            this.btn_take.Size = new System.Drawing.Size(223, 45);
            this.btn_take.TabIndex = 5;
            this.btn_take.Text = "Search";
            this.btn_take.UseVisualStyleBackColor = true;
            this.btn_take.Click += new System.EventHandler(this.btn_take_Click);
            // 
            // lab_studentID
            // 
            this.lab_studentID.AutoSize = true;
            this.lab_studentID.Location = new System.Drawing.Point(1, 43);
            this.lab_studentID.Name = "lab_studentID";
            this.lab_studentID.Size = new System.Drawing.Size(108, 28);
            this.lab_studentID.TabIndex = 3;
            this.lab_studentID.Text = "Order ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1091, 286);
            this.dataGridView1.TabIndex = 2;
            // 
            // lab_TakeTime
            // 
            this.lab_TakeTime.AutoSize = true;
            this.lab_TakeTime.Location = new System.Drawing.Point(9, 42);
            this.lab_TakeTime.Name = "lab_TakeTime";
            this.lab_TakeTime.Size = new System.Drawing.Size(116, 28);
            this.lab_TakeTime.TabIndex = 1;
            this.lab_TakeTime.Text = "Take Time:";
            // 
            // combo_time
            // 
            this.combo_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_time.FormattingEnabled = true;
            this.combo_time.Location = new System.Drawing.Point(131, 39);
            this.combo_time.Name = "combo_time";
            this.combo_time.Size = new System.Drawing.Size(329, 36);
            this.combo_time.TabIndex = 0;
            this.combo_time.SelectedIndexChanged += new System.EventHandler(this.combo_time_SelectedIndexChanged);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 832);
            this.Controls.Add(this.grp_takeOrder);
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.grp_takeOrder.ResumeLayout(false);
            this.grp_takeOrder.PerformLayout();
            this.grp_order.ResumeLayout(false);
            this.grp_StudentInfo.ResumeLayout(false);
            this.grp_StudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_takeOrder;
        private System.Windows.Forms.GroupBox grp_order;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.GroupBox grp_StudentInfo;
        private System.Windows.Forms.TextBox txt_studid;
        private System.Windows.Forms.Button btn_take;
        private System.Windows.Forms.Label lab_studentID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lab_TakeTime;
        private System.Windows.Forms.ComboBox combo_time;
    }
}
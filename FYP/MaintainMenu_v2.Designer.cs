namespace Login
{
    partial class MaintainMenu_v2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grp_MenuInfo = new System.Windows.Forms.GroupBox();
            this.lab_Type = new System.Windows.Forms.Label();
            this.lab_menuof = new System.Windows.Forms.Label();
            this.btn_ChangeMenu = new System.Windows.Forms.Button();
            this.btn_genXML = new System.Windows.Forms.Button();
            this.btn_foodlist = new System.Windows.Forms.Button();
            this.chk_Sun = new System.Windows.Forms.CheckBox();
            this.chk_Sat = new System.Windows.Forms.CheckBox();
            this.chk_Fri = new System.Windows.Forms.CheckBox();
            this.chk_Thu = new System.Windows.Forms.CheckBox();
            this.chk_Wed = new System.Windows.Forms.CheckBox();
            this.chk_Tue = new System.Windows.Forms.CheckBox();
            this.chk_Mon = new System.Windows.Forms.CheckBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grp_MenuInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grp_MenuInfo);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ChangeMenu);
            this.splitContainer1.Panel1.Controls.Add(this.btn_genXML);
            this.splitContainer1.Panel1.Controls.Add(this.btn_foodlist);
            this.splitContainer1.Panel1.Controls.Add(this.chk_Sun);
            this.splitContainer1.Panel1.Controls.Add(this.chk_Sat);
            this.splitContainer1.Panel1.Controls.Add(this.chk_Fri);
            this.splitContainer1.Panel1.Controls.Add(this.chk_Thu);
            this.splitContainer1.Panel1.Controls.Add(this.chk_Wed);
            this.splitContainer1.Panel1.Controls.Add(this.chk_Tue);
            this.splitContainer1.Panel1.Controls.Add(this.chk_Mon);
            this.splitContainer1.Panel1.Controls.Add(this.monthCalendar1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1915, 1049);
            this.splitContainer1.SplitterDistance = 449;
            this.splitContainer1.TabIndex = 0;
            // 
            // grp_MenuInfo
            // 
            this.grp_MenuInfo.Controls.Add(this.lab_Type);
            this.grp_MenuInfo.Controls.Add(this.lab_menuof);
            this.grp_MenuInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.grp_MenuInfo.Location = new System.Drawing.Point(12, 587);
            this.grp_MenuInfo.Name = "grp_MenuInfo";
            this.grp_MenuInfo.Size = new System.Drawing.Size(421, 450);
            this.grp_MenuInfo.TabIndex = 15;
            this.grp_MenuInfo.TabStop = false;
            this.grp_MenuInfo.Text = "Menu Info";
            // 
            // lab_Type
            // 
            this.lab_Type.AutoSize = true;
            this.lab_Type.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lab_Type.Location = new System.Drawing.Point(6, 121);
            this.lab_Type.Name = "lab_Type";
            this.lab_Type.Size = new System.Drawing.Size(119, 28);
            this.lab_Type.TabIndex = 1;
            this.lab_Type.Text = "Menu Type:";
            // 
            // lab_menuof
            // 
            this.lab_menuof.AutoSize = true;
            this.lab_menuof.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lab_menuof.Location = new System.Drawing.Point(6, 64);
            this.lab_menuof.Name = "lab_menuof";
            this.lab_menuof.Size = new System.Drawing.Size(101, 28);
            this.lab_menuof.TabIndex = 0;
            this.lab_menuof.Text = "Menu OF:";
            // 
            // btn_ChangeMenu
            // 
            this.btn_ChangeMenu.Location = new System.Drawing.Point(31, 409);
            this.btn_ChangeMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ChangeMenu.Name = "btn_ChangeMenu";
            this.btn_ChangeMenu.Size = new System.Drawing.Size(271, 51);
            this.btn_ChangeMenu.TabIndex = 14;
            this.btn_ChangeMenu.Text = "Change Default Menu";
            this.btn_ChangeMenu.UseVisualStyleBackColor = true;
            this.btn_ChangeMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_genXML
            // 
            this.btn_genXML.Location = new System.Drawing.Point(31, 494);
            this.btn_genXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_genXML.Name = "btn_genXML";
            this.btn_genXML.Size = new System.Drawing.Size(121, 51);
            this.btn_genXML.TabIndex = 13;
            this.btn_genXML.Text = "Create Menu";
            this.btn_genXML.UseVisualStyleBackColor = true;
            this.btn_genXML.Click += new System.EventHandler(this.btn_genXML_Click);
            // 
            // btn_foodlist
            // 
            this.btn_foodlist.Location = new System.Drawing.Point(181, 494);
            this.btn_foodlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_foodlist.Name = "btn_foodlist";
            this.btn_foodlist.Size = new System.Drawing.Size(121, 51);
            this.btn_foodlist.TabIndex = 12;
            this.btn_foodlist.Text = "Food List";
            this.btn_foodlist.UseVisualStyleBackColor = true;
            this.btn_foodlist.Click += new System.EventHandler(this.btn_foodlist_Click);
            // 
            // chk_Sun
            // 
            this.chk_Sun.AutoSize = true;
            this.chk_Sun.Enabled = false;
            this.chk_Sun.Location = new System.Drawing.Point(37, 359);
            this.chk_Sun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_Sun.Name = "chk_Sun";
            this.chk_Sun.Size = new System.Drawing.Size(71, 19);
            this.chk_Sun.TabIndex = 8;
            this.chk_Sun.Text = "Sunday";
            this.chk_Sun.UseVisualStyleBackColor = true;
            // 
            // chk_Sat
            // 
            this.chk_Sat.AutoSize = true;
            this.chk_Sat.Enabled = false;
            this.chk_Sat.Location = new System.Drawing.Point(181, 322);
            this.chk_Sat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_Sat.Name = "chk_Sat";
            this.chk_Sat.Size = new System.Drawing.Size(79, 19);
            this.chk_Sat.TabIndex = 7;
            this.chk_Sat.Text = "Saturday";
            this.chk_Sat.UseVisualStyleBackColor = true;
            // 
            // chk_Fri
            // 
            this.chk_Fri.AutoSize = true;
            this.chk_Fri.Enabled = false;
            this.chk_Fri.Location = new System.Drawing.Point(37, 322);
            this.chk_Fri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_Fri.Name = "chk_Fri";
            this.chk_Fri.Size = new System.Drawing.Size(66, 19);
            this.chk_Fri.TabIndex = 6;
            this.chk_Fri.Text = "Friday";
            this.chk_Fri.UseVisualStyleBackColor = true;
            // 
            // chk_Thu
            // 
            this.chk_Thu.AutoSize = true;
            this.chk_Thu.Enabled = false;
            this.chk_Thu.Location = new System.Drawing.Point(181, 284);
            this.chk_Thu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_Thu.Name = "chk_Thu";
            this.chk_Thu.Size = new System.Drawing.Size(82, 19);
            this.chk_Thu.TabIndex = 5;
            this.chk_Thu.Text = "Thursday";
            this.chk_Thu.UseVisualStyleBackColor = true;
            // 
            // chk_Wed
            // 
            this.chk_Wed.AutoSize = true;
            this.chk_Wed.Enabled = false;
            this.chk_Wed.Location = new System.Drawing.Point(37, 284);
            this.chk_Wed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_Wed.Name = "chk_Wed";
            this.chk_Wed.Size = new System.Drawing.Size(93, 19);
            this.chk_Wed.TabIndex = 4;
            this.chk_Wed.Text = "Wednesday";
            this.chk_Wed.UseVisualStyleBackColor = true;
            // 
            // chk_Tue
            // 
            this.chk_Tue.AutoSize = true;
            this.chk_Tue.Enabled = false;
            this.chk_Tue.Location = new System.Drawing.Point(181, 250);
            this.chk_Tue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_Tue.Name = "chk_Tue";
            this.chk_Tue.Size = new System.Drawing.Size(76, 19);
            this.chk_Tue.TabIndex = 3;
            this.chk_Tue.Text = "Tuesday";
            this.chk_Tue.UseVisualStyleBackColor = true;
            // 
            // chk_Mon
            // 
            this.chk_Mon.AutoSize = true;
            this.chk_Mon.Enabled = false;
            this.chk_Mon.Location = new System.Drawing.Point(37, 250);
            this.chk_Mon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_Mon.Name = "chk_Mon";
            this.chk_Mon.Size = new System.Drawing.Size(76, 19);
            this.chk_Mon.TabIndex = 2;
            this.chk_Mon.Text = "Monday";
            this.chk_Mon.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.monthCalendar1.Location = new System.Drawing.Point(19, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1462, 1049);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // MaintainMenu_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1915, 1049);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MaintainMenu_v2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MaintainMenu_v2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MaintainMenu_v2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grp_MenuInfo.ResumeLayout(false);
            this.grp_MenuInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckBox chk_Sun;
        private System.Windows.Forms.CheckBox chk_Sat;
        private System.Windows.Forms.CheckBox chk_Fri;
        private System.Windows.Forms.CheckBox chk_Thu;
        private System.Windows.Forms.CheckBox chk_Wed;
        private System.Windows.Forms.CheckBox chk_Tue;
        private System.Windows.Forms.CheckBox chk_Mon;
        private System.Windows.Forms.Button btn_foodlist;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_genXML;
        private System.Windows.Forms.Button btn_ChangeMenu;
        private System.Windows.Forms.GroupBox grp_MenuInfo;
        private System.Windows.Forms.Label lab_Type;
        private System.Windows.Forms.Label lab_menuof;
    }
}
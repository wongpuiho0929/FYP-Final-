namespace Login
{
    partial class ChangeMenu
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
            this.r_Mon = new System.Windows.Forms.RadioButton();
            this.r_Tue = new System.Windows.Forms.RadioButton();
            this.e_wed = new System.Windows.Forms.RadioButton();
            this.r_Thu = new System.Windows.Forms.RadioButton();
            this.r_fri = new System.Windows.Forms.RadioButton();
            this.r_sat = new System.Windows.Forms.RadioButton();
            this.r_Sun = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lab_menuin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // r_Mon
            // 
            this.r_Mon.AutoSize = true;
            this.r_Mon.Location = new System.Drawing.Point(12, 28);
            this.r_Mon.Name = "r_Mon";
            this.r_Mon.Size = new System.Drawing.Size(55, 19);
            this.r_Mon.TabIndex = 0;
            this.r_Mon.TabStop = true;
            this.r_Mon.Text = "Mon";
            this.r_Mon.UseVisualStyleBackColor = true;
            this.r_Mon.CheckedChanged += new System.EventHandler(this.r_Mon_CheckedChanged);
            // 
            // r_Tue
            // 
            this.r_Tue.AutoSize = true;
            this.r_Tue.Location = new System.Drawing.Point(120, 28);
            this.r_Tue.Name = "r_Tue";
            this.r_Tue.Size = new System.Drawing.Size(50, 19);
            this.r_Tue.TabIndex = 1;
            this.r_Tue.TabStop = true;
            this.r_Tue.Text = "Tue";
            this.r_Tue.UseVisualStyleBackColor = true;
            this.r_Tue.CheckedChanged += new System.EventHandler(this.r_Tue_CheckedChanged);
            // 
            // e_wed
            // 
            this.e_wed.AutoSize = true;
            this.e_wed.Location = new System.Drawing.Point(228, 28);
            this.e_wed.Name = "e_wed";
            this.e_wed.Size = new System.Drawing.Size(54, 19);
            this.e_wed.TabIndex = 2;
            this.e_wed.TabStop = true;
            this.e_wed.Text = "Wed";
            this.e_wed.UseVisualStyleBackColor = true;
            this.e_wed.CheckedChanged += new System.EventHandler(this.e_wed_CheckedChanged);
            // 
            // r_Thu
            // 
            this.r_Thu.AutoSize = true;
            this.r_Thu.Location = new System.Drawing.Point(336, 28);
            this.r_Thu.Name = "r_Thu";
            this.r_Thu.Size = new System.Drawing.Size(51, 19);
            this.r_Thu.TabIndex = 3;
            this.r_Thu.TabStop = true;
            this.r_Thu.Text = "Thu";
            this.r_Thu.UseVisualStyleBackColor = true;
            this.r_Thu.CheckedChanged += new System.EventHandler(this.r_Thu_CheckedChanged);
            // 
            // r_fri
            // 
            this.r_fri.AutoSize = true;
            this.r_fri.Location = new System.Drawing.Point(444, 28);
            this.r_fri.Name = "r_fri";
            this.r_fri.Size = new System.Drawing.Size(45, 19);
            this.r_fri.TabIndex = 4;
            this.r_fri.TabStop = true;
            this.r_fri.Text = "Fri";
            this.r_fri.UseVisualStyleBackColor = true;
            this.r_fri.CheckedChanged += new System.EventHandler(this.r_fri_CheckedChanged);
            // 
            // r_sat
            // 
            this.r_sat.AutoSize = true;
            this.r_sat.Location = new System.Drawing.Point(552, 28);
            this.r_sat.Name = "r_sat";
            this.r_sat.Size = new System.Drawing.Size(46, 19);
            this.r_sat.TabIndex = 5;
            this.r_sat.TabStop = true;
            this.r_sat.Text = "Sat";
            this.r_sat.UseVisualStyleBackColor = true;
            this.r_sat.CheckedChanged += new System.EventHandler(this.r_sat_CheckedChanged);
            // 
            // r_Sun
            // 
            this.r_Sun.AutoSize = true;
            this.r_Sun.Location = new System.Drawing.Point(660, 28);
            this.r_Sun.Name = "r_Sun";
            this.r_Sun.Size = new System.Drawing.Size(50, 19);
            this.r_Sun.TabIndex = 6;
            this.r_Sun.TabStop = true;
            this.r_Sun.Text = "Sun";
            this.r_Sun.UseVisualStyleBackColor = true;
            this.r_Sun.CheckedChanged += new System.EventHandler(this.r_Sun_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(745, 244);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lab_menuin
            // 
            this.lab_menuin.AutoSize = true;
            this.lab_menuin.Location = new System.Drawing.Point(13, 75);
            this.lab_menuin.Name = "lab_menuin";
            this.lab_menuin.Size = new System.Drawing.Size(0, 15);
            this.lab_menuin.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 63);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChangeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 495);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_menuin);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.r_Sun);
            this.Controls.Add(this.r_sat);
            this.Controls.Add(this.r_fri);
            this.Controls.Add(this.r_Thu);
            this.Controls.Add(this.e_wed);
            this.Controls.Add(this.r_Tue);
            this.Controls.Add(this.r_Mon);
            this.Name = "ChangeMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeMenu";
            this.Load += new System.EventHandler(this.ChangeMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton r_Mon;
        private System.Windows.Forms.RadioButton r_Tue;
        private System.Windows.Forms.RadioButton e_wed;
        private System.Windows.Forms.RadioButton r_Thu;
        private System.Windows.Forms.RadioButton r_fri;
        private System.Windows.Forms.RadioButton r_sat;
        private System.Windows.Forms.RadioButton r_Sun;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lab_menuin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
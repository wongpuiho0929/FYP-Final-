namespace Login
{
    partial class AddValue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_Info = new System.Windows.Forms.Label();
            this.txt_studID = new System.Windows.Forms.TextBox();
            this.lab_Search = new System.Windows.Forms.Label();
            this.btn_50 = new System.Windows.Forms.Button();
            this.btn_100 = new System.Windows.Forms.Button();
            this.btn_500 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_total = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.ListBox_History = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.lab_Info);
            this.panel1.Controls.Add(this.txt_studID);
            this.panel1.Controls.Add(this.lab_Search);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 485);
            this.panel1.TabIndex = 0;
            // 
            // lab_Info
            // 
            this.lab_Info.AutoSize = true;
            this.lab_Info.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lab_Info.Location = new System.Drawing.Point(15, 132);
            this.lab_Info.Name = "lab_Info";
            this.lab_Info.Size = new System.Drawing.Size(54, 28);
            this.lab_Info.TabIndex = 4;
            this.lab_Info.Text = "Info";
            // 
            // txt_studID
            // 
            this.txt_studID.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.txt_studID.Location = new System.Drawing.Point(10, 66);
            this.txt_studID.Name = "txt_studID";
            this.txt_studID.Size = new System.Drawing.Size(214, 28);
            this.txt_studID.TabIndex = 3;
            this.txt_studID.TextChanged += new System.EventHandler(this.txt_studID_TextChanged);
            // 
            // lab_Search
            // 
            this.lab_Search.AutoSize = true;
            this.lab_Search.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.lab_Search.Location = new System.Drawing.Point(10, 33);
            this.lab_Search.Name = "lab_Search";
            this.lab_Search.Size = new System.Drawing.Size(138, 30);
            this.lab_Search.TabIndex = 2;
            this.lab_Search.Text = "Student ID:";
            // 
            // btn_50
            // 
            this.btn_50.BackColor = System.Drawing.SystemColors.Control;
            this.btn_50.Font = new System.Drawing.Font("PMingLiU", 18F);
            this.btn_50.Location = new System.Drawing.Point(6, 48);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(206, 71);
            this.btn_50.TabIndex = 6;
            this.btn_50.Text = "$50";
            this.btn_50.UseVisualStyleBackColor = false;
            this.btn_50.Click += new System.EventHandler(this.btn_50_Click);
            // 
            // btn_100
            // 
            this.btn_100.BackColor = System.Drawing.SystemColors.Control;
            this.btn_100.Font = new System.Drawing.Font("PMingLiU", 18F);
            this.btn_100.Location = new System.Drawing.Point(6, 165);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(206, 71);
            this.btn_100.TabIndex = 7;
            this.btn_100.Text = "$100";
            this.btn_100.UseVisualStyleBackColor = false;
            this.btn_100.Click += new System.EventHandler(this.btn_100_Click);
            // 
            // btn_500
            // 
            this.btn_500.BackColor = System.Drawing.SystemColors.Control;
            this.btn_500.Font = new System.Drawing.Font("PMingLiU", 18F);
            this.btn_500.Location = new System.Drawing.Point(6, 282);
            this.btn_500.Name = "btn_500";
            this.btn_500.Size = new System.Drawing.Size(206, 71);
            this.btn_500.TabIndex = 8;
            this.btn_500.Text = "$500";
            this.btn_500.UseVisualStyleBackColor = false;
            this.btn_500.Click += new System.EventHandler(this.btn_500_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lab_total);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_50);
            this.groupBox1.Controls.Add(this.btn_500);
            this.groupBox1.Controls.Add(this.btn_100);
            this.groupBox1.Font = new System.Drawing.Font("PMingLiU", 14F);
            this.groupBox1.Location = new System.Drawing.Point(770, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 485);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Value";
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.lab_total.Location = new System.Drawing.Point(7, 392);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(109, 33);
            this.lab_total.TabIndex = 10;
            this.lab_total.Text = "Total : 0";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(68, 445);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 34);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // ListBox_History
            // 
            this.ListBox_History.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox_History.FormattingEnabled = true;
            this.ListBox_History.ItemHeight = 15;
            this.ListBox_History.Location = new System.Drawing.Point(249, 12);
            this.ListBox_History.Name = "ListBox_History";
            this.ListBox_History.Size = new System.Drawing.Size(515, 349);
            this.ListBox_History.TabIndex = 10;
            // 
            // AddValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 509);
            this.Controls.Add(this.ListBox_History);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddValue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddValue";
            this.Load += new System.EventHandler(this.AddValue_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddValue_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_studID;
        private System.Windows.Forms.Label lab_Search;
        private System.Windows.Forms.Label lab_Info;
        private System.Windows.Forms.Button btn_50;
        private System.Windows.Forms.Button btn_100;
        private System.Windows.Forms.Button btn_500;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_total;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox ListBox_History;
    }
}
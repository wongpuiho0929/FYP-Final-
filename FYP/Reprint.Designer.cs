namespace Login
{
    partial class Reprint
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
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_oNo = new System.Windows.Forms.Label();
            this.tb_ono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_hour = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_min = new System.Windows.Forms.ComboBox();
            this.cb_second = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lv_listFile = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_print = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_time_choose = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(9, 130);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(310, 45);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Serach/Clear checked item";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_oNo
            // 
            this.lbl_oNo.AutoSize = true;
            this.lbl_oNo.Location = new System.Drawing.Point(6, 29);
            this.lbl_oNo.Name = "lbl_oNo";
            this.lbl_oNo.Size = new System.Drawing.Size(50, 13);
            this.lbl_oNo.TabIndex = 1;
            this.lbl_oNo.Text = "OrderNo:";
            // 
            // tb_ono
            // 
            this.tb_ono.Location = new System.Drawing.Point(62, 26);
            this.tb_ono.Name = "tb_ono";
            this.tb_ono.Size = new System.Drawing.Size(254, 20);
            this.tb_ono.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time(HH/MM/SS):";
            // 
            // cb_hour
            // 
            this.cb_hour.FormattingEnabled = true;
            this.cb_hour.Location = new System.Drawing.Point(122, 99);
            this.cb_hour.Name = "cb_hour";
            this.cb_hour.Size = new System.Drawing.Size(50, 21);
            this.cb_hour.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // cb_min
            // 
            this.cb_min.FormattingEnabled = true;
            this.cb_min.Location = new System.Drawing.Point(194, 99);
            this.cb_min.Name = "cb_min";
            this.cb_min.Size = new System.Drawing.Size(50, 21);
            this.cb_min.TabIndex = 10;
            // 
            // cb_second
            // 
            this.cb_second.FormattingEnabled = true;
            this.cb_second.Location = new System.Drawing.Point(266, 99);
            this.cb_second.Name = "cb_second";
            this.cb_second.Size = new System.Drawing.Size(50, 21);
            this.cb_second.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // lv_listFile
            // 
            this.lv_listFile.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_listFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_listFile.FullRowSelect = true;
            this.lv_listFile.Location = new System.Drawing.Point(15, 209);
            this.lv_listFile.Name = "lv_listFile";
            this.lv_listFile.Size = new System.Drawing.Size(325, 246);
            this.lv_listFile.TabIndex = 11;
            this.lv_listFile.UseCompatibleStateImageBehavior = false;
            this.lv_listFile.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Choose";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Count";
            this.columnHeader3.Width = 100;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(15, 533);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(325, 56);
            this.btn_print.TabIndex = 12;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Time(Choose):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_time_choose);
            this.groupBox1.Controls.Add(this.lbl_oNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_ono);
            this.groupBox1.Controls.Add(this.cb_second);
            this.groupBox1.Controls.Add(this.cb_hour);
            this.groupBox1.Controls.Add(this.cb_min);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 181);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search(Choose Only One)";
            // 
            // cb_time_choose
            // 
            this.cb_time_choose.FormattingEnabled = true;
            this.cb_time_choose.Location = new System.Drawing.Point(87, 61);
            this.cb_time_choose.Name = "cb_time_choose";
            this.cb_time_choose.Size = new System.Drawing.Size(229, 21);
            this.cb_time_choose.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 55);
            this.button1.TabIndex = 15;
            this.button1.Text = "Select All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Reprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.lv_listFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reprint";
            this.Text = "Reprint";
            
            this.Load += new System.EventHandler(this.Reprint_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_oNo;
        private System.Windows.Forms.TextBox tb_ono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_hour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_min;
        private System.Windows.Forms.ComboBox cb_second;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lv_listFile;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_time_choose;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
    }
}
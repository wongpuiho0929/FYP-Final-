namespace Login
{
    partial class addMenuType
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.chk_null = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.combo_Category = new System.Windows.Forms.ComboBox();
            this.num_price = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_shortName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lab_History = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 578);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.chk_null);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.btn_cancel);
            this.tabPage1.Controls.Add(this.btn_save);
            this.tabPage1.Controls.Add(this.btn_category);
            this.tabPage1.Controls.Add(this.combo_Category);
            this.tabPage1.Controls.Add(this.num_price);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_shortName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_id);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_Name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(680, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.button2.Location = new System.Drawing.Point(500, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 48);
            this.button2.TabIndex = 75;
            this.button2.Text = "Food";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(212, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(212, 311);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 84);
            this.flowLayoutPanel1.TabIndex = 74;
            this.flowLayoutPanel1.Visible = false;
            this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic_Img_DragDrop);
            this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic_Img_DragEnter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.button1.Location = new System.Drawing.Point(462, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 73;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk_null
            // 
            this.chk_null.AutoSize = true;
            this.chk_null.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.chk_null.Location = new System.Drawing.Point(366, 211);
            this.chk_null.Name = "chk_null";
            this.chk_null.Size = new System.Drawing.Size(70, 32);
            this.chk_null.TabIndex = 71;
            this.chk_null.Text = "Null";
            this.chk_null.UseVisualStyleBackColor = true;
            this.chk_null.CheckedChanged += new System.EventHandler(this.chk_null_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.comboBox1.Location = new System.Drawing.Point(212, 457);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 36);
            this.comboBox1.TabIndex = 70;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btn_cancel.Location = new System.Drawing.Point(421, 505);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(141, 35);
            this.btn_cancel.TabIndex = 69;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btn_save.Location = new System.Drawing.Point(212, 505);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(141, 35);
            this.btn_save.TabIndex = 68;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_category
            // 
            this.btn_category.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.btn_category.Location = new System.Drawing.Point(462, 403);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(141, 35);
            this.btn_category.TabIndex = 67;
            this.btn_category.Text = "Menu Category";
            this.btn_category.UseVisualStyleBackColor = true;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // combo_Category
            // 
            this.combo_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Category.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.combo_Category.FormattingEnabled = true;
            this.combo_Category.Location = new System.Drawing.Point(212, 402);
            this.combo_Category.Name = "combo_Category";
            this.combo_Category.Size = new System.Drawing.Size(211, 36);
            this.combo_Category.TabIndex = 66;
            // 
            // num_price
            // 
            this.num_price.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.num_price.Location = new System.Drawing.Point(212, 210);
            this.num_price.Name = "num_price";
            this.num_price.Size = new System.Drawing.Size(120, 35);
            this.num_price.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label8.Location = new System.Drawing.Point(20, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 28);
            this.label8.TabIndex = 64;
            this.label8.Text = "Is Show:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label7.Location = new System.Drawing.Point(20, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 28);
            this.label7.TabIndex = 63;
            this.label7.Text = "Menu Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label6.Location = new System.Drawing.Point(20, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 28);
            this.label6.TabIndex = 62;
            this.label6.Text = "Menu Img:";
            // 
            // txt_shortName
            // 
            this.txt_shortName.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_shortName.Location = new System.Drawing.Point(212, 270);
            this.txt_shortName.Name = "txt_shortName";
            this.txt_shortName.Size = new System.Drawing.Size(444, 35);
            this.txt_shortName.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label5.Location = new System.Drawing.Point(20, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 28);
            this.label5.TabIndex = 60;
            this.label5.Text = "Menu Short Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.Location = new System.Drawing.Point(20, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 28);
            this.label4.TabIndex = 59;
            this.label4.Text = "Menu Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 58;
            this.label2.Text = "Menu Info:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_id.Location = new System.Drawing.Point(212, 70);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(444, 35);
            this.txt_id.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 54;
            this.label3.Text = "Menu ID:";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_Name.Location = new System.Drawing.Point(212, 139);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(444, 35);
            this.txt_Name.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(20, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 55;
            this.label1.Text = "Menu Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Back);
            this.tabPage2.Controls.Add(this.lab_History);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(680, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(550, 10);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(120, 36);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lab_History
            // 
            this.lab_History.AutoSize = true;
            this.lab_History.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lab_History.Location = new System.Drawing.Point(-1, 10);
            this.lab_History.Name = "lab_History";
            this.lab_History.Size = new System.Drawing.Size(50, 24);
            this.lab_History.TabIndex = 3;
            this.lab_History.Text = "Food";
            // 
            // addMenuType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "addMenuType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addMenuType";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addMenuType_FormClosed);
            this.Load += new System.EventHandler(this.addChange_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chk_null;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.ComboBox combo_Category;
        private System.Windows.Forms.NumericUpDown num_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_shortName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lab_History;
        private System.Windows.Forms.Button button2;


    }
}
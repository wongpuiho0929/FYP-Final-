namespace Login
{
    partial class addFood
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
            this.button1 = new System.Windows.Forms.Button();
            this.combo_ISShow = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.num_price = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_SPrice = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_shortName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.num_DQTY = new System.Windows.Forms.NumericUpDown();
            this.num_QTY = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.combo_FoodType = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lab_History = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_DQTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.button1.Location = new System.Drawing.Point(450, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 41;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo_ISShow
            // 
            this.combo_ISShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_ISShow.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.combo_ISShow.FormattingEnabled = true;
            this.combo_ISShow.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.combo_ISShow.Location = new System.Drawing.Point(200, 494);
            this.combo_ISShow.Name = "combo_ISShow";
            this.combo_ISShow.Size = new System.Drawing.Size(51, 36);
            this.combo_ISShow.TabIndex = 39;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btn_cancel.Location = new System.Drawing.Point(409, 542);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(141, 35);
            this.btn_cancel.TabIndex = 38;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btn_save.Location = new System.Drawing.Point(200, 542);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(141, 35);
            this.btn_save.TabIndex = 37;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_category
            // 
            this.btn_category.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.btn_category.Location = new System.Drawing.Point(450, 440);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(141, 35);
            this.btn_category.TabIndex = 36;
            this.btn_category.Text = "Food Type";
            this.btn_category.UseVisualStyleBackColor = true;
            // 
            // num_price
            // 
            this.num_price.DecimalPlaces = 1;
            this.num_price.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.num_price.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_price.Location = new System.Drawing.Point(206, 247);
            this.num_price.Name = "num_price";
            this.num_price.Size = new System.Drawing.Size(68, 35);
            this.num_price.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label8.Location = new System.Drawing.Point(8, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 28);
            this.label8.TabIndex = 32;
            this.label8.Text = "Is Show:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label7.Location = new System.Drawing.Point(8, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 28);
            this.label7.TabIndex = 31;
            this.label7.Text = "Food Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label6.Location = new System.Drawing.Point(8, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 28);
            this.label6.TabIndex = 30;
            this.label6.Text = "Food Img:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.Location = new System.Drawing.Point(14, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Food Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Food Info:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_id.Location = new System.Drawing.Point(206, 65);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(444, 35);
            this.txt_id.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Food ID:";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_Name.Location = new System.Drawing.Point(206, 122);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(444, 35);
            this.txt_Name.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(14, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Food Name:";
            // 
            // num_SPrice
            // 
            this.num_SPrice.DecimalPlaces = 1;
            this.num_SPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.num_SPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_SPrice.Location = new System.Drawing.Point(482, 247);
            this.num_SPrice.Name = "num_SPrice";
            this.num_SPrice.Size = new System.Drawing.Size(68, 35);
            this.num_SPrice.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label9.Location = new System.Drawing.Point(314, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 28);
            this.label9.TabIndex = 43;
            this.label9.Text = "Food Set Price:";
            // 
            // txt_shortName
            // 
            this.txt_shortName.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_shortName.Location = new System.Drawing.Point(206, 188);
            this.txt_shortName.Name = "txt_shortName";
            this.txt_shortName.Size = new System.Drawing.Size(444, 35);
            this.txt_shortName.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label5.Location = new System.Drawing.Point(14, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 28);
            this.label5.TabIndex = 44;
            this.label5.Text = "Food Short Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label10.Location = new System.Drawing.Point(314, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 28);
            this.label10.TabIndex = 49;
            this.label10.Text = "Default QTY";
            // 
            // num_DQTY
            // 
            this.num_DQTY.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.num_DQTY.Location = new System.Drawing.Point(482, 300);
            this.num_DQTY.Name = "num_DQTY";
            this.num_DQTY.Size = new System.Drawing.Size(68, 35);
            this.num_DQTY.TabIndex = 48;
            // 
            // num_QTY
            // 
            this.num_QTY.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.num_QTY.Location = new System.Drawing.Point(206, 300);
            this.num_QTY.Name = "num_QTY";
            this.num_QTY.Size = new System.Drawing.Size(68, 35);
            this.num_QTY.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label11.Location = new System.Drawing.Point(14, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 28);
            this.label11.TabIndex = 46;
            this.label11.Text = "QTY:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(203, 349);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 84);
            this.flowLayoutPanel1.TabIndex = 50;
            this.flowLayoutPanel1.Visible = false;
            this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic_Img_DragDrop);
            this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic_Img_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(206, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // combo_FoodType
            // 
            this.combo_FoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_FoodType.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.combo_FoodType.FormattingEnabled = true;
            this.combo_FoodType.Location = new System.Drawing.Point(200, 439);
            this.combo_FoodType.Name = "combo_FoodType";
            this.combo_FoodType.Size = new System.Drawing.Size(211, 36);
            this.combo_FoodType.TabIndex = 35;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 629);
            this.tabControl1.TabIndex = 51;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.txt_Name);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.num_DQTY);
            this.tabPage1.Controls.Add(this.txt_id);
            this.tabPage1.Controls.Add(this.num_QTY);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_shortName);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.num_price);
            this.tabPage1.Controls.Add(this.num_SPrice);
            this.tabPage1.Controls.Add(this.combo_FoodType);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btn_category);
            this.tabPage1.Controls.Add(this.combo_ISShow);
            this.tabPage1.Controls.Add(this.btn_save);
            this.tabPage1.Controls.Add(this.btn_cancel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Back);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.lab_History);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(563, 15);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(120, 36);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(665, 483);
            this.dataGridView1.TabIndex = 1;
            // 
            // lab_History
            // 
            this.lab_History.AutoSize = true;
            this.lab_History.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_History.Location = new System.Drawing.Point(12, 15);
            this.lab_History.Name = "lab_History";
            this.lab_History.Size = new System.Drawing.Size(103, 34);
            this.lab_History.TabIndex = 0;
            this.lab_History.Text = "History";
            // 
            // addFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 596);
            this.Controls.Add(this.tabControl1);
            this.Name = "addFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addFood";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addFood_FormClosed);
            this.Load += new System.EventHandler(this.addFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_DQTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combo_ISShow;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.NumericUpDown num_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_SPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_shortName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown num_DQTY;
        private System.Windows.Forms.NumericUpDown num_QTY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox combo_FoodType;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lab_History;
        private System.Windows.Forms.Button btn_Back;
    }
}
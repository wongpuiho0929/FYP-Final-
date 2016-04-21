namespace Login
{
    partial class GenXlsx
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addMenutype = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LinkMenuFood = new System.Windows.Forms.TabPage();
            this.Confirm = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectMenu = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.chkList_Menu = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.LinkMenuFood.SuspendLayout();
            this.Confirm.SuspendLayout();
            this.SelectMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btn_addMenutype
            // 
            this.btn_addMenutype.Location = new System.Drawing.Point(802, 13);
            this.btn_addMenutype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addMenutype.Name = "btn_addMenutype";
            this.btn_addMenutype.Size = new System.Drawing.Size(121, 51);
            this.btn_addMenutype.TabIndex = 11;
            this.btn_addMenutype.Text = "Add Menu Type";
            this.btn_addMenutype.UseVisualStyleBackColor = true;
            this.btn_addMenutype.Click += new System.EventHandler(this.btn_addMenutype_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(802, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.LinkMenuFood);
            this.tabControl1.Controls.Add(this.Confirm);
            this.tabControl1.Controls.Add(this.SelectMenu);
            this.tabControl1.Location = new System.Drawing.Point(-1, -27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 620);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // LinkMenuFood
            // 
            this.LinkMenuFood.AutoScroll = true;
            this.LinkMenuFood.Controls.Add(this.label1);
            this.LinkMenuFood.Controls.Add(this.button1);
            this.LinkMenuFood.Controls.Add(this.btn_addMenutype);
            this.LinkMenuFood.Location = new System.Drawing.Point(4, 25);
            this.LinkMenuFood.Name = "LinkMenuFood";
            this.LinkMenuFood.Padding = new System.Windows.Forms.Padding(3);
            this.LinkMenuFood.Size = new System.Drawing.Size(929, 591);
            this.LinkMenuFood.TabIndex = 0;
            this.LinkMenuFood.Text = "tabPage1";
            this.LinkMenuFood.UseVisualStyleBackColor = true;
            this.LinkMenuFood.Click += new System.EventHandler(this.LinkMenuFood_Click);
            // 
            // Confirm
            // 
            this.Confirm.AutoScroll = true;
            this.Confirm.Controls.Add(this.button2);
            this.Confirm.Controls.Add(this.tableLayoutPanel1);
            this.Confirm.Location = new System.Drawing.Point(4, 25);
            this.Confirm.Name = "Confirm";
            this.Confirm.Padding = new System.Windows.Forms.Padding(3);
            this.Confirm.Size = new System.Drawing.Size(929, 591);
            this.Confirm.TabIndex = 1;
            this.Confirm.Text = "tabPage2";
            this.Confirm.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(3, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(923, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SelectMenu
            // 
            this.SelectMenu.Controls.Add(this.label2);
            this.SelectMenu.Controls.Add(this.btn_Next);
            this.SelectMenu.Controls.Add(this.chkList_Menu);
            this.SelectMenu.Location = new System.Drawing.Point(4, 25);
            this.SelectMenu.Name = "SelectMenu";
            this.SelectMenu.Size = new System.Drawing.Size(929, 591);
            this.SelectMenu.TabIndex = 2;
            this.SelectMenu.Text = "tabPage1";
            this.SelectMenu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.2F);
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Menu in Database:";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(9, 524);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(917, 49);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // chkList_Menu
            // 
            this.chkList_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkList_Menu.FormattingEnabled = true;
            this.chkList_Menu.Location = new System.Drawing.Point(9, 54);
            this.chkList_Menu.Name = "chkList_Menu";
            this.chkList_Menu.Size = new System.Drawing.Size(917, 464);
            this.chkList_Menu.TabIndex = 0;
            // 
            // GenXlsx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(948, 605);
            this.Controls.Add(this.tabControl1);
            this.Name = "GenXlsx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenXlsx";
            this.Load += new System.EventHandler(this.GenXlsx_Load);
            this.tabControl1.ResumeLayout(false);
            this.LinkMenuFood.ResumeLayout(false);
            this.LinkMenuFood.PerformLayout();
            this.Confirm.ResumeLayout(false);
            this.SelectMenu.ResumeLayout(false);
            this.SelectMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addMenutype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LinkMenuFood;
        private System.Windows.Forms.TabPage Confirm;
        private System.Windows.Forms.TabPage SelectMenu;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.CheckedListBox chkList_Menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
    }
}
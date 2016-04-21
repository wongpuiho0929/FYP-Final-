namespace Login
{
    partial class MaintainCategory
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
            this.btn_addSave = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_maintain = new System.Windows.Forms.Button();
            this.txt_MCName = new System.Windows.Forms.TextBox();
            this.lab_MCName = new System.Windows.Forms.Label();
            this.txt_MCID = new System.Windows.Forms.TextBox();
            this.lab_MCID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addSave
            // 
            this.btn_addSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addSave.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_addSave.Location = new System.Drawing.Point(469, 477);
            this.btn_addSave.Name = "btn_addSave";
            this.btn_addSave.Size = new System.Drawing.Size(142, 79);
            this.btn_addSave.TabIndex = 37;
            this.btn_addSave.Text = "Save";
            this.btn_addSave.UseVisualStyleBackColor = true;
            this.btn_addSave.Visible = false;
            this.btn_addSave.Click += new System.EventHandler(this.btn_addSave_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_Save.Location = new System.Drawing.Point(469, 477);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(142, 79);
            this.btn_Save.TabIndex = 36;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_add.Location = new System.Drawing.Point(832, 377);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(142, 79);
            this.btn_add.TabIndex = 34;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_maintain
            // 
            this.btn_maintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maintain.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_maintain.Location = new System.Drawing.Point(832, 477);
            this.btn_maintain.Name = "btn_maintain";
            this.btn_maintain.Size = new System.Drawing.Size(142, 79);
            this.btn_maintain.TabIndex = 35;
            this.btn_maintain.Text = "Maintain";
            this.btn_maintain.UseVisualStyleBackColor = true;
            this.btn_maintain.Click += new System.EventHandler(this.btn_maintain_Click);
            // 
            // txt_MCName
            // 
            this.txt_MCName.Enabled = false;
            this.txt_MCName.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txt_MCName.Location = new System.Drawing.Point(197, 425);
            this.txt_MCName.Name = "txt_MCName";
            this.txt_MCName.Size = new System.Drawing.Size(594, 31);
            this.txt_MCName.TabIndex = 33;
            // 
            // lab_MCName
            // 
            this.lab_MCName.AutoSize = true;
            this.lab_MCName.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lab_MCName.Location = new System.Drawing.Point(193, 402);
            this.lab_MCName.Name = "lab_MCName";
            this.lab_MCName.Size = new System.Drawing.Size(187, 24);
            this.lab_MCName.TabIndex = 32;
            this.lab_MCName.Text = "Menu Category Name:";
            // 
            // txt_MCID
            // 
            this.txt_MCID.Enabled = false;
            this.txt_MCID.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txt_MCID.Location = new System.Drawing.Point(16, 425);
            this.txt_MCID.Name = "txt_MCID";
            this.txt_MCID.Size = new System.Drawing.Size(158, 31);
            this.txt_MCID.TabIndex = 31;
            // 
            // lab_MCID
            // 
            this.lab_MCID.AutoSize = true;
            this.lab_MCID.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lab_MCID.Location = new System.Drawing.Point(12, 402);
            this.lab_MCID.Name = "lab_MCID";
            this.lab_MCID.Size = new System.Drawing.Size(162, 24);
            this.lab_MCID.TabIndex = 30;
            this.lab_MCID.Text = "Menu Category ID:";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 374);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.comboBox1.Location = new System.Drawing.Point(16, 508);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 32);
            this.comboBox1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label1.Location = new System.Drawing.Point(12, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Is Show:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_Cancel.Location = new System.Drawing.Point(649, 477);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(142, 79);
            this.btn_Cancel.TabIndex = 40;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // MaintainCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1008, 568);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_addSave);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_maintain);
            this.Controls.Add(this.txt_MCName);
            this.Controls.Add(this.lab_MCName);
            this.Controls.Add(this.txt_MCID);
            this.Controls.Add(this.lab_MCID);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MaintainCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MaintainCategory";
            this.Load += new System.EventHandler(this.MaintainCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addSave;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_maintain;
        private System.Windows.Forms.TextBox txt_MCName;
        private System.Windows.Forms.Label lab_MCName;
        private System.Windows.Forms.TextBox txt_MCID;
        private System.Windows.Forms.Label lab_MCID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancel;
    }
}
namespace Login
{
    partial class FoodType
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_FtName = new System.Windows.Forms.TextBox();
            this.lab_FtName = new System.Windows.Forms.Label();
            this.txt_FtID = new System.Windows.Forms.TextBox();
            this.lab_FtID = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_maintain = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_addSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(1020, 374);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txt_FtName
            // 
            this.txt_FtName.Enabled = false;
            this.txt_FtName.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txt_FtName.Location = new System.Drawing.Point(197, 428);
            this.txt_FtName.Name = "txt_FtName";
            this.txt_FtName.Size = new System.Drawing.Size(594, 31);
            this.txt_FtName.TabIndex = 10;
            // 
            // lab_FtName
            // 
            this.lab_FtName.AutoSize = true;
            this.lab_FtName.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lab_FtName.Location = new System.Drawing.Point(193, 405);
            this.lab_FtName.Name = "lab_FtName";
            this.lab_FtName.Size = new System.Drawing.Size(151, 24);
            this.lab_FtName.TabIndex = 9;
            this.lab_FtName.Text = "Food Type Name:";
            // 
            // txt_FtID
            // 
            this.txt_FtID.Enabled = false;
            this.txt_FtID.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txt_FtID.Location = new System.Drawing.Point(16, 428);
            this.txt_FtID.Name = "txt_FtID";
            this.txt_FtID.Size = new System.Drawing.Size(140, 31);
            this.txt_FtID.TabIndex = 8;
            // 
            // lab_FtID
            // 
            this.lab_FtID.AutoSize = true;
            this.lab_FtID.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lab_FtID.Location = new System.Drawing.Point(12, 405);
            this.lab_FtID.Name = "lab_FtID";
            this.lab_FtID.Size = new System.Drawing.Size(126, 24);
            this.lab_FtID.TabIndex = 7;
            this.lab_FtID.Text = "Food Type ID:";
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_add.Location = new System.Drawing.Point(866, 380);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(142, 79);
            this.btn_add.TabIndex = 25;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_maintain
            // 
            this.btn_maintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maintain.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_maintain.Location = new System.Drawing.Point(866, 495);
            this.btn_maintain.Name = "btn_maintain";
            this.btn_maintain.Size = new System.Drawing.Size(142, 79);
            this.btn_maintain.TabIndex = 26;
            this.btn_maintain.Text = "Maintain";
            this.btn_maintain.UseVisualStyleBackColor = true;
            this.btn_maintain.Click += new System.EventHandler(this.btn_maintain_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_Save.Location = new System.Drawing.Point(649, 495);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(142, 79);
            this.btn_Save.TabIndex = 27;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_addSave
            // 
            this.btn_addSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addSave.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_addSave.Location = new System.Drawing.Point(649, 495);
            this.btn_addSave.Name = "btn_addSave";
            this.btn_addSave.Size = new System.Drawing.Size(142, 79);
            this.btn_addSave.TabIndex = 28;
            this.btn_addSave.Text = "Save";
            this.btn_addSave.UseVisualStyleBackColor = true;
            this.btn_addSave.Visible = false;
            this.btn_addSave.Click += new System.EventHandler(this.btn_addSave_Click);
            // 
            // FoodType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1020, 580);
            this.Controls.Add(this.btn_addSave);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_maintain);
            this.Controls.Add(this.txt_FtName);
            this.Controls.Add(this.lab_FtName);
            this.Controls.Add(this.txt_FtID);
            this.Controls.Add(this.lab_FtID);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FoodType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FoodType";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FoodType_FormClosing);
            this.Load += new System.EventHandler(this.FoodType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_FtName;
        private System.Windows.Forms.Label lab_FtName;
        private System.Windows.Forms.TextBox txt_FtID;
        private System.Windows.Forms.Label lab_FtID;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_maintain;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_addSave;
    }
}
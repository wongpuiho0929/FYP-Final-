namespace Login
{
    partial class SetTime
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_Start = new System.Windows.Forms.ComboBox();
            this.combo_End = new System.Windows.Forms.ComboBox();
            this.lab_Quota = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.button1.Location = new System.Drawing.Point(85, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chagne";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label2.Location = new System.Drawing.Point(46, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label3.Location = new System.Drawing.Point(61, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Time:";
            // 
            // combo_Start
            // 
            this.combo_Start.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Start.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.combo_Start.FormattingEnabled = true;
            this.combo_Start.Location = new System.Drawing.Point(172, 47);
            this.combo_Start.Name = "combo_Start";
            this.combo_Start.Size = new System.Drawing.Size(173, 32);
            this.combo_Start.TabIndex = 4;
            this.combo_Start.SelectedIndexChanged += new System.EventHandler(this.combo_Start_SelectedIndexChanged);
            // 
            // combo_End
            // 
            this.combo_End.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_End.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.combo_End.FormattingEnabled = true;
            this.combo_End.Location = new System.Drawing.Point(171, 110);
            this.combo_End.Name = "combo_End";
            this.combo_End.Size = new System.Drawing.Size(174, 32);
            this.combo_End.TabIndex = 5;
            // 
            // lab_Quota
            // 
            this.lab_Quota.AutoSize = true;
            this.lab_Quota.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lab_Quota.Location = new System.Drawing.Point(61, 174);
            this.lab_Quota.Name = "lab_Quota";
            this.lab_Quota.Size = new System.Drawing.Size(66, 24);
            this.lab_Quota.TabIndex = 6;
            this.lab_Quota.Text = "Quota:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 25);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SetTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 340);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lab_Quota);
            this.Controls.Add(this.combo_End);
            this.Controls.Add(this.combo_Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "SetTime";
            this.Text = "SetTime";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetTime_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetTime_FormClosed);
            this.Load += new System.EventHandler(this.SetTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_Start;
        private System.Windows.Forms.ComboBox combo_End;
        private System.Windows.Forms.Label lab_Quota;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
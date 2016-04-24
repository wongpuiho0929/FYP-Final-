namespace Login
{
    partial class GroupCountView
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
            this.gb_type = new System.Windows.Forms.GroupBox();
            this.gb_time = new System.Windows.Forms.GroupBox();
            this.btn_GrpPrint = new System.Windows.Forms.Button();
            this.FLP2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.gb_time.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.gb_type);
            this.panel1.Controls.Add(this.gb_time);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1094, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 674);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gb_type
            // 
            this.gb_type.Location = new System.Drawing.Point(6, 227);
            this.gb_type.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_type.Name = "gb_type";
            this.gb_type.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_type.Size = new System.Drawing.Size(267, 115);
            this.gb_type.TabIndex = 2;
            this.gb_type.TabStop = false;
            this.gb_type.Text = "Type";
            // 
            // gb_time
            // 
            this.gb_time.Controls.Add(this.btn_GrpPrint);
            this.gb_time.Location = new System.Drawing.Point(6, 58);
            this.gb_time.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_time.Name = "gb_time";
            this.gb_time.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_time.Size = new System.Drawing.Size(267, 115);
            this.gb_time.TabIndex = 1;
            this.gb_time.TabStop = false;
            this.gb_time.Text = "Time";
            // 
            // btn_GrpPrint
            // 
            this.btn_GrpPrint.Location = new System.Drawing.Point(185, 22);
            this.btn_GrpPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_GrpPrint.Name = "btn_GrpPrint";
            this.btn_GrpPrint.Size = new System.Drawing.Size(81, 74);
            this.btn_GrpPrint.TabIndex = 0;
            this.btn_GrpPrint.Text = "Quick Group by time Print";
            this.btn_GrpPrint.UseVisualStyleBackColor = true;
            // 
            // FLP2
            // 
            this.FLP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP2.Location = new System.Drawing.Point(0, 0);
            this.FLP2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FLP2.Name = "FLP2";
            this.FLP2.Size = new System.Drawing.Size(1094, 674);
            this.FLP2.TabIndex = 3;
            // 
            // GroupCountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 674);
            this.Controls.Add(this.FLP2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GroupCountView";
            this.Text = "Group Count Viewer";
            this.Load += new System.EventHandler(this.GroupCountView_Load);
            this.panel1.ResumeLayout(false);
            this.gb_time.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_type;
        private System.Windows.Forms.GroupBox gb_time;
        private System.Windows.Forms.Button btn_GrpPrint;
        private System.Windows.Forms.FlowLayoutPanel FLP2;
    }
}
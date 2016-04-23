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
            this.FLP2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gb_fiter = new System.Windows.Forms.GroupBox();
            this.gb_time = new System.Windows.Forms.GroupBox();
            this.gb_type = new System.Windows.Forms.GroupBox();
            this.gb_fiter.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLP2
            // 
            this.FLP2.Location = new System.Drawing.Point(12, 22);
            this.FLP2.Name = "FLP2";
            this.FLP2.Size = new System.Drawing.Size(738, 466);
            this.FLP2.TabIndex = 0;
            // 
            // gb_fiter
            // 
            this.gb_fiter.Controls.Add(this.gb_type);
            this.gb_fiter.Controls.Add(this.gb_time);
            this.gb_fiter.Location = new System.Drawing.Point(787, 22);
            this.gb_fiter.Name = "gb_fiter";
            this.gb_fiter.Size = new System.Drawing.Size(200, 466);
            this.gb_fiter.TabIndex = 1;
            this.gb_fiter.TabStop = false;
            this.gb_fiter.Text = "Fiter";
            // 
            // gb_time
            // 
            this.gb_time.Location = new System.Drawing.Point(6, 28);
            this.gb_time.Name = "gb_time";
            this.gb_time.Size = new System.Drawing.Size(200, 100);
            this.gb_time.TabIndex = 0;
            this.gb_time.TabStop = false;
            this.gb_time.Text = "Time";
            // 
            // gb_type
            // 
            this.gb_type.Location = new System.Drawing.Point(26, 174);
            this.gb_type.Name = "gb_type";
            this.gb_type.Size = new System.Drawing.Size(200, 100);
            this.gb_type.TabIndex = 0;
            this.gb_type.TabStop = false;
            this.gb_type.Text = "Type";
            // 
            // GroupCountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 584);
            this.Controls.Add(this.gb_fiter);
            this.Controls.Add(this.FLP2);
            this.Name = "GroupCountView";
            this.Text = "Group Count Viewer";
            this.Load += new System.EventHandler(this.GroupCountView_Load);
            this.gb_fiter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLP2;
        private System.Windows.Forms.GroupBox gb_fiter;
        private System.Windows.Forms.GroupBox gb_time;
        private System.Windows.Forms.GroupBox gb_type;
    }
}
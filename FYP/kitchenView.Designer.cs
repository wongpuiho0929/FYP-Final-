namespace Login
{
    partial class kitchenView
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
            this.gb_OrderStatus = new System.Windows.Forms.GroupBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.gbFunction = new System.Windows.Forms.GroupBox();
            this.btn_quickPrint = new System.Windows.Forms.Button();
            this.btn_TimeClear = new System.Windows.Forms.Button();
            this.gb_foobType = new System.Windows.Forms.GroupBox();
            this.gb_Information = new System.Windows.Forms.GroupBox();
            this.lbl_tov = new System.Windows.Forms.Label();
            this.FLP1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FLP2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_OrderStatus.SuspendLayout();
            this.gbFunction.SuspendLayout();
            this.gb_Information.SuspendLayout();
            this.FLP1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_OrderStatus
            // 
            this.gb_OrderStatus.Controls.Add(this.btn_print);
            this.gb_OrderStatus.Location = new System.Drawing.Point(4, 605);
            this.gb_OrderStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_OrderStatus.Name = "gb_OrderStatus";
            this.gb_OrderStatus.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_OrderStatus.Size = new System.Drawing.Size(267, 115);
            this.gb_OrderStatus.TabIndex = 5;
            this.gb_OrderStatus.TabStop = false;
            this.gb_OrderStatus.Text = "Print";
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(5, 15);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(191, 93);
            this.btn_print.TabIndex = 0;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // gbFunction
            // 
            this.gbFunction.Controls.Add(this.btn_quickPrint);
            this.gbFunction.Controls.Add(this.btn_TimeClear);
            this.gbFunction.Location = new System.Drawing.Point(4, 158);
            this.gbFunction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFunction.Name = "gbFunction";
            this.gbFunction.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFunction.Size = new System.Drawing.Size(184, 279);
            this.gbFunction.TabIndex = 1;
            this.gbFunction.TabStop = false;
            this.gbFunction.Text = "Take Time";
            // 
            // btn_quickPrint
            // 
            this.btn_quickPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quickPrint.Location = new System.Drawing.Point(95, 185);
            this.btn_quickPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_quickPrint.Name = "btn_quickPrint";
            this.btn_quickPrint.Size = new System.Drawing.Size(100, 77);
            this.btn_quickPrint.TabIndex = 1;
            this.btn_quickPrint.Text = "Quick Group by time Print";
            this.btn_quickPrint.UseVisualStyleBackColor = true;
            this.btn_quickPrint.Click += new System.EventHandler(this.btn_quickPrint_Click);
            // 
            // btn_TimeClear
            // 
            this.btn_TimeClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimeClear.Location = new System.Drawing.Point(95, 22);
            this.btn_TimeClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_TimeClear.Name = "btn_TimeClear";
            this.btn_TimeClear.Size = new System.Drawing.Size(79, 99);
            this.btn_TimeClear.TabIndex = 0;
            this.btn_TimeClear.Text = "Clear time";
            this.btn_TimeClear.UseVisualStyleBackColor = true;
            this.btn_TimeClear.Click += new System.EventHandler(this.btn_TimeClear_Click);
            // 
            // gb_foobType
            // 
            this.gb_foobType.Location = new System.Drawing.Point(18, 444);
            this.gb_foobType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_foobType.Name = "gb_foobType";
            this.gb_foobType.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_foobType.Size = new System.Drawing.Size(183, 167);
            this.gb_foobType.TabIndex = 4;
            this.gb_foobType.TabStop = false;
            this.gb_foobType.Text = "Food Type";
            // 
            // gb_Information
            // 
            this.gb_Information.Controls.Add(this.lbl_tov);
            this.gb_Information.Location = new System.Drawing.Point(4, 18);
            this.gb_Information.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Information.Name = "gb_Information";
            this.gb_Information.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Information.Size = new System.Drawing.Size(183, 120);
            this.gb_Information.TabIndex = 3;
            this.gb_Information.TabStop = false;
            this.gb_Information.Text = "Information";
            // 
            // lbl_tov
            // 
            this.lbl_tov.AutoSize = true;
            this.lbl_tov.Location = new System.Drawing.Point(9, 23);
            this.lbl_tov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tov.Name = "lbl_tov";
            this.lbl_tov.Size = new System.Drawing.Size(115, 15);
            this.lbl_tov.TabIndex = 0;
            this.lbl_tov.Text = "Total Order Value:";
            // 
            // FLP1
            // 
            this.FLP1.AutoScroll = true;
            this.FLP1.Controls.Add(this.FLP2);
            this.FLP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FLP1.Location = new System.Drawing.Point(16, 15);
            this.FLP1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FLP1.Name = "FLP1";
            this.FLP1.Size = new System.Drawing.Size(980, 564);
            this.FLP1.TabIndex = 2;
            // 
            // FLP2
            // 
            this.FLP2.AutoScroll = true;
            this.FLP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FLP2.Location = new System.Drawing.Point(4, 3);
            this.FLP2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FLP2.Name = "FLP2";
            this.FLP2.Size = new System.Drawing.Size(980, 564);
            this.FLP2.TabIndex = 3;
            this.FLP2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.gb_OrderStatus);
            this.panel1.Controls.Add(this.gb_Information);
            this.panel1.Controls.Add(this.gbFunction);
            this.panel1.Controls.Add(this.gb_foobType);
            this.panel1.Location = new System.Drawing.Point(1707, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 759);
            this.panel1.TabIndex = 3;
            // 
            // kitchenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1932, 918);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FLP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "kitchenView";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.kitchenView_Load);
            this.gb_OrderStatus.ResumeLayout(false);
            this.gbFunction.ResumeLayout(false);
            this.gb_Information.ResumeLayout(false);
            this.gb_Information.PerformLayout();
            this.FLP1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLP1;
        private System.Windows.Forms.GroupBox gb_Information;
        private System.Windows.Forms.Label lbl_tov;
        private System.Windows.Forms.GroupBox gb_foobType;
        private System.Windows.Forms.GroupBox gb_OrderStatus;
        private System.Windows.Forms.GroupBox gbFunction;
        private System.Windows.Forms.FlowLayoutPanel FLP2;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_TimeClear;
        private System.Windows.Forms.Button btn_quickPrint;
        private System.Windows.Forms.Panel panel1;
    }
}
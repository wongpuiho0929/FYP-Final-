namespace Login
{
    partial class viewOrderDetail
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
            this.lbl_orderId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxId = new System.Windows.Forms.TextBox();
            this.FinishOrder = new System.Windows.Forms.Button();
            this.lblPrinting = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_orderId
            // 
            this.lbl_orderId.AutoSize = true;
            this.lbl_orderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderId.Location = new System.Drawing.Point(12, 35);
            this.lbl_orderId.Name = "lbl_orderId";
            this.lbl_orderId.Size = new System.Drawing.Size(128, 31);
            this.lbl_orderId.TabIndex = 0;
            this.lbl_orderId.Text = "Order-ID:";
            this.lbl_orderId.Click += new System.EventHandler(this.lbl_orderId_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // txtboxId
            // 
            this.txtboxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxId.Location = new System.Drawing.Point(138, 32);
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.ReadOnly = true;
            this.txtboxId.Size = new System.Drawing.Size(220, 38);
            this.txtboxId.TabIndex = 2;
            // 
            // FinishOrder
            // 
            this.FinishOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishOrder.Location = new System.Drawing.Point(39, 317);
            this.FinishOrder.Name = "FinishOrder";
            this.FinishOrder.Size = new System.Drawing.Size(319, 99);
            this.FinishOrder.TabIndex = 3;
            this.FinishOrder.Text = "Re-Print";
            this.FinishOrder.UseVisualStyleBackColor = true;
            // 
            // lblPrinting
            // 
            this.lblPrinting.AutoSize = true;
            this.lblPrinting.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinting.Location = new System.Drawing.Point(12, 82);
            this.lblPrinting.Name = "lblPrinting";
            this.lblPrinting.Size = new System.Drawing.Size(114, 31);
            this.lblPrinting.TabIndex = 4;
            this.lblPrinting.Text = "Printing:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(138, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(220, 38);
            this.textBox1.TabIndex = 5;
            // 
            // viewOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(411, 471);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPrinting);
            this.Controls.Add(this.FinishOrder);
            this.Controls.Add(this.txtboxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_orderId);
            this.Name = "viewOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewOrderDetail";
            this.Load += new System.EventHandler(this.viewOrderDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_orderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxId;
        private System.Windows.Forms.Button FinishOrder;
        private System.Windows.Forms.Label lblPrinting;
        private System.Windows.Forms.TextBox textBox1;
    }
}
namespace InvoiceTotal_4_2_Enhanced
{
    partial class frmInvoiceTotal
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
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNumberOfInvoices = new System.Windows.Forms.Label();
            this.lblTotalOfInvoices = new System.Windows.Forms.Label();
            this.lblInvoiceAverage = new System.Windows.Forms.Label();
            this.txtNumberOfInvoices = new System.Windows.Forms.TextBox();
            this.txtTotalOfInvoices = new System.Windows.Forms.TextBox();
            this.txtInvoiceAverage = new System.Windows.Forms.TextBox();
            this.btnClearTotals = new System.Windows.Forms.Button();
            this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
            this.lblEnterSubtotal = new System.Windows.Forms.Label();
            this.lblLargestInvoice = new System.Windows.Forms.Label();
            this.lblSmallestInvoice = new System.Windows.Forms.Label();
            this.txtLargestInvoice = new System.Windows.Forms.TextBox();
            this.txtSmallestInvoice = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(8, 65);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Location = new System.Drawing.Point(7, 94);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(92, 13);
            this.lblDiscountPercent.TabIndex = 7;
            this.lblDiscountPercent.Text = "Discount Percent:";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Location = new System.Drawing.Point(8, 126);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(91, 13);
            this.lblDiscountAmount.TabIndex = 9;
            this.lblDiscountAmount.Text = "Discount Amount:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(7, 149);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(105, 61);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TabStop = false;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(105, 94);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountPercent.TabIndex = 8;
            this.txtDiscountPercent.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(105, 123);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountAmount.TabIndex = 10;
            this.txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(105, 149);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(276, 206);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(488, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNumberOfInvoices
            // 
            this.lblNumberOfInvoices.AutoSize = true;
            this.lblNumberOfInvoices.Location = new System.Drawing.Point(250, 68);
            this.lblNumberOfInvoices.Name = "lblNumberOfInvoices";
            this.lblNumberOfInvoices.Size = new System.Drawing.Size(101, 13);
            this.lblNumberOfInvoices.TabIndex = 2;
            this.lblNumberOfInvoices.Text = "Number of invoices:";
            // 
            // lblTotalOfInvoices
            // 
            this.lblTotalOfInvoices.AutoSize = true;
            this.lblTotalOfInvoices.Location = new System.Drawing.Point(250, 101);
            this.lblTotalOfInvoices.Name = "lblTotalOfInvoices";
            this.lblTotalOfInvoices.Size = new System.Drawing.Size(88, 13);
            this.lblTotalOfInvoices.TabIndex = 13;
            this.lblTotalOfInvoices.Text = "Total of invoices:";
            // 
            // lblInvoiceAverage
            // 
            this.lblInvoiceAverage.AutoSize = true;
            this.lblInvoiceAverage.Location = new System.Drawing.Point(250, 134);
            this.lblInvoiceAverage.Name = "lblInvoiceAverage";
            this.lblInvoiceAverage.Size = new System.Drawing.Size(87, 13);
            this.lblInvoiceAverage.TabIndex = 15;
            this.lblInvoiceAverage.Text = "Invoice average:";
            // 
            // txtNumberOfInvoices
            // 
            this.txtNumberOfInvoices.Location = new System.Drawing.Point(356, 65);
            this.txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            this.txtNumberOfInvoices.ReadOnly = true;
            this.txtNumberOfInvoices.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfInvoices.TabIndex = 3;
            this.txtNumberOfInvoices.TabStop = false;
            // 
            // txtTotalOfInvoices
            // 
            this.txtTotalOfInvoices.Location = new System.Drawing.Point(356, 98);
            this.txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            this.txtTotalOfInvoices.ReadOnly = true;
            this.txtTotalOfInvoices.Size = new System.Drawing.Size(100, 20);
            this.txtTotalOfInvoices.TabIndex = 14;
            this.txtTotalOfInvoices.TabStop = false;
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.Location = new System.Drawing.Point(356, 127);
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.ReadOnly = true;
            this.txtInvoiceAverage.Size = new System.Drawing.Size(100, 20);
            this.txtInvoiceAverage.TabIndex = 16;
            this.txtInvoiceAverage.TabStop = false;
            // 
            // btnClearTotals
            // 
            this.btnClearTotals.Location = new System.Drawing.Point(381, 206);
            this.btnClearTotals.Name = "btnClearTotals";
            this.btnClearTotals.Size = new System.Drawing.Size(75, 23);
            this.btnClearTotals.TabIndex = 5;
            this.btnClearTotals.Text = "Clear Totals";
            this.btnClearTotals.UseVisualStyleBackColor = true;
            this.btnClearTotals.Click += new System.EventHandler(this.btnClearTotals_Click);
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.Enabled = false;
            this.txtEnterSubtotal.Location = new System.Drawing.Point(105, 35);
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            this.txtEnterSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtEnterSubtotal.TabIndex = 1;
            // 
            // lblEnterSubtotal
            // 
            this.lblEnterSubtotal.AutoSize = true;
            this.lblEnterSubtotal.Enabled = false;
            this.lblEnterSubtotal.Location = new System.Drawing.Point(8, 35);
            this.lblEnterSubtotal.Name = "lblEnterSubtotal";
            this.lblEnterSubtotal.Size = new System.Drawing.Size(77, 13);
            this.lblEnterSubtotal.TabIndex = 0;
            this.lblEnterSubtotal.Text = "Enter Subtotal:";
            // 
            // lblLargestInvoice
            // 
            this.lblLargestInvoice.AutoSize = true;
            this.lblLargestInvoice.Location = new System.Drawing.Point(476, 72);
            this.lblLargestInvoice.Name = "lblLargestInvoice";
            this.lblLargestInvoice.Size = new System.Drawing.Size(83, 13);
            this.lblLargestInvoice.TabIndex = 17;
            this.lblLargestInvoice.Text = "Largest Invoice:";
            // 
            // lblSmallestInvoice
            // 
            this.lblSmallestInvoice.AutoSize = true;
            this.lblSmallestInvoice.Location = new System.Drawing.Point(476, 101);
            this.lblSmallestInvoice.Name = "lblSmallestInvoice";
            this.lblSmallestInvoice.Size = new System.Drawing.Size(87, 13);
            this.lblSmallestInvoice.TabIndex = 18;
            this.lblSmallestInvoice.Text = "Smallest Invoice:";
            // 
            // txtLargestInvoice
            // 
            this.txtLargestInvoice.Location = new System.Drawing.Point(571, 69);
            this.txtLargestInvoice.Name = "txtLargestInvoice";
            this.txtLargestInvoice.ReadOnly = true;
            this.txtLargestInvoice.Size = new System.Drawing.Size(100, 20);
            this.txtLargestInvoice.TabIndex = 19;
            this.txtLargestInvoice.TabStop = false;
            // 
            // txtSmallestInvoice
            // 
            this.txtSmallestInvoice.Location = new System.Drawing.Point(571, 98);
            this.txtSmallestInvoice.Name = "txtSmallestInvoice";
            this.txtSmallestInvoice.ReadOnly = true;
            this.txtSmallestInvoice.Size = new System.Drawing.Size(100, 20);
            this.txtSmallestInvoice.TabIndex = 20;
            this.txtSmallestInvoice.TabStop = false;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(8, 14);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(66, 13);
            this.lblEnterName.TabIndex = 0;
            this.lblEnterName.Text = "Enter Name:";
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(105, 9);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(100, 20);
            this.txtEnterName.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(224, 9);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmInvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(683, 259);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtSmallestInvoice);
            this.Controls.Add(this.txtLargestInvoice);
            this.Controls.Add(this.lblSmallestInvoice);
            this.Controls.Add(this.lblLargestInvoice);
            this.Controls.Add(this.lblEnterSubtotal);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.btnClearTotals);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.txtTotalOfInvoices);
            this.Controls.Add(this.txtNumberOfInvoices);
            this.Controls.Add(this.lblInvoiceAverage);
            this.Controls.Add(this.lblTotalOfInvoices);
            this.Controls.Add(this.lblNumberOfInvoices);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.lblSubtotal);
            this.Name = "frmInvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNumberOfInvoices;
        private System.Windows.Forms.Label lblTotalOfInvoices;
        private System.Windows.Forms.Label lblInvoiceAverage;
        private System.Windows.Forms.TextBox txtNumberOfInvoices;
        private System.Windows.Forms.TextBox txtTotalOfInvoices;
        private System.Windows.Forms.TextBox txtInvoiceAverage;
        private System.Windows.Forms.Button btnClearTotals;
        private System.Windows.Forms.TextBox txtEnterSubtotal;
        private System.Windows.Forms.Label lblEnterSubtotal;
        private System.Windows.Forms.Label lblLargestInvoice;
        private System.Windows.Forms.Label lblSmallestInvoice;
        private System.Windows.Forms.TextBox txtLargestInvoice;
        private System.Windows.Forms.TextBox txtSmallestInvoice;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Button btnOK;
    }
}


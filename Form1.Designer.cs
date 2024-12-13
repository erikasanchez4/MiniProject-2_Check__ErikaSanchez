namespace MiniProject_2_Check__ErikaSanchez
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstbxItems = new ListBox();
            lblItemsOrdered = new Label();
            lblSubTotal = new Label();
            lblTaxDue = new Label();
            lblTipAmount = new Label();
            lblTotalDue = new Label();
            txtSubTotal = new TextBox();
            txtTipAmount = new TextBox();
            txtTotalDue = new TextBox();
            cmbTip = new ComboBox();
            lblSelectTip = new Label();
            gbPayment = new GroupBox();
            rbtnOther = new RadioButton();
            rbtnCreditCard = new RadioButton();
            rbtnATHMovil = new RadioButton();
            rbtnCash = new RadioButton();
            btnGetOrderItems = new Button();
            btnCalculateTotals = new Button();
            txtTaxDue = new TextBox();
            btnExit = new Button();
            gbPayment.SuspendLayout();
            SuspendLayout();
            // 
            // lstbxItems
            // 
            lstbxItems.FormattingEnabled = true;
            lstbxItems.Location = new Point(21, 58);
            lstbxItems.Name = "lstbxItems";
            lstbxItems.Size = new Size(257, 384);
            lstbxItems.TabIndex = 0;
            // 
            // lblItemsOrdered
            // 
            lblItemsOrdered.AutoSize = true;
            lblItemsOrdered.BorderStyle = BorderStyle.Fixed3D;
            lblItemsOrdered.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemsOrdered.Location = new Point(82, 30);
            lblItemsOrdered.Name = "lblItemsOrdered";
            lblItemsOrdered.Size = new Size(128, 25);
            lblItemsOrdered.TabIndex = 1;
            lblItemsOrdered.Text = "Items Ordered";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.BorderStyle = BorderStyle.Fixed3D;
            lblSubTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new Point(309, 69);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(124, 25);
            lblSubTotal.TabIndex = 2;
            lblSubTotal.Text = "      Sub-Total:";
            // 
            // lblTaxDue
            // 
            lblTaxDue.AutoSize = true;
            lblTaxDue.BorderStyle = BorderStyle.Fixed3D;
            lblTaxDue.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaxDue.Location = new Point(307, 116);
            lblTaxDue.Name = "lblTaxDue";
            lblTaxDue.Size = new Size(126, 25);
            lblTaxDue.TabIndex = 3;
            lblTaxDue.Text = "         Tax Due:";
            // 
            // lblTipAmount
            // 
            lblTipAmount.AutoSize = true;
            lblTipAmount.BorderStyle = BorderStyle.Fixed3D;
            lblTipAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipAmount.Location = new Point(305, 211);
            lblTipAmount.Name = "lblTipAmount";
            lblTipAmount.Size = new Size(128, 25);
            lblTipAmount.TabIndex = 5;
            lblTipAmount.Text = "   Tip Amount:";
            // 
            // lblTotalDue
            // 
            lblTotalDue.AutoSize = true;
            lblTotalDue.BorderStyle = BorderStyle.Fixed3D;
            lblTotalDue.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDue.Location = new Point(305, 258);
            lblTotalDue.Name = "lblTotalDue";
            lblTotalDue.Size = new Size(128, 25);
            lblTotalDue.TabIndex = 6;
            lblTotalDue.Text = "       Total Due:";
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = SystemColors.Control;
            txtSubTotal.Location = new Point(453, 67);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(125, 27);
            txtSubTotal.TabIndex = 7;
            // 
            // txtTipAmount
            // 
            txtTipAmount.Location = new Point(453, 211);
            txtTipAmount.Name = "txtTipAmount";
            txtTipAmount.ReadOnly = true;
            txtTipAmount.Size = new Size(125, 27);
            txtTipAmount.TabIndex = 9;
            // 
            // txtTotalDue
            // 
            txtTotalDue.Location = new Point(453, 256);
            txtTotalDue.Name = "txtTotalDue";
            txtTotalDue.ReadOnly = true;
            txtTotalDue.Size = new Size(125, 27);
            txtTotalDue.TabIndex = 10;
            // 
            // cmbTip
            // 
            cmbTip.FormattingEnabled = true;
            cmbTip.Location = new Point(453, 161);
            cmbTip.Name = "cmbTip";
            cmbTip.Size = new Size(125, 28);
            cmbTip.TabIndex = 11;
            // 
            // lblSelectTip
            // 
            lblSelectTip.AutoSize = true;
            lblSelectTip.BorderStyle = BorderStyle.Fixed3D;
            lblSelectTip.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectTip.Location = new Point(307, 164);
            lblSelectTip.Name = "lblSelectTip";
            lblSelectTip.Size = new Size(126, 25);
            lblSelectTip.TabIndex = 12;
            lblSelectTip.Text = "      Select Tip:";
            // 
            // gbPayment
            // 
            gbPayment.BackColor = SystemColors.ScrollBar;
            gbPayment.Controls.Add(rbtnOther);
            gbPayment.Controls.Add(rbtnCreditCard);
            gbPayment.Controls.Add(rbtnATHMovil);
            gbPayment.Controls.Add(rbtnCash);
            gbPayment.Location = new Point(297, 297);
            gbPayment.Name = "gbPayment";
            gbPayment.Size = new Size(281, 104);
            gbPayment.TabIndex = 13;
            gbPayment.TabStop = false;
            gbPayment.Text = "Payment Method";
            // 
            // rbtnOther
            // 
            rbtnOther.AutoSize = true;
            rbtnOther.Location = new Point(165, 66);
            rbtnOther.Name = "rbtnOther";
            rbtnOther.Size = new Size(67, 24);
            rbtnOther.TabIndex = 3;
            rbtnOther.TabStop = true;
            rbtnOther.Text = "Other";
            rbtnOther.UseVisualStyleBackColor = true;
            // 
            // rbtnCreditCard
            // 
            rbtnCreditCard.AutoSize = true;
            rbtnCreditCard.Location = new Point(165, 30);
            rbtnCreditCard.Name = "rbtnCreditCard";
            rbtnCreditCard.Size = new Size(105, 24);
            rbtnCreditCard.TabIndex = 2;
            rbtnCreditCard.TabStop = true;
            rbtnCreditCard.Text = "Credit Card";
            rbtnCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbtnATHMovil
            // 
            rbtnATHMovil.AutoSize = true;
            rbtnATHMovil.Location = new Point(19, 66);
            rbtnATHMovil.Name = "rbtnATHMovil";
            rbtnATHMovil.Size = new Size(99, 24);
            rbtnATHMovil.TabIndex = 1;
            rbtnATHMovil.TabStop = true;
            rbtnATHMovil.Text = "ATH Móvil";
            rbtnATHMovil.UseVisualStyleBackColor = true;
            // 
            // rbtnCash
            // 
            rbtnCash.AutoSize = true;
            rbtnCash.Location = new Point(19, 30);
            rbtnCash.Name = "rbtnCash";
            rbtnCash.Size = new Size(61, 24);
            rbtnCash.TabIndex = 0;
            rbtnCash.TabStop = true;
            rbtnCash.Text = "Cash";
            rbtnCash.UseVisualStyleBackColor = true;
            // 
            // btnGetOrderItems
            // 
            btnGetOrderItems.BackColor = Color.Bisque;
            btnGetOrderItems.Location = new Point(82, 448);
            btnGetOrderItems.Name = "btnGetOrderItems";
            btnGetOrderItems.Size = new Size(139, 29);
            btnGetOrderItems.TabIndex = 14;
            btnGetOrderItems.Text = "Get Order Items";
            btnGetOrderItems.UseVisualStyleBackColor = false;
            btnGetOrderItems.Click += btnGetOrderItems_Click;
            // 
            // btnCalculateTotals
            // 
            btnCalculateTotals.BackColor = Color.Bisque;
            btnCalculateTotals.Location = new Point(305, 419);
            btnCalculateTotals.Name = "btnCalculateTotals";
            btnCalculateTotals.Size = new Size(139, 57);
            btnCalculateTotals.TabIndex = 15;
            btnCalculateTotals.Text = "Calculate Totals";
            btnCalculateTotals.UseVisualStyleBackColor = false;
            btnCalculateTotals.Click += btnCalculateTotals_Click;
            // 
            // txtTaxDue
            // 
            txtTaxDue.Location = new Point(453, 114);
            txtTaxDue.Name = "txtTaxDue";
            txtTaxDue.ReadOnly = true;
            txtTaxDue.Size = new Size(125, 27);
            txtTaxDue.TabIndex = 16;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSalmon;
            btnExit.Location = new Point(484, 419);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(83, 57);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(618, 488);
            Controls.Add(btnExit);
            Controls.Add(txtTaxDue);
            Controls.Add(btnCalculateTotals);
            Controls.Add(btnGetOrderItems);
            Controls.Add(gbPayment);
            Controls.Add(lblSelectTip);
            Controls.Add(cmbTip);
            Controls.Add(txtTotalDue);
            Controls.Add(txtTipAmount);
            Controls.Add(txtSubTotal);
            Controls.Add(lblTotalDue);
            Controls.Add(lblTipAmount);
            Controls.Add(lblTaxDue);
            Controls.Add(lblSubTotal);
            Controls.Add(lblItemsOrdered);
            Controls.Add(lstbxItems);
            Name = "Form1";
            Text = "Group Check With Tax and Tip by Erika Sanchez";
            Load += Form1_Load;
            gbPayment.ResumeLayout(false);
            gbPayment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstbxItems;
        private Label lblItemsOrdered;
        private Label lblSubTotal;
        private Label lblTaxDue;
        private Label lblTipAmount;
        private Label lblTotalDue;
        private TextBox txtSubTotal;
        private TextBox txtTipAmount;
        private TextBox txtTotalDue;
        private ComboBox cmbTip;
        private Label lblSelectTip;
        private GroupBox gbPayment;
        private RadioButton rbtnOther;
        private RadioButton rbtnCreditCard;
        private RadioButton rbtnATHMovil;
        private RadioButton rbtnCash;
        private Button btnGetOrderItems;
        private Button btnCalculateTotals;
        private TextBox txtTaxDue;
        private Button btnExit;
    }
}

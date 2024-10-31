namespace SalesWinApp
{
    partial class frmOrderDetailIU
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
            lbOrderID = new Label();
            lbProductID = new Label();
            lbUnitPrice = new Label();
            lbQuantity = new Label();
            lbDiscount = new Label();
            txtOrderID = new TextBox();
            txtProductID = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            txtDiscount = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(40, 29);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(66, 20);
            lbOrderID.TabIndex = 0;
            lbOrderID.Text = "Order ID";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(40, 77);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(79, 20);
            lbProductID.TabIndex = 1;
            lbProductID.Text = "Product ID";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(41, 127);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(72, 20);
            lbUnitPrice.TabIndex = 2;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(41, 179);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(65, 20);
            lbQuantity.TabIndex = 3;
            lbQuantity.Text = "Quantity";
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Location = new Point(41, 232);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new Size(67, 20);
            lbDiscount.TabIndex = 4;
            lbDiscount.Text = "Discount";
            // 
            // txtOrderID
            // 
            txtOrderID.Enabled = false;
            txtOrderID.Location = new Point(172, 26);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(203, 27);
            txtOrderID.TabIndex = 5;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(172, 74);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(203, 27);
            txtProductID.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(172, 124);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(203, 27);
            txtUnitPrice.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(172, 176);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(203, 27);
            txtQuantity.TabIndex = 8;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(172, 229);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(203, 27);
            txtDiscount.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(68, 294);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(281, 294);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmOrderDetailIU
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 351);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtDiscount);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProductID);
            Controls.Add(txtOrderID);
            Controls.Add(lbDiscount);
            Controls.Add(lbQuantity);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbProductID);
            Controls.Add(lbOrderID);
            Name = "frmOrderDetailIU";
            Text = "OrderDetailIU";
            Load += OrderDetailIU_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOrderID;
        private Label lbProductID;
        private Label lbUnitPrice;
        private Label lbQuantity;
        private Label lbDiscount;
        private TextBox txtOrderID;
        private TextBox txtProductID;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtDiscount;
        private Button btnSave;
        private Button btnClose;
    }
}
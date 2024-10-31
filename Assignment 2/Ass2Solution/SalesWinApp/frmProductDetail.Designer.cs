namespace SalesWinApp
{
    partial class frmProductDetail
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
            btnClose = new Button();
            btnSave = new Button();
            txtUnitInStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtWeight = new TextBox();
            txtProductName = new TextBox();
            txtCategoryID = new TextBox();
            txtProductID = new TextBox();
            lbUnitInStock = new Label();
            lbUnitPrice = new Label();
            lbWeight = new Label();
            lbProductName = new Label();
            lbCategoryID = new Label();
            lbProductID = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(369, 380);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 27;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(123, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new Point(262, 315);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(225, 27);
            txtUnitInStock.TabIndex = 25;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(262, 258);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(225, 27);
            txtUnitPrice.TabIndex = 24;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(262, 204);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(225, 27);
            txtWeight.TabIndex = 23;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(262, 149);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(225, 27);
            txtProductName.TabIndex = 22;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(262, 94);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(225, 27);
            txtCategoryID.TabIndex = 21;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(262, 41);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(225, 27);
            txtProductID.TabIndex = 20;
            // 
            // lbUnitInStock
            // 
            lbUnitInStock.AutoSize = true;
            lbUnitInStock.Location = new Point(123, 318);
            lbUnitInStock.Name = "lbUnitInStock";
            lbUnitInStock.Size = new Size(92, 20);
            lbUnitInStock.TabIndex = 19;
            lbUnitInStock.Text = "Unit In Stock";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(123, 261);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(72, 20);
            lbUnitPrice.TabIndex = 18;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(123, 207);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(56, 20);
            lbWeight.TabIndex = 17;
            lbWeight.Text = "Weight";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(123, 152);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(104, 20);
            lbProductName.TabIndex = 16;
            lbProductName.Text = "Product Name";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(123, 97);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(88, 20);
            lbCategoryID.TabIndex = 15;
            lbCategoryID.Text = "Category ID";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(123, 44);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(79, 20);
            lbProductID.TabIndex = 14;
            lbProductID.Text = "Product ID";
            // 
            // ProductDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 450);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtUnitInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtProductName);
            Controls.Add(txtCategoryID);
            Controls.Add(txtProductID);
            Controls.Add(lbUnitInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(lbProductName);
            Controls.Add(lbCategoryID);
            Controls.Add(lbProductID);
            Name = "ProductDetail";
            Text = "ProductDetail";
            Load += ProductDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private TextBox txtUnitInStock;
        private TextBox txtUnitPrice;
        private TextBox txtWeight;
        private TextBox txtProductName;
        private TextBox txtCategoryID;
        private TextBox txtProductID;
        private Label lbUnitInStock;
        private Label lbUnitPrice;
        private Label lbWeight;
        private Label lbProductName;
        private Label lbCategoryID;
        private Label lbProductID;
    }
}
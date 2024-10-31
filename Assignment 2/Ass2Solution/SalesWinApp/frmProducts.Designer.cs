namespace SalesWinApp
{
    partial class frmProducts
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
            dgvProductList = new DataGridView();
            btnClose = new Button();
            btnRemove = new Button();
            btnAddNew = new Button();
            btnLoad = new Button();
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
            btnSearch = new Button();
            cboSearch = new ComboBox();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(22, 278);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.Size = new Size(765, 285);
            dgvProductList.TabIndex = 33;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(350, 569);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 32;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(693, 243);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 31;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(360, 243);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 29);
            btnAddNew.TabIndex = 30;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(22, 243);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 29;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new Point(541, 120);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(224, 27);
            txtUnitInStock.TabIndex = 28;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(541, 71);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(224, 27);
            txtUnitPrice.TabIndex = 27;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(541, 24);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(224, 27);
            txtWeight.TabIndex = 26;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(129, 120);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(224, 27);
            txtProductName.TabIndex = 25;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(129, 71);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(224, 27);
            txtCategoryID.TabIndex = 24;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(129, 24);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(224, 27);
            txtProductID.TabIndex = 23;
            // 
            // lbUnitInStock
            // 
            lbUnitInStock.AutoSize = true;
            lbUnitInStock.Location = new Point(394, 123);
            lbUnitInStock.Name = "lbUnitInStock";
            lbUnitInStock.Size = new Size(92, 20);
            lbUnitInStock.TabIndex = 22;
            lbUnitInStock.Text = "Unit In Stock";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(394, 74);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(72, 20);
            lbUnitPrice.TabIndex = 21;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(394, 27);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(56, 20);
            lbWeight.TabIndex = 20;
            lbWeight.Text = "Weight";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(22, 123);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(104, 20);
            lbProductName.TabIndex = 19;
            lbProductName.Text = "Product Name";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(22, 74);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(88, 20);
            lbCategoryID.TabIndex = 18;
            lbCategoryID.Text = "Category ID";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(22, 27);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(79, 20);
            lbProductID.TabIndex = 17;
            lbProductID.Text = "Product ID";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(22, 181);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 34;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboSearch
            // 
            cboSearch.FormattingEnabled = true;
            cboSearch.Items.AddRange(new object[] { "By ID", "By Name", "By Unit Price", "By Unit In Stock" });
            cboSearch.Location = new Point(122, 182);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(111, 28);
            cboSearch.TabIndex = 35;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(239, 183);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(526, 27);
            txtSearch.TabIndex = 36;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 601);
            Controls.Add(txtSearch);
            Controls.Add(cboSearch);
            Controls.Add(btnSearch);
            Controls.Add(dgvProductList);
            Controls.Add(btnClose);
            Controls.Add(btnRemove);
            Controls.Add(btnAddNew);
            Controls.Add(btnLoad);
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
            Name = "frmProducts";
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductList;
        private Button btnClose;
        private Button btnRemove;
        private Button btnAddNew;
        private Button btnLoad;
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
        private Button btnSearch;
        private ComboBox cboSearch;
        private TextBox txtSearch;
    }
}
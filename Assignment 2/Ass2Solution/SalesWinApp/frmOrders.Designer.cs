namespace SalesWinApp
{
    partial class frmOrders
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            grpOrder = new GroupBox();
            txtShippedDate = new TextBox();
            txtRequiredDate = new TextBox();
            txtOrderDate = new TextBox();
            txtFreight = new TextBox();
            txtMemberID = new TextBox();
            txtOrderIDLeft = new TextBox();
            dgvOrder = new DataGridView();
            btnDelete = new Button();
            btnViewDetail = new Button();
            btnLoad = new Button();
            lbShippedDate = new Label();
            lbRequiredDate = new Label();
            lbOederDate = new Label();
            lbFreight = new Label();
            lbMemberID = new Label();
            lbOrderIDLeft = new Label();
            grpOrderDetail = new GroupBox();
            btnNew = new Button();
            btnDeleteR = new Button();
            dgvOrderDetail = new DataGridView();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtDiscount = new TextBox();
            txtProductID = new TextBox();
            txtOrderIDRight = new TextBox();
            labQuantity = new Label();
            lbUnitPrice = new Label();
            lbDiscount = new Label();
            lbProductID = new Label();
            lbOrderIDRight = new Label();
            btnClose = new Button();
            btnCreate = new Button();
            grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            grpOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(txtShippedDate);
            grpOrder.Controls.Add(txtRequiredDate);
            grpOrder.Controls.Add(txtOrderDate);
            grpOrder.Controls.Add(txtFreight);
            grpOrder.Controls.Add(txtMemberID);
            grpOrder.Controls.Add(txtOrderIDLeft);
            grpOrder.Controls.Add(dgvOrder);
            grpOrder.Controls.Add(btnDelete);
            grpOrder.Controls.Add(btnViewDetail);
            grpOrder.Controls.Add(btnLoad);
            grpOrder.Controls.Add(lbShippedDate);
            grpOrder.Controls.Add(lbRequiredDate);
            grpOrder.Controls.Add(lbOederDate);
            grpOrder.Controls.Add(lbFreight);
            grpOrder.Controls.Add(lbMemberID);
            grpOrder.Controls.Add(lbOrderIDLeft);
            grpOrder.Location = new Point(12, 12);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(503, 449);
            grpOrder.TabIndex = 1;
            grpOrder.TabStop = false;
            grpOrder.Text = "Order";
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(336, 113);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(161, 27);
            txtShippedDate.TabIndex = 16;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(336, 71);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new Size(161, 27);
            txtRequiredDate.TabIndex = 15;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(336, 30);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(161, 27);
            txtOrderDate.TabIndex = 14;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(94, 113);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(125, 27);
            txtFreight.TabIndex = 13;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(94, 71);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(125, 27);
            txtMemberID.TabIndex = 12;
            // 
            // txtOrderIDLeft
            // 
            txtOrderIDLeft.Location = new Point(94, 30);
            txtOrderIDLeft.Name = "txtOrderIDLeft";
            txtOrderIDLeft.Size = new Size(125, 27);
            txtOrderIDLeft.TabIndex = 11;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(6, 195);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(491, 247);
            dgvOrder.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(403, 160);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnViewDetail
            // 
            btnViewDetail.Location = new Point(209, 160);
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new Size(94, 29);
            btnViewDetail.TabIndex = 7;
            btnViewDetail.Text = "View Detail";
            btnViewDetail.UseVisualStyleBackColor = true;
            btnViewDetail.Click += btnViewDetail_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(6, 160);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(225, 116);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(100, 20);
            lbShippedDate.TabIndex = 5;
            lbShippedDate.Text = "Shipped Date";
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new Point(225, 74);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(105, 20);
            lbRequiredDate.TabIndex = 4;
            lbRequiredDate.Text = "Required Date";
            // 
            // lbOederDate
            // 
            lbOederDate.AutoSize = true;
            lbOederDate.Location = new Point(225, 33);
            lbOederDate.Name = "lbOederDate";
            lbOederDate.Size = new Size(83, 20);
            lbOederDate.TabIndex = 3;
            lbOederDate.Text = "Order Date";
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new Point(6, 116);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new Size(55, 20);
            lbFreight.TabIndex = 2;
            lbFreight.Text = "Freight";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(6, 74);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(84, 20);
            lbMemberID.TabIndex = 1;
            lbMemberID.Text = "Member ID";
            // 
            // lbOrderIDLeft
            // 
            lbOrderIDLeft.AutoSize = true;
            lbOrderIDLeft.Location = new Point(6, 33);
            lbOrderIDLeft.Name = "lbOrderIDLeft";
            lbOrderIDLeft.Size = new Size(66, 20);
            lbOrderIDLeft.TabIndex = 0;
            lbOrderIDLeft.Text = "Order ID";
            // 
            // grpOrderDetail
            // 
            grpOrderDetail.Controls.Add(btnNew);
            grpOrderDetail.Controls.Add(btnDeleteR);
            grpOrderDetail.Controls.Add(dgvOrderDetail);
            grpOrderDetail.Controls.Add(txtQuantity);
            grpOrderDetail.Controls.Add(txtUnitPrice);
            grpOrderDetail.Controls.Add(txtDiscount);
            grpOrderDetail.Controls.Add(txtProductID);
            grpOrderDetail.Controls.Add(txtOrderIDRight);
            grpOrderDetail.Controls.Add(labQuantity);
            grpOrderDetail.Controls.Add(lbUnitPrice);
            grpOrderDetail.Controls.Add(lbDiscount);
            grpOrderDetail.Controls.Add(lbProductID);
            grpOrderDetail.Controls.Add(lbOrderIDRight);
            grpOrderDetail.Location = new Point(521, 12);
            grpOrderDetail.Name = "grpOrderDetail";
            grpOrderDetail.Size = new Size(522, 449);
            grpOrderDetail.TabIndex = 2;
            grpOrderDetail.TabStop = false;
            grpOrderDetail.Text = "Order Detail";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(233, 160);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDeleteR
            // 
            btnDeleteR.Location = new Point(422, 160);
            btnDeleteR.Name = "btnDeleteR";
            btnDeleteR.Size = new Size(94, 29);
            btnDeleteR.TabIndex = 11;
            btnDeleteR.Text = "Delete";
            btnDeleteR.UseVisualStyleBackColor = true;
            btnDeleteR.Click += btnDeleteR_Click;
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(6, 195);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.Size = new Size(510, 247);
            dgvOrderDetail.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(356, 71);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(145, 27);
            txtQuantity.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(356, 30);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(145, 27);
            txtUnitPrice.TabIndex = 8;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(356, 113);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(145, 27);
            txtDiscount.TabIndex = 7;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(106, 71);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(137, 27);
            txtProductID.TabIndex = 6;
            // 
            // txtOrderIDRight
            // 
            txtOrderIDRight.Location = new Point(106, 30);
            txtOrderIDRight.Name = "txtOrderIDRight";
            txtOrderIDRight.Size = new Size(137, 27);
            txtOrderIDRight.TabIndex = 5;
            // 
            // labQuantity
            // 
            labQuantity.AutoSize = true;
            labQuantity.Location = new Point(262, 74);
            labQuantity.Name = "labQuantity";
            labQuantity.Size = new Size(65, 20);
            labQuantity.TabIndex = 4;
            labQuantity.Text = "Quantity";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(262, 33);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(72, 20);
            lbUnitPrice.TabIndex = 3;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Location = new Point(262, 116);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new Size(67, 20);
            lbDiscount.TabIndex = 2;
            lbDiscount.Text = "Discount";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(21, 74);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(79, 20);
            lbProductID.TabIndex = 1;
            lbProductID.Text = "Product ID";
            // 
            // lbOrderIDRight
            // 
            lbOrderIDRight.AutoSize = true;
            lbOrderIDRight.Location = new Point(21, 33);
            lbOrderIDRight.Name = "lbOrderIDRight";
            lbOrderIDRight.Size = new Size(66, 20);
            lbOrderIDRight.TabIndex = 0;
            lbOrderIDRight.Text = "Order ID";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(461, 467);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(18, 467);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 507);
            Controls.Add(btnCreate);
            Controls.Add(btnClose);
            Controls.Add(grpOrderDetail);
            Controls.Add(grpOrder);
            Name = "frmOrders";
            Text = "frmOrders";
            Load += frmOrders_Load;
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            grpOrderDetail.ResumeLayout(false);
            grpOrderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private GroupBox grpOrder;
        private GroupBox grpOrderDetail;
        private DataGridView dgvOrder;
        private Button btnClose;
        private Button btnDelete;
        private Button btnViewDetail;
        private Button btnLoad;
        private Label lbShippedDate;
        private Label lbRequiredDate;
        private Label lbOederDate;
        private Label lbFreight;
        private Label lbMemberID;
        private Label lbOrderIDLeft;
        private TextBox txtShippedDate;
        private TextBox txtRequiredDate;
        private TextBox txtOrderDate;
        private TextBox txtFreight;
        private TextBox txtMemberID;
        private TextBox txtOrderIDLeft;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtDiscount;
        private TextBox txtProductID;
        private TextBox txtOrderIDRight;
        private Label labQuantity;
        private Label lbUnitPrice;
        private Label lbDiscount;
        private Label lbProductID;
        private Label lbOrderIDRight;
        private DataGridView dgvOrderDetail;
        private Button btnCreate;
        private Button btnNew;
        private Button btnDeleteR;
    }
}
namespace SalesWinApp
{
    partial class frmOrderIU
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
            txtOrderID = new TextBox();
            lbShippedDate = new Label();
            lbRequiredDate = new Label();
            lbOrderDate = new Label();
            lbMemberID = new Label();
            lbOrderID = new Label();
            lbFreight = new Label();
            txtFreight = new TextBox();
            dtpOrderDate = new DateTimePicker();
            dtpRequiredDate = new DateTimePicker();
            dtpShippedDate = new DateTimePicker();
            txtMemberID = new TextBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(329, 357);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 27;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(59, 357);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(198, 29);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(250, 27);
            txtOrderID.TabIndex = 20;
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(59, 249);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(100, 20);
            lbShippedDate.TabIndex = 18;
            lbShippedDate.Text = "Shipped Date";
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new Point(59, 195);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(105, 20);
            lbRequiredDate.TabIndex = 17;
            lbRequiredDate.Text = "Required Date";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(59, 140);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(79, 20);
            lbOrderDate.TabIndex = 16;
            lbOrderDate.Text = "OrderDate";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(59, 85);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(80, 20);
            lbMemberID.TabIndex = 15;
            lbMemberID.Text = "MemberID";
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(59, 32);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(62, 20);
            lbOrderID.TabIndex = 14;
            lbOrderID.Text = "OrderID";
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new Point(59, 303);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new Size(55, 20);
            lbFreight.TabIndex = 18;
            lbFreight.Text = "Freight";
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(198, 300);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(250, 27);
            txtFreight.TabIndex = 24;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(198, 135);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(250, 27);
            dtpOrderDate.TabIndex = 28;
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.Location = new Point(198, 190);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(250, 27);
            dtpRequiredDate.TabIndex = 29;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(198, 244);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(250, 27);
            dtpShippedDate.TabIndex = 30;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(198, 82);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(250, 27);
            txtMemberID.TabIndex = 31;
            // 
            // frmOrderIU
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 415);
            Controls.Add(txtMemberID);
            Controls.Add(dtpShippedDate);
            Controls.Add(dtpRequiredDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtFreight);
            Controls.Add(txtOrderID);
            Controls.Add(lbFreight);
            Controls.Add(lbShippedDate);
            Controls.Add(lbRequiredDate);
            Controls.Add(lbOrderDate);
            Controls.Add(lbMemberID);
            Controls.Add(lbOrderID);
            Name = "frmOrderIU";
            Text = "frmOrderIU";
            Load += frmOrderIU_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private TextBox txtCity;
        private TextBox txtCompanyName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtOrderID;
        private Label lbShippedDate;
        private Label lbRequiredDate;
        private Label lbOrderDate;
        private Label lbMemberID;
        private Label lbOrderID;
        private Label lbFreight;
        private TextBox txtFreight;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpShippedDate;
        private TextBox txtMemberID;
    }
}
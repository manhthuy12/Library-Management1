namespace SalesWinApp
{
    partial class frmMembers
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
            lbMemberID = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            lbCompanyName = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            txtMemberID = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtCompanyName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            btnLoad = new Button();
            btnAddNew = new Button();
            btnRemove = new Button();
            btnClose = new Button();
            dgvMemberList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(23, 33);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(84, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(23, 80);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(23, 129);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(395, 33);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(116, 20);
            lbCompanyName.TabIndex = 3;
            lbCompanyName.Text = "Company Name";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(395, 80);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(395, 129);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(130, 30);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(224, 27);
            txtMemberID.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(130, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(130, 126);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(542, 30);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(224, 27);
            txtCompanyName.TabIndex = 9;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(542, 77);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(224, 27);
            txtCity.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(542, 126);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(224, 27);
            txtCountry.TabIndex = 11;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(23, 189);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(361, 189);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 29);
            btnAddNew.TabIndex = 13;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(694, 189);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(351, 515);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(23, 224);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.Size = new Size(765, 285);
            dgvMemberList.TabIndex = 16;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 556);
            Controls.Add(dgvMemberList);
            Controls.Add(btnClose);
            Controls.Add(btnRemove);
            Controls.Add(btnAddNew);
            Controls.Add(btnLoad);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompanyName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberID);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCompanyName);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberID);
            Name = "frmMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMembers";
            Load += frmMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberID;
        private Label lbEmail;
        private Label lbPassword;
        private Label lbCompanyName;
        private Label lbCity;
        private Label lbCountry;
        private TextBox txtMemberID;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtCompanyName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Button btnLoad;
        private Button btnAddNew;
        private Button btnRemove;
        private Button btnClose;
        private DataGridView dgvMemberList;
    }
}
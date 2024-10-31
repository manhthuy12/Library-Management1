namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            lbID = new Label();
            lbMemberName = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            lbCountry = new Label();
            lbCity = new Label();
            txtID = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtMemberName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            dgvMemberList = new DataGridView();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnFilter = new Button();
            cboSearch = new ComboBox();
            cboFilterCountry = new ComboBox();
            txtSearch = new TextBox();
            btnSort = new Button();
            cboSort = new ComboBox();
            cboFilterCity = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(352, 553);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(69, 31);
            lbID.Name = "lbID";
            lbID.Size = new Size(24, 20);
            lbID.TabIndex = 1;
            lbID.Text = "ID";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(397, 31);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(109, 20);
            lbMemberName.TabIndex = 2;
            lbMemberName.Text = "Member Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(69, 71);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(69, 114);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(397, 114);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(397, 71);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 6;
            lbCity.Text = "City";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(167, 28);
            txtID.Name = "txtID";
            txtID.Size = new Size(202, 27);
            txtID.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(167, 68);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(167, 111);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(202, 27);
            txtPassword.TabIndex = 9;
            // 
            // txtMemberName
            // 
            txtMemberName.Enabled = false;
            txtMemberName.Location = new Point(525, 28);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(248, 27);
            txtMemberName.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Enabled = false;
            txtCity.Location = new Point(525, 68);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(248, 27);
            txtCity.TabIndex = 11;
            // 
            // txtCountry
            // 
            txtCountry.Enabled = false;
            txtCountry.Location = new Point(525, 111);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(248, 27);
            txtCountry.TabIndex = 12;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(12, 314);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.Size = new Size(776, 233);
            dgvMemberList.TabIndex = 13;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 279);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 14;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(352, 279);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 15;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(694, 279);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(260, 156);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(74, 29);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(261, 190);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(73, 29);
            btnFilter.TabIndex = 18;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // cboSearch
            // 
            cboSearch.FormattingEnabled = true;
            cboSearch.Items.AddRange(new object[] { "ID", "Name" });
            cboSearch.Location = new Point(349, 157);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(42, 28);
            cboSearch.TabIndex = 19;
            // 
            // cboFilterCountry
            // 
            cboFilterCountry.FormattingEnabled = true;
            cboFilterCountry.Location = new Point(349, 191);
            cboFilterCountry.Name = "cboFilterCountry";
            cboFilterCountry.Size = new Size(82, 28);
            cboFilterCountry.TabIndex = 20;
            cboFilterCountry.SelectedIndexChanged += cboFilterType_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(397, 158);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(154, 27);
            txtSearch.TabIndex = 21;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(262, 224);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(72, 29);
            btnSort.TabIndex = 22;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Items.AddRange(new object[] { "By ID ascending", "By ID descending", "By Name ascending", "By Name descending" });
            cboSort.Location = new Point(349, 225);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(202, 28);
            cboSort.TabIndex = 23;
            cboSort.Text = "--Select--";
            // 
            // cboFilterCity
            // 
            cboFilterCity.Enabled = false;
            cboFilterCity.FormattingEnabled = true;
            cboFilterCity.Location = new Point(437, 191);
            cboFilterCity.Name = "cboFilterCity";
            cboFilterCity.Size = new Size(114, 28);
            cboFilterCity.TabIndex = 24;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 590);
            Controls.Add(cboFilterCity);
            Controls.Add(cboSort);
            Controls.Add(btnSort);
            Controls.Add(txtSearch);
            Controls.Add(cboFilterCountry);
            Controls.Add(cboSearch);
            Controls.Add(btnFilter);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(dgvMemberList);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtMemberName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtID);
            Controls.Add(lbCity);
            Controls.Add(lbCountry);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberName);
            Controls.Add(lbID);
            Controls.Add(btnClose);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Management";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label lbID;
        private Label lbMemberName;
        private Label lbEmail;
        private Label lbPassword;
        private Label lbCountry;
        private Label lbCity;
        private TextBox txtID;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtMemberName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private DataGridView dgvMemberList;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnFilter;
        private ComboBox cboSearch;
        private ComboBox cboFilterCountry;
        private TextBox txtSearch;
        private Button btnSort;
        private ComboBox cboSort;
        private ComboBox cboFilterCity;
    }
}
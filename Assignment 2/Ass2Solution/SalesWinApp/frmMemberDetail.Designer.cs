namespace SalesWinApp
{
    partial class frmMemberDetail
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
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(68, 56);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(84, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(68, 109);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(68, 164);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(68, 219);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(116, 20);
            lbCompanyName.TabIndex = 3;
            lbCompanyName.Text = "Company Name";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(68, 273);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(68, 330);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(207, 53);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(225, 27);
            txtMemberID.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(207, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(207, 161);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(225, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(207, 216);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(225, 27);
            txtCompanyName.TabIndex = 9;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(207, 270);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(225, 27);
            txtCity.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(207, 327);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(225, 27);
            txtCountry.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(68, 392);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(314, 392);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // MemberDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 450);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
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
            Name = "MemberDetail";
            Text = "MemberDetail";
            Load += MemberDetail_Load;
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
        private Button btnSave;
        private Button btnClose;
    }
}
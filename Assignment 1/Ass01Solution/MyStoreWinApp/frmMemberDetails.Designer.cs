namespace MyStoreWinApp
{
    partial class frmMemberDetails
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
            lbID = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            lbMemberName = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtID = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtMemberName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            SuspendLayout();
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(60, 40);
            lbID.Name = "lbID";
            lbID.Size = new Size(24, 20);
            lbID.TabIndex = 0;
            lbID.Text = "ID";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(60, 82);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(60, 126);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(64, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Pasword";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(363, 40);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(109, 20);
            lbMemberName.TabIndex = 3;
            lbMemberName.Text = "Member Name";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(363, 82);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(363, 126);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(136, 191);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(496, 191);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(136, 37);
            txtID.Name = "txtID";
            txtID.Size = new Size(187, 27);
            txtID.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(136, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(136, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(187, 27);
            txtPassword.TabIndex = 10;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(496, 37);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(186, 27);
            txtMemberName.TabIndex = 11;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(496, 82);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(186, 27);
            txtCity.TabIndex = 12;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(496, 126);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(186, 27);
            txtCountry.TabIndex = 13;
            // 
            // frmMemberDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 262);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtMemberName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbMemberName);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbID);
            Name = "frmMemberDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Details";
            Load += frmMemberDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbID;
        private Label lbEmail;
        private Label lbPassword;
        private Label lbMemberName;
        private Label lbCity;
        private Label lbCountry;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtID;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtMemberName;
        private TextBox txtCity;
        private TextBox txtCountry;
    }
}
namespace SalesWinApp
{
    partial class frmLogin
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
            btnLogin = new Button();
            btnClose = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lbEmail = new Label();
            lbPassword = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.DialogResult = DialogResult.OK;
            btnLogin.Font = new Font("Comic Sans MS", 9F);
            btnLogin.Location = new Point(75, 235);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Font = new Font("Comic Sans MS", 9F);
            btnClose.Location = new Point(379, 235);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13.8F);
            txtEmail.Location = new Point(226, 47);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 38);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F);
            txtPassword.Location = new Point(226, 129);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(247, 38);
            txtPassword.TabIndex = 3;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            lbEmail.Location = new Point(75, 50);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(71, 32);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            lbPassword.Location = new Point(75, 132);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(114, 32);
            lbPassword.TabIndex = 5;
            lbPassword.Text = "Password";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 306);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnClose;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label lbEmail;
        private Label lbPassword;
    }
}
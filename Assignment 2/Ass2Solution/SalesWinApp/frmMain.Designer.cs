namespace SalesWinApp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnsMain = new MenuStrip();
            memberToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            orderManagementToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            lbWelcome = new Label();
            btnClose = new Button();
            mnsMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnsMain
            // 
            mnsMain.ImageScalingSize = new Size(20, 20);
            mnsMain.Items.AddRange(new ToolStripItem[] { memberToolStripMenuItem, productToolStripMenuItem, orderToolStripMenuItem });
            mnsMain.Location = new Point(0, 0);
            mnsMain.Name = "mnsMain";
            mnsMain.Size = new Size(318, 28);
            mnsMain.TabIndex = 0;
            mnsMain.Text = "menuStrip1";
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(79, 24);
            memberToolStripMenuItem.Text = "Member";
            memberToolStripMenuItem.Click += memberToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(74, 24);
            productToolStripMenuItem.Text = "Product";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { orderManagementToolStripMenuItem, reportToolStripMenuItem });
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(61, 24);
            orderToolStripMenuItem.Text = "Order";
            // 
            // orderManagementToolStripMenuItem
            // 
            orderManagementToolStripMenuItem.Name = "orderManagementToolStripMenuItem";
            orderManagementToolStripMenuItem.Size = new Size(224, 26);
            orderManagementToolStripMenuItem.Text = "Order Management";
            orderManagementToolStripMenuItem.Click += orderManagementToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(224, 26);
            reportToolStripMenuItem.Text = "Report";
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbWelcome.Location = new Point(22, 73);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(80, 23);
            lbWelcome.TabIndex = 1;
            lbWelcome.Text = "Welcome";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(79, 128);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 169);
            Controls.Add(btnClose);
            Controls.Add(lbWelcome);
            Controls.Add(mnsMain);
            MainMenuStrip = mnsMain;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += frmMain_Load;
            mnsMain.ResumeLayout(false);
            mnsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsMain;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private Label lbWelcome;
        private ToolStripMenuItem orderManagementToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private Button btnClose;
    }
}

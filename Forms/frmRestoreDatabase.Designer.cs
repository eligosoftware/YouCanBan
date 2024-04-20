namespace YouCanBan.Forms
{
    partial class frmRestoreDatabase
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
            btnRestore = new Button();
            btnPickFile = new Button();
            txtBackupPath = new TextBox();
            lblBackupPath = new Label();
            txtServer = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtDatabase = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblDatabase = new Label();
            lblServer = new Label();
            SuspendLayout();
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(12, 255);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(128, 29);
            btnRestore.TabIndex = 21;
            btnRestore.Text = "Restore";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // btnPickFile
            // 
            btnPickFile.Location = new Point(419, 10);
            btnPickFile.Name = "btnPickFile";
            btnPickFile.Size = new Size(39, 29);
            btnPickFile.TabIndex = 20;
            btnPickFile.Text = "...";
            btnPickFile.UseVisualStyleBackColor = true;
            btnPickFile.Click += btnPickFile_Click;
            // 
            // txtBackupPath
            // 
            txtBackupPath.Location = new Point(89, 12);
            txtBackupPath.Name = "txtBackupPath";
            txtBackupPath.Size = new Size(292, 27);
            txtBackupPath.TabIndex = 19;
            // 
            // lblBackupPath
            // 
            lblBackupPath.AutoSize = true;
            lblBackupPath.Location = new Point(10, 19);
            lblBackupPath.Name = "lblBackupPath";
            lblBackupPath.Size = new Size(40, 20);
            lblBackupPath.TabIndex = 18;
            lblBackupPath.Text = "Path:";
            // 
            // txtServer
            // 
            txtServer.Location = new Point(167, 60);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(214, 27);
            txtServer.TabIndex = 25;
            txtServer.Text = "localhost";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(167, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(214, 27);
            txtPassword.TabIndex = 29;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(167, 144);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(214, 27);
            txtUsername.TabIndex = 28;
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(167, 101);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(214, 27);
            txtDatabase.TabIndex = 27;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 199);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 26;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(12, 151);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 24;
            lblUsername.Text = "Username";
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Location = new Point(12, 108);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(72, 20);
            lblDatabase.TabIndex = 23;
            lblDatabase.Text = "Database";
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(12, 68);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(50, 20);
            lblServer.TabIndex = 22;
            lblServer.Text = "Server";
            // 
            // frmRestoreDatabase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 290);
            Controls.Add(txtServer);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtDatabase);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblDatabase);
            Controls.Add(lblServer);
            Controls.Add(btnRestore);
            Controls.Add(btnPickFile);
            Controls.Add(txtBackupPath);
            Controls.Add(lblBackupPath);
            Name = "frmRestoreDatabase";
            Text = "Restore Database";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRestore;
        private Button btnPickFile;
        private TextBox txtBackupPath;
        private Label lblBackupPath;
        private TextBox txtServer;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtDatabase;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblDatabase;
        private Label lblServer;
    }
}
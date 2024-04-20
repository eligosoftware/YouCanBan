namespace YouCanBan.Forms
{
    partial class frmBackupDatabase
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
            txtServer = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtDatabase = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblDatabase = new Label();
            lblServer = new Label();
            btnBackup = new Button();
            btnPickFile = new Button();
            txtBackupPath = new TextBox();
            lblBackupPath = new Label();
            SuspendLayout();
            // 
            // txtServer
            // 
            txtServer.Location = new Point(173, 60);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(214, 27);
            txtServer.TabIndex = 37;
            txtServer.Text = "localhost";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(173, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(214, 27);
            txtPassword.TabIndex = 41;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(173, 144);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(214, 27);
            txtUsername.TabIndex = 40;
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(173, 101);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(214, 27);
            txtDatabase.TabIndex = 39;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(18, 199);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 38;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(18, 151);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 36;
            lblUsername.Text = "Username";
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Location = new Point(18, 108);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(72, 20);
            lblDatabase.TabIndex = 35;
            lblDatabase.Text = "Database";
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(18, 68);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(50, 20);
            lblServer.TabIndex = 34;
            lblServer.Text = "Server";
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(18, 255);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(128, 29);
            btnBackup.TabIndex = 33;
            btnBackup.Text = "Backup";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnPickFile
            // 
            btnPickFile.Location = new Point(425, 10);
            btnPickFile.Name = "btnPickFile";
            btnPickFile.Size = new Size(39, 29);
            btnPickFile.TabIndex = 32;
            btnPickFile.Text = "...";
            btnPickFile.UseVisualStyleBackColor = true;
            btnPickFile.Click += btnPickFile_Click;
            // 
            // txtBackupPath
            // 
            txtBackupPath.Location = new Point(95, 12);
            txtBackupPath.Name = "txtBackupPath";
            txtBackupPath.Size = new Size(292, 27);
            txtBackupPath.TabIndex = 31;
            // 
            // lblBackupPath
            // 
            lblBackupPath.AutoSize = true;
            lblBackupPath.Location = new Point(16, 19);
            lblBackupPath.Name = "lblBackupPath";
            lblBackupPath.Size = new Size(40, 20);
            lblBackupPath.TabIndex = 30;
            lblBackupPath.Text = "Path:";
            // 
            // frmBackupDatabase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 300);
            Controls.Add(txtServer);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtDatabase);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblDatabase);
            Controls.Add(lblServer);
            Controls.Add(btnBackup);
            Controls.Add(btnPickFile);
            Controls.Add(txtBackupPath);
            Controls.Add(lblBackupPath);
            Name = "frmBackupDatabase";
            Text = "Backup database";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtServer;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtDatabase;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblDatabase;
        private Label lblServer;
        private Button btnBackup;
        private Button btnPickFile;
        private TextBox txtBackupPath;
        private Label lblBackupPath;
    }
}
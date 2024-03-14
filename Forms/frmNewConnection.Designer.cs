namespace YouCanBan.Forms
{
    partial class frmNewConnection
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
            lblServer = new Label();
            lblDatabase = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtDatabase = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtServer = new TextBox();
            rbLocal = new RadioButton();
            rbGoogleCloud = new RadioButton();
            groupBox1 = new GroupBox();
            btnOk = new Button();
            btnCancel = new Button();
            txtPort = new TextBox();
            lblPort = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(12, 90);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(50, 20);
            lblServer.TabIndex = 0;
            lblServer.Text = "Server";
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Location = new Point(12, 130);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(72, 20);
            lblDatabase.TabIndex = 1;
            lblDatabase.Text = "Database";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(12, 173);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 221);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(167, 123);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(214, 27);
            txtDatabase.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(167, 166);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(214, 27);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(167, 214);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(214, 27);
            txtPassword.TabIndex = 6;
            // 
            // txtServer
            // 
            txtServer.Location = new Point(167, 82);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(214, 27);
            txtServer.TabIndex = 3;
            txtServer.Text = "localhost";
            // 
            // rbLocal
            // 
            rbLocal.AutoSize = true;
            rbLocal.Checked = true;
            rbLocal.Location = new Point(6, 26);
            rbLocal.Name = "rbLocal";
            rbLocal.Size = new Size(65, 24);
            rbLocal.TabIndex = 1;
            rbLocal.TabStop = true;
            rbLocal.Text = "Local";
            rbLocal.UseVisualStyleBackColor = true;
            // 
            // rbGoogleCloud
            // 
            rbGoogleCloud.AutoSize = true;
            rbGoogleCloud.Location = new Point(158, 31);
            rbGoogleCloud.Name = "rbGoogleCloud";
            rbGoogleCloud.Size = new Size(122, 24);
            rbGoogleCloud.TabIndex = 2;
            rbGoogleCloud.Text = "Google Cloud";
            rbGoogleCloud.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbLocal);
            groupBox1.Controls.Add(rbGoogleCloud);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 64);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DB Type";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(15, 268);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(128, 29);
            btnOk.TabIndex = 9;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(167, 268);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(466, 83);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(99, 27);
            txtPort.TabIndex = 11;
            txtPort.Text = "1433";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(411, 90);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(35, 20);
            lblPort.TabIndex = 12;
            lblPort.Text = "Port";
            // 
            // frmNewConnection
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 300);
            Controls.Add(lblPort);
            Controls.Add(txtPort);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(groupBox1);
            Controls.Add(txtServer);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtDatabase);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblDatabase);
            Controls.Add(lblServer);
            Name = "frmNewConnection";
            Text = "New Connection";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServer;
        private Label lblDatabase;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtDatabase;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtServer;
        private RadioButton rbLocal;
        private RadioButton rbGoogleCloud;
        private GroupBox groupBox1;
        private Button btnOk;
        private Button btnCancel;
        private TextBox txtPort;
        private Label lblPort;
    }
}
namespace YouCanBan.Forms
{
    partial class frmEnterBakEncryptionPassword
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
            txtPassword = new TextBox();
            lblEnterPassword = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            btnShowPassword = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(114, 40);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(244, 27);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblEnterPassword
            // 
            lblEnterPassword.AutoSize = true;
            lblEnterPassword.Location = new Point(30, 47);
            lblEnterPassword.Name = "lblEnterPassword";
            lblEnterPassword.Size = new Size(73, 20);
            lblEnterPassword.TabIndex = 1;
            lblEnterPassword.Text = "Password:";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(30, 101);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(264, 101);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnShowPassword
            // 
            btnShowPassword.Location = new Point(373, 38);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(147, 29);
            btnShowPassword.TabIndex = 4;
            btnShowPassword.Text = "Show Password";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.MouseDown += btnShowPassword_MouseDown;
            btnShowPassword.MouseUp += btnShowPassword_MouseUp;
            // 
            // frmEnterBakEncryptionPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 148);
            Controls.Add(btnShowPassword);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(lblEnterPassword);
            Controls.Add(txtPassword);
            Name = "frmEnterBakEncryptionPassword";
            Text = "Enter Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEnterPassword;
        private Button btnOK;
        private Button btnCancel;
        private Button btnShowPassword;
        public TextBox txtPassword;
    }
}
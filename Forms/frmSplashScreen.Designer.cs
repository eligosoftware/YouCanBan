namespace YouCanBan
{
    partial class frmSplashScreen
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
            lblVersion = new Label();
            SuspendLayout();
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.BackColor = Color.White;
            lblVersion.ForeColor = Color.Black;
            lblVersion.Location = new Point(762, 430);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(94, 20);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "Version: 1.0.0";
            // 
            // frmSplashScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(868, 456);
            Controls.Add(lblVersion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSplashScreen";
            Text = "SplashScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVersion;
    }
}
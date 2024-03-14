namespace YouCanBan
{
    partial class frmStart
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
            btnCreateNewDB = new Button();
            btnConnectEx = new Button();
            btnManageConnections = new Button();
            cmbConnections = new ComboBox();
            btnStartClose = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCreateNewDB
            // 
            btnCreateNewDB.Location = new Point(45, 30);
            btnCreateNewDB.Name = "btnCreateNewDB";
            btnCreateNewDB.Size = new Size(247, 29);
            btnCreateNewDB.TabIndex = 0;
            btnCreateNewDB.Text = "Create new database";
            btnCreateNewDB.UseVisualStyleBackColor = true;
            btnCreateNewDB.Click += btnCreateNewDB_Click;
            // 
            // btnConnectEx
            // 
            btnConnectEx.Location = new Point(211, 114);
            btnConnectEx.Name = "btnConnectEx";
            btnConnectEx.Size = new Size(48, 29);
            btnConnectEx.TabIndex = 1;
            btnConnectEx.Text = "OK";
            btnConnectEx.UseVisualStyleBackColor = true;
            btnConnectEx.Click += btnConnectEx_Click;
            // 
            // btnManageConnections
            // 
            btnManageConnections.Location = new Point(333, 30);
            btnManageConnections.Name = "btnManageConnections";
            btnManageConnections.Size = new Size(166, 29);
            btnManageConnections.TabIndex = 2;
            btnManageConnections.Text = "Manage Connections";
            btnManageConnections.UseVisualStyleBackColor = true;
            btnManageConnections.Click += btnManageConnections_Click;
            // 
            // cmbConnections
            // 
            cmbConnections.FormattingEnabled = true;
            cmbConnections.Location = new Point(45, 114);
            cmbConnections.Name = "cmbConnections";
            cmbConnections.Size = new Size(151, 28);
            cmbConnections.TabIndex = 3;
            // 
            // btnStartClose
            // 
            btnStartClose.Location = new Point(277, 113);
            btnStartClose.Name = "btnStartClose";
            btnStartClose.Size = new Size(75, 29);
            btnStartClose.TabIndex = 4;
            btnStartClose.Text = "Close";
            btnStartClose.UseVisualStyleBackColor = true;
            btnStartClose.Click += btnStartClose_Click;
            // 
            // button1
            // 
            button1.Location = new Point(45, 65);
            button1.Name = "button1";
            button1.Size = new Size(247, 29);
            button1.TabIndex = 5;
            button1.Text = "Add existing Database";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 169);
            Controls.Add(button1);
            Controls.Add(btnStartClose);
            Controls.Add(cmbConnections);
            Controls.Add(btnManageConnections);
            Controls.Add(btnConnectEx);
            Controls.Add(btnCreateNewDB);
            Name = "frmStart";
            Text = "Connection Setup";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateNewDB;
        private Button btnConnectEx;
        private Button btnManageConnections;
        private ComboBox cmbConnections;
        private Button btnStartClose;
        private Button button1;
    }
}
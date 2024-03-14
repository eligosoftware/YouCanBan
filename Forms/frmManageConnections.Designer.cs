namespace YouCanBan.Forms
{
    partial class frmManageConnections
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
            gridConnections = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colServer = new DataGridViewTextBoxColumn();
            colPort = new DataGridViewTextBoxColumn();
            colDatabase = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            Active = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            btnAddConnection = new Button();
            btnTestConnection = new Button();
            ((System.ComponentModel.ISupportInitialize)gridConnections).BeginInit();
            SuspendLayout();
            // 
            // gridConnections
            // 
            gridConnections.AllowUserToOrderColumns = true;
            gridConnections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridConnections.Columns.AddRange(new DataGridViewColumn[] { colName, colType, colServer, colPort, colDatabase, colUsername, colPassword, Active, ID });
            gridConnections.EditMode = DataGridViewEditMode.EditOnKeystroke;
            gridConnections.Location = new Point(12, 12);
            gridConnections.Name = "gridConnections";
            gridConnections.RowHeadersWidth = 51;
            gridConnections.RowTemplate.Height = 29;
            gridConnections.Size = new Size(933, 309);
            gridConnections.TabIndex = 0;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.Width = 125;
            // 
            // colType
            // 
            colType.HeaderText = "Type";
            colType.MinimumWidth = 6;
            colType.Name = "colType";
            colType.Width = 125;
            // 
            // colServer
            // 
            colServer.HeaderText = "Server";
            colServer.MinimumWidth = 6;
            colServer.Name = "colServer";
            colServer.Width = 125;
            // 
            // colPort
            // 
            colPort.HeaderText = "Port";
            colPort.MinimumWidth = 6;
            colPort.Name = "colPort";
            colPort.Width = 125;
            // 
            // colDatabase
            // 
            colDatabase.HeaderText = "Database";
            colDatabase.MinimumWidth = 6;
            colDatabase.Name = "colDatabase";
            colDatabase.Width = 125;
            // 
            // colUsername
            // 
            colUsername.HeaderText = "Username";
            colUsername.MinimumWidth = 6;
            colUsername.Name = "colUsername";
            colUsername.Width = 125;
            // 
            // colPassword
            // 
            colPassword.HeaderText = "Password";
            colPassword.MinimumWidth = 6;
            colPassword.Name = "colPassword";
            colPassword.Width = 125;
            // 
            // Active
            // 
            Active.HeaderText = "Active";
            Active.MinimumWidth = 6;
            Active.Name = "Active";
            Active.Width = 125;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 125;
            // 
            // btnAddConnection
            // 
            btnAddConnection.Location = new Point(12, 343);
            btnAddConnection.Name = "btnAddConnection";
            btnAddConnection.Size = new Size(151, 29);
            btnAddConnection.TabIndex = 1;
            btnAddConnection.Text = "New Connection";
            btnAddConnection.UseVisualStyleBackColor = true;
            btnAddConnection.Click += btnAddConnection_Click;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(169, 343);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(94, 29);
            btnTestConnection.TabIndex = 2;
            btnTestConnection.Text = "Test";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // frmManageConnections
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 383);
            Controls.Add(btnTestConnection);
            Controls.Add(btnAddConnection);
            Controls.Add(gridConnections);
            Name = "frmManageConnections";
            Text = "Manage Connections";
            FormClosed += frmManageConnections_FormClosed;
            ((System.ComponentModel.ISupportInitialize)gridConnections).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridConnections;
        private Button btnAddConnection;
        private Button btnTestConnection;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colServer;
        private DataGridViewTextBoxColumn colPort;
        private DataGridViewTextBoxColumn colDatabase;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colPassword;
        private DataGridViewTextBoxColumn Active;
        private DataGridViewTextBoxColumn ID;
    }
}
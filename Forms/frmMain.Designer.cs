namespace YouCanBan.Forms
{
    partial class frmMain
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
            gridWaiting = new DataGridView();
            gridProgress = new DataGridView();
            gridReady = new DataGridView();
            lblWaiting = new Label();
            lblInProgress = new Label();
            lblReady = new Label();
            chbArchived = new CheckBox();
            menuStrip1 = new MenuStrip();
            connectionsToolStripMenuItem = new ToolStripMenuItem();
            manageConnectionsToolStripMenuItem = new ToolStripMenuItem();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            updateTasksToolStripMenuItem = new ToolStripMenuItem();
            saveTaskInformationToolStripMenuItem = new ToolStripMenuItem();
            lblName = new Label();
            lblDescription = new Label();
            lblCategory = new Label();
            lblNotes = new Label();
            cmbCategory = new ComboBox();
            btnToggleArchive = new Button();
            txtDescription = new TextBox();
            txtName = new TextBox();
            lblId = new Label();
            lblIdValue = new Label();
            txtNotes = new TextBox();
            lblArchived = new Label();
            lblSavedState = new Label();
            ((System.ComponentModel.ISupportInitialize)gridWaiting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridProgress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridReady).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gridWaiting
            // 
            gridWaiting.AllowUserToOrderColumns = true;
            gridWaiting.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gridWaiting.BackgroundColor = Color.Tomato;
            gridWaiting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridWaiting.Location = new Point(6, 57);
            gridWaiting.Margin = new Padding(3, 2, 3, 2);
            gridWaiting.Name = "gridWaiting";
            gridWaiting.RowHeadersWidth = 51;
            gridWaiting.RowTemplate.Height = 29;
            gridWaiting.Size = new Size(288, 372);
            gridWaiting.TabIndex = 0;
            gridWaiting.CellClick += gridReady_CellClick;
            gridWaiting.RowsAdded += gridWaiting_RowsAdded;
            // 
            // gridProgress
            // 
            gridProgress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gridProgress.BackgroundColor = Color.LightSkyBlue;
            gridProgress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProgress.Location = new Point(316, 58);
            gridProgress.Margin = new Padding(3, 2, 3, 2);
            gridProgress.Name = "gridProgress";
            gridProgress.RowHeadersWidth = 51;
            gridProgress.RowTemplate.Height = 29;
            gridProgress.Size = new Size(300, 371);
            gridProgress.TabIndex = 1;
            gridProgress.CellClick += gridReady_CellClick;
            gridProgress.RowsAdded += gridProgress_RowsAdded;
            // 
            // gridReady
            // 
            gridReady.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gridReady.BackgroundColor = Color.Lime;
            gridReady.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridReady.Location = new Point(629, 58);
            gridReady.Margin = new Padding(3, 2, 3, 2);
            gridReady.Name = "gridReady";
            gridReady.RowHeadersWidth = 51;
            gridReady.RowTemplate.Height = 29;
            gridReady.Size = new Size(313, 371);
            gridReady.TabIndex = 2;
            gridReady.CellClick += gridReady_CellClick;
            gridReady.RowsAdded += gridReady_RowsAdded;
            // 
            // lblWaiting
            // 
            lblWaiting.AutoSize = true;
            lblWaiting.ForeColor = Color.Red;
            lblWaiting.Location = new Point(6, 30);
            lblWaiting.Name = "lblWaiting";
            lblWaiting.Size = new Size(48, 15);
            lblWaiting.TabIndex = 3;
            lblWaiting.Text = "Waiting";
            // 
            // lblInProgress
            // 
            lblInProgress.AutoSize = true;
            lblInProgress.ForeColor = Color.MediumBlue;
            lblInProgress.Location = new Point(316, 30);
            lblInProgress.Name = "lblInProgress";
            lblInProgress.Size = new Size(65, 15);
            lblInProgress.TabIndex = 4;
            lblInProgress.Text = "In Progress";
            // 
            // lblReady
            // 
            lblReady.AutoSize = true;
            lblReady.ForeColor = Color.Green;
            lblReady.Location = new Point(629, 32);
            lblReady.Name = "lblReady";
            lblReady.Size = new Size(39, 15);
            lblReady.TabIndex = 5;
            lblReady.Text = "Ready";
            // 
            // chbArchived
            // 
            chbArchived.AutoSize = true;
            chbArchived.Location = new Point(838, 32);
            chbArchived.Margin = new Padding(3, 2, 3, 2);
            chbArchived.Name = "chbArchived";
            chbArchived.Size = new Size(73, 19);
            chbArchived.TabIndex = 6;
            chbArchived.Text = "Archived";
            chbArchived.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { connectionsToolStripMenuItem, actionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1395, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // connectionsToolStripMenuItem
            // 
            connectionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageConnectionsToolStripMenuItem });
            connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            connectionsToolStripMenuItem.Size = new Size(86, 20);
            connectionsToolStripMenuItem.Text = "Connections";
            // 
            // manageConnectionsToolStripMenuItem
            // 
            manageConnectionsToolStripMenuItem.Name = "manageConnectionsToolStripMenuItem";
            manageConnectionsToolStripMenuItem.Size = new Size(187, 22);
            manageConnectionsToolStripMenuItem.Text = "Manage Connections";
            manageConnectionsToolStripMenuItem.Click += manageConnectionsToolStripMenuItem_Click;
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { updateTasksToolStripMenuItem, saveTaskInformationToolStripMenuItem });
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(59, 20);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // updateTasksToolStripMenuItem
            // 
            updateTasksToolStripMenuItem.Name = "updateTasksToolStripMenuItem";
            updateTasksToolStripMenuItem.ShortcutKeys = Keys.F3;
            updateTasksToolStripMenuItem.Size = new Size(231, 22);
            updateTasksToolStripMenuItem.Text = "Update Tasks";
            updateTasksToolStripMenuItem.Click += updateTasksToolStripMenuItem_Click;
            // 
            // saveTaskInformationToolStripMenuItem
            // 
            saveTaskInformationToolStripMenuItem.Name = "saveTaskInformationToolStripMenuItem";
            saveTaskInformationToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveTaskInformationToolStripMenuItem.Size = new Size(231, 22);
            saveTaskInformationToolStripMenuItem.Text = "Save Task Information";
            saveTaskInformationToolStripMenuItem.Click += saveTaskInformationToolStripMenuItem_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(948, 64);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 9;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(948, 88);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(948, 156);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Category";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(948, 199);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(38, 15);
            lblNotes.TabIndex = 12;
            lblNotes.Text = "Notes";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "waiting", "inprogress", "ready" });
            cmbCategory.Location = new Point(1025, 150);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(133, 23);
            cmbCategory.TabIndex = 13;
            // 
            // btnToggleArchive
            // 
            btnToggleArchive.Location = new Point(948, 176);
            btnToggleArchive.Margin = new Padding(3, 2, 3, 2);
            btnToggleArchive.Name = "btnToggleArchive";
            btnToggleArchive.Size = new Size(184, 22);
            btnToggleArchive.TabIndex = 14;
            btnToggleArchive.Text = "Archive/Dearchive";
            btnToggleArchive.UseVisualStyleBackColor = true;
            btnToggleArchive.Click += btnToggleArchive_Click_1;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(1025, 88);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(364, 58);
            txtDescription.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(1025, 58);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(363, 23);
            txtName.TabIndex = 16;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(948, 33);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 17;
            lblId.Text = "Id:";
            // 
            // lblIdValue
            // 
            lblIdValue.AutoSize = true;
            lblIdValue.Location = new Point(1025, 32);
            lblIdValue.Name = "lblIdValue";
            lblIdValue.Size = new Size(0, 15);
            lblIdValue.TabIndex = 18;
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNotes.Location = new Point(948, 223);
            txtNotes.Margin = new Padding(3, 2, 3, 2);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(437, 202);
            txtNotes.TabIndex = 19;
            txtNotes.TextChanged += txtNotes_TextChanged;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.ForeColor = Color.Red;
            lblArchived.Location = new Point(1329, 182);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(54, 15);
            lblArchived.TabIndex = 20;
            lblArchived.Text = "Archived";
            lblArchived.Visible = false;
            // 
            // lblSavedState
            // 
            lblSavedState.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSavedState.AutoSize = true;
            lblSavedState.ForeColor = Color.Green;
            lblSavedState.Location = new Point(1351, 36);
            lblSavedState.Name = "lblSavedState";
            lblSavedState.Size = new Size(38, 15);
            lblSavedState.TabIndex = 21;
            lblSavedState.Text = "Saved";
            lblSavedState.TextAlign = ContentAlignment.TopRight;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 433);
            Controls.Add(lblSavedState);
            Controls.Add(lblArchived);
            Controls.Add(txtNotes);
            Controls.Add(lblIdValue);
            Controls.Add(lblId);
            Controls.Add(txtName);
            Controls.Add(txtDescription);
            Controls.Add(btnToggleArchive);
            Controls.Add(cmbCategory);
            Controls.Add(lblNotes);
            Controls.Add(lblCategory);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(chbArchived);
            Controls.Add(lblReady);
            Controls.Add(lblInProgress);
            Controls.Add(lblWaiting);
            Controls.Add(gridReady);
            Controls.Add(gridProgress);
            Controls.Add(gridWaiting);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMain";
            Text = "You Can!";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmMain_FormClosed_1;
            Load += frmMain_Load_1;
            ((System.ComponentModel.ISupportInitialize)gridWaiting).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridProgress).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridReady).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridWaiting;
        private DataGridView gridProgress;
        private DataGridView gridReady;
        private Label lblWaiting;
        private Label lblInProgress;
        private Label lblReady;
        private CheckBox chbArchived;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem connectionsToolStripMenuItem;
        private ToolStripMenuItem manageConnectionsToolStripMenuItem;
        private Label lblName;
        private Label lblDescription;
        private Label lblCategory;
        private Label lblNotes;
        private ComboBox cmbCategory;
        private Button btnToggleArchive;
        private TextBox txtDescription;
        private TextBox txtName;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem updateTasksToolStripMenuItem;
        private ToolStripMenuItem saveTaskInformationToolStripMenuItem;
        private Label lblId;
        private Label lblIdValue;
        private TextBox txtNotes;
        private Label lblArchived;
        private Label lblSavedState;
    }
}
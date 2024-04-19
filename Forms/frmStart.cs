using YouCanBan.classes;
using YouCanBan.classes.db;
using YouCanBan.Forms;

namespace YouCanBan
{
    public partial class frmStart : Form
    {
        public bool connectionSuccess = false;
        public ConnectionsReader cr;
        public frmStart()
        {
            InitializeComponent();
            FillComboBox();
        }

        // new change
        // write a method that fills the combobox with the connections
        private void FillComboBox()
        {
            // create a new instance of the ConnectionsReader class
            cr = new ConnectionsReader();
            // loop through the connections and add them to the combobox
            foreach (Connection connection in cr.connections)
            {
                // use connectionID as the value and connectionName as the display text
                cmbConnections.ValueMember = connection.connectionID.ToString();
                cmbConnections.DisplayMember = connection.connectionName;

                // add the connection to the combobox
                cmbConnections.Items.Add(connection.connectionName);

                // if the connection is the active connection, select it in the combobox
                if (connection.connectionID == cr.active_connection.connectionID)
                {
                    cmbConnections.SelectedItem = connection.connectionName;
                }


            }
        }

        private void btnManageConnections_Click(object sender, EventArgs e)
        {
            // show the manage connections form

            frmManageConnections manageConnections = new frmManageConnections();
            manageConnections.connectionsReader = cr;
            manageConnections.FillGrid();
            manageConnections.Show();
        }

        private void btnCreateNewDB_Click(object sender, EventArgs e)
        {
            // open frmnewconnection form
            frmNewConnection frmNewConnection = new frmNewConnection();
            frmNewConnection.isANewDatabase = true;
            if (frmNewConnection.ShowDialog() == DialogResult.OK && frmNewConnection.newConnection != null)
            {
                connectionSuccess = true;
                // add the new connection to the list of connections of connectionsreader

                cr.connections.Add(frmNewConnection.newConnection);
                cr.SaveConnectionsToFile();

                cmbConnections.Items.Clear();
                foreach (Connection connection in cr.connections)
                {
                    // use connectionID as the value and connectionName as the display text
                    cmbConnections.ValueMember = connection.connectionID.ToString();
                    cmbConnections.DisplayMember = connection.connectionName;

                    // add the connection to the combobox
                    cmbConnections.Items.Add(connection.connectionName);

                    // if the connection is the active connection, select it in the combobox
                    if (cr.active_connection != null && connection.connectionID == cr.active_connection.connectionID)
                    {
                        cmbConnections.SelectedItem = connection.connectionName;
                    }


                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open frmnewconnection form
            frmNewConnection frmNewConnection = new frmNewConnection();
            frmNewConnection.isANewDatabase = false;
            if (frmNewConnection.ShowDialog() == DialogResult.OK && frmNewConnection.newConnection != null)
            {
                connectionSuccess = true;
                cr.connections.Add(frmNewConnection.newConnection);
                cr.SaveConnectionsToFile();

                cmbConnections.Items.Clear();
                foreach (Connection connection in cr.connections)
                {
                    // use connectionID as the value and connectionName as the display text
                    cmbConnections.ValueMember = connection.connectionID.ToString();
                    cmbConnections.DisplayMember = connection.connectionName;

                    // add the connection to the combobox
                    cmbConnections.Items.Add(connection.connectionName);

                    // if the connection is the active connection, select it in the combobox
                    if (cr.active_connection != null && connection.connectionID == cr.active_connection.connectionID)
                    {
                        cmbConnections.SelectedItem = connection.connectionName;
                    }
                }
            }
        }

        private void btnConnectEx_Click(object sender, EventArgs e)
        {
            // close this window and open frmMain form
            if (cmbConnections.SelectedItem != null)
            {
                cr.active_connection = cr.connections[cmbConnections.SelectedIndex];
                cr.SaveConnectionsToFile();
                frmMain frmMain = new frmMain();
                frmMain.connectionString = cr.active_connection.connString;
                frmMain.UpdateDataSource();
                frmMain.Show();
                this.Close();
                //this.Hide();

            }
            else
            {
                MessageBox.Show("Please select a connection");
            }
        }

        private void btnStartClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            Application.Exit();
        }
    }
}
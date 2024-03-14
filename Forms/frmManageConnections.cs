using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouCanBan.classes;
using YouCanBan.classes.db;

namespace YouCanBan.Forms
{
    public partial class frmManageConnections : Form
    {
        public ConnectionsReader connectionsReader;
        public frmManageConnections()
        {
            InitializeComponent();
        }

        private void btnAddConnection_Click(object sender, EventArgs e)
        {
            // open frmnewconnection form
            frmNewConnection frmNewConnection = new frmNewConnection();
            frmNewConnection.ShowDialog();
        }

        // write a method that fills the gridConnections with the connections from the connectionsReader
        public void FillGrid()
        {
            // clear the grid
            gridConnections.Rows.Clear();
            // loop through the connections and add them to the grid
            foreach (Connection connection in connectionsReader.connections)
            {
                // add the connection to the grid
                if (connectionsReader.active_connection != null && connectionsReader.active_connection.connectionID == connection.connectionID)
                {
                    gridConnections.Rows.Add(connection.connectionName, connection.connType, connection.server, connection.port, connection.database, connection.user, connection.password, "1", connection.connectionID);
                }
                else
                {
                    gridConnections.Rows.Add(connection.connectionName, connection.connType, connection.server, connection.port, connection.database, connection.user, connection.password, "0", connection.connectionID);
                } 
            }
        }

        private void frmManageConnections_FormClosed(object sender, FormClosedEventArgs e)
        {
            // convert the grid connections to a list of connections of connectionsReader
            connectionsReader.connections = new List<Connection>();
            foreach (DataGridViewRow row in gridConnections.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    continue;
                }
                Connection connection = new Connection(const_type: "prog", connectionName: row.Cells[0].Value.ToString(), connType: row.Cells[1].Value.ToString(), server: row.Cells[2].Value.ToString(), _port: row.Cells[3].Value.ToString(), database: row.Cells[4].Value.ToString(), user: row.Cells[5].Value.ToString(),
                                                                      password: row.Cells[6].Value.ToString(), guid_string: row.Cells[8].Value.ToString());
                connectionsReader.connections.Add(connection);
                if (row.Cells[7].Value.ToString() == "1")
                {
                    connectionsReader.active_connection = connection;
                }
            }

            connectionsReader.SaveConnectionsToFile();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            // check if a connection is selected from the grid
            if (gridConnections.SelectedRows.Count == 1)
            {
                // get the selected connection from the grid
                Connection connection = new Connection(const_type: "prog", connectionName: gridConnections.SelectedRows[0].Cells[0].Value.ToString(), connType: gridConnections.SelectedRows[0].Cells[1].Value.ToString(), server: gridConnections.SelectedRows[0].Cells[2].Value.ToString(), _port: gridConnections.SelectedRows[0].Cells[3].Value.ToString(), database: gridConnections.SelectedRows[0].Cells[4].Value.ToString(), user: gridConnections.SelectedRows[0].Cells[5].Value.ToString(),
                                                                                         password: gridConnections.SelectedRows[0].Cells[6].Value.ToString(), guid_string: gridConnections.SelectedRows[0].Cells[8].Value.ToString());

                if (Connection.TestConnection(connection))
                {
                    MessageBox.Show("Connection successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Connection failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a connection from the grid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

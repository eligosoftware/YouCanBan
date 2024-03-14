using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouCanBan.classes;

namespace YouCanBan.Forms
{
    public partial class frmMain : Form
    {
        public string connectionString;
        public bool waitingFillBlock = false;
        public bool inprogressFillBlock = false;
        public bool readyFillBlock = false;

        private int idIsArchived = -1;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void manageConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open frmManageConnections form
            frmManageConnections frmManageConnections = new frmManageConnections();
            frmManageConnections.connectionsReader = new ConnectionsReader();
            frmManageConnections.FillGrid();
            frmManageConnections.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {




        }

        public void UpdateDataSource(string type = "all")
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query;
            SqlDataAdapter da_waiting;
            DataTable dt_waiting;
            SqlDataAdapter da_inprogress;
            DataTable dt_inprogress;

            SqlDataAdapter da_ready;
            DataTable dt_ready;


            try
            {
                connection.Open();
                if (type == "all" || type == "waiting")
                {
                    if (!chbArchived.Checked)
                    {
                        query = "select name,priority, id from dbo.Task where category = 'waiting' and archived = 0 order by priority";
                    }
                    else
                    {

                        query = "select name,priority, id from dbo.Task where category = 'waiting' order by priority";
                    }
                    da_waiting = new SqlDataAdapter(query, connection);
                    dt_waiting = new DataTable();
                    waitingFillBlock = true;
                    da_waiting.Fill(dt_waiting);
                    gridWaiting.DataSource = dt_waiting;
                    waitingFillBlock = false;
                    gridWaiting.Columns["id"].ReadOnly = true;
                }

                if (type == "all" || type == "inprogress")
                {
                    if (!chbArchived.Checked)
                    {
                        query = "select name,priority, id from dbo.Task where category = 'inprogress' and archived = 0 order by priority";
                    }
                    else
                    {

                        query = "select name,priority, id from dbo.Task where category = 'inprogress' order by priority";
                    }
                    da_inprogress = new SqlDataAdapter(query, connection);
                    dt_inprogress = new DataTable();
                    inprogressFillBlock = true;
                    da_inprogress.Fill(dt_inprogress);
                    gridProgress.DataSource = dt_inprogress;
                    inprogressFillBlock = false;
                    gridProgress.Columns["id"].ReadOnly = true;
                }

                if (type == "all" || type == "ready")
                {
                    if (!chbArchived.Checked)
                    {
                        query = "select name,priority, id from dbo.Task where category = 'ready' and archived = 0 order by priority";
                    }
                    else
                    {

                        query = "select name,priority, id from dbo.Task where category = 'ready' order by priority";
                    }
                    da_ready = new SqlDataAdapter(query, connection);
                    dt_ready = new DataTable();
                    readyFillBlock = true;
                    da_ready.Fill(dt_ready);
                    gridReady.DataSource = dt_ready;
                    readyFillBlock = false;
                    gridReady.Columns["id"].ReadOnly = true;
                }

                //     MessageBox.Show("Database created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

        }

        private void gridReady_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row and column are clicked
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the DataGridView that triggered the event
                DataGridView dataGridView = (DataGridView)sender;

                // Get the selected row
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                // Now you have the selected row, you can access its data
                // For example, to get the value from the first column:
                string id = selectedRow.Cells[2].Value.ToString();

                if (id != "")
                {
                    UpdateTaskInformation(Convert.ToInt32(id));
                }
                else
                {
                    // clear the textboxes
                    lblIdValue.Text = "";
                    txtName.Text = "";
                    txtDescription.Text = "";
                    cmbCategory.SelectedItem = null;
                    txtNotes.Text = "";
                    idIsArchived = -1;

                }
                // Do something with the selected row or its data
                // Example: Display the value in a MessageBox
                //MessageBox.Show(value);
            }
        }

        // write a method that updates the contents of textbox with the result of select query from the database if the id is given
        private void UpdateTaskInformation(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query;
            SqlDataAdapter da;
            DataTable dt;
            try
            {
                connection.Open();
                query = "select * from dbo.Task where id = @Id";
                da = new SqlDataAdapter(query, connection);
                da.SelectCommand.Parameters.AddWithValue("@Id", id);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    lblIdValue.Text = row["id"].ToString();
                    txtName.Text = row["name"].ToString();
                    txtDescription.Text = row["description"].ToString();

                    // set the selected category in the combobox cmbCategory
                    cmbCategory.SelectedItem = row["category"].ToString();

                    if (bool.Parse(row["archived"].ToString()))
                    {
                        idIsArchived = 1;
                    }
                    else
                    {
                        idIsArchived = 0;
                    }

                    lblArchived.Visible = idIsArchived == 1;

                    // set the richtextbox text to the notes
                    txtNotes.Text = row["notes"].ToString();
                }
                //     MessageBox.Show("Database created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }


        private void gridProgress_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //if(!inprogressFillBlock && e.RowIndex != 0)
            //    AddTask(sender, e, state: "inprogress");
        }




        private void AddTask(object sender, DataGridViewRowsAddedEventArgs e, string state)
        {

            // Get the DataGridView
            DataGridView dataGridView = (DataGridView)sender;

            // Get the index of the last added row
            int lastIndex = e.RowIndex + e.RowCount - 1;

            // Get the data source (assuming it's a DataTable)
            DataTable dt = (DataTable)dataGridView.DataSource;



            // Get the added row(s)
            for (int i = e.RowIndex; i <= lastIndex; i++)
            {
                DataGridViewRow row = dataGridView.Rows[i];

                // Extract data from the row
                int priority = Convert.ToInt32(row.Cells["priority"].Value);

                // Perform database insertion
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO dbo.Task (priority, category, archived) VALUES (@Priority, @State, 0)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Priority", priority);
                    command.Parameters.AddWithValue("@State", state);
                    command.ExecuteNonQuery();
                }
            }

            UpdateDataSource();
        }

        private void gridReady_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //if (!readyFillBlock && e.RowIndex!=0)
            //    AddTask(sender,e, state: "ready");
        }

        private void gridWaiting_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //if (!waitingFillBlock && e.RowIndex != 0)
            //    AddTask(sender, e, state: "waiting");
        }

        private void updateTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTasks("inprogress");
            UpdateTasks("ready");
            UpdateTasks("waiting");
            UpdateDataSource();
        }

        // write a method that updates the contents of the gridProgress to the database, if id is empty adds new row to db,
        // if not, updates the row in db
        private void UpdateTasks(string state)
        {
            // Get the DataGridView
            DataGridView dataGridView;
            if (state == "inprogress")
            {
                dataGridView = gridProgress;
            }
            else if (state == "ready")
            {
                dataGridView = gridReady;
            }
            else
            {
                dataGridView = gridWaiting;
            }

            // Get the data source (assuming it's a DataTable)
            DataTable dt = (DataTable)dataGridView.DataSource;

            // Get the added row(s)
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Extract data from the row
                int id = 0;
                if (row.Cells["id"].Value == DBNull.Value && row.Cells["priority"].Value == DBNull.Value)
                    continue;
                if (row.Cells["id"].Value == null && row.Cells["priority"].Value == null)
                    continue;
                if (row.Cells["id"].Value != DBNull.Value)
                    id = Convert.ToInt32(row.Cells["id"].Value);
                int priority = Convert.ToInt32(row.Cells["priority"].Value);
                string name = row.Cells["name"].Value.ToString();

                // Perform database insertion
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query;
                    if (id == 0)
                    {
                        query = "INSERT INTO dbo.Task (name, priority, category, archived) VALUES (@Name, @Priority, @State, 0)";
                    }
                    else
                    {
                        query = "UPDATE dbo.Task SET priority = @Priority, name =@Name WHERE id = @Id";
                    }
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Priority", priority);
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@State", state);
                    command.ExecuteNonQuery();
                }
            }


        }

        private void saveTaskInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblIdValue.Text != "")
            {
                SaveTaskInformation();
            }
        }

        // write a method that updates the contents of the database with the contents of the textbox and richtextbox
        private void SaveTaskInformation()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query;
            SqlDataAdapter da;
            DataTable dt;
            try
            {
                connection.Open();
                query = "UPDATE dbo.Task SET name = @Name, description = @Description, category = @Category, notes = @Notes, archived = @Archived WHERE id = @Id";
                da = new SqlDataAdapter(query, connection);
                da.SelectCommand.Parameters.AddWithValue("@Name", txtName.Text);
                da.SelectCommand.Parameters.AddWithValue("@Description", txtDescription.Text);
                da.SelectCommand.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem.ToString());
                da.SelectCommand.Parameters.AddWithValue("@Notes", txtNotes.Text);
                da.SelectCommand.Parameters.AddWithValue("@Id", Convert.ToInt32(lblIdValue.Text));

                da.SelectCommand.Parameters.AddWithValue("@Archived", idIsArchived);
                dt = new DataTable();
                da.Fill(dt);
                //     MessageBox.Show("Database created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnToggleArchive_Click(object sender, EventArgs e)
        {

        }

        private void btnToggleArchive_Click_1(object sender, EventArgs e)
        {
            if (lblIdValue.Text != "")
            {
                ToggleArchive();
            }
        }

        private void ToggleArchive()
        {
            if (idIsArchived == 1)
            {
                idIsArchived = 0;
            }
            else
            {
                idIsArchived = 1;
            }

            lblArchived.Visible = idIsArchived == 1;
        }
    }
}

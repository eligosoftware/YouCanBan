using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using YouCanBan.classes.db;

namespace YouCanBan.Forms
{
    public partial class frmNewConnection : Form
    {
        public Connection newConnection = null;
        public bool isANewDatabase = false;

        public frmNewConnection()
        {
            InitializeComponent();
        }

        

        // write a method to create a database using the form data
        private string CreateDatabase()
        {
            //string connectionString = "Data Source=" + txtServer.Text + ";Initial Catalog=master;Integrated Security=True";
            //string connectionString = $"Data Source={txtServer.Text.Trim()},{txtPort.Text.Trim()};Initial Catalog=master;User ID={txtUsername.Text.Trim()};Password={txtPassword.Text.Trim()};";    
            string connectionString = $"Data Source={txtServer.Text.Trim()};Initial Catalog=master;User ID={txtUsername.Text.Trim()};Password={txtPassword.Text.Trim()};";

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "CREATE DATABASE " + txtDatabase.Text;
            SqlCommand command = new SqlCommand(query, connection);
            string db_name;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                db_name = txtDatabase.Text;
           //     MessageBox.Show("Database created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                newConnection = null;

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db_name = null;
            }
            finally
            {
                connection.Close();
            }
            return db_name;
        }

        static string ReadEmbeddedResourceText(string resourceName)
        {
            string result;

            // Get the current assembly
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Read the resource stream
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                    throw new InvalidOperationException("Resource not found: " + resourceName);

                // Read the stream content
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }

            return result;
        }

        private void CreateTables(string db_name)
        {
            string connectionString = $"Data Source={txtServer.Text.Trim()};Initial Catalog={txtDatabase.Text.Trim()};User ID={txtUsername.Text.Trim()};Password={txtPassword.Text.Trim()};";
           // string connectionString = $"Data Source={txtServer.Text.Trim()},{txtPort.Text.Trim()};Initial Catalog={txtDatabase.Text.Trim()};User ID={txtUsername.Text.Trim()};Password={txtPassword.Text.Trim()};";

            SqlConnection connection = new SqlConnection(connectionString);

            // read string from the resource text file
            //string resourceName = "createdatabase_statement.txt"; // Change to your namespace and text file name

            //string query = //ReadEmbeddedResourceText(resourceName);



            string query = @"
            use "+db_name+
            @"-- Create Category table
            -- CREATE TABLE Category (
            --     id INT PRIMARY KEY IDENTITY(1,1),
            --     name NVARCHAR(255) NOT NULL,
            --     description NVARCHAR(255),
            --     header_color NVARCHAR(50),
            --     body_color NVARCHAR(50),
            --     archived BIT NOT NULL DEFAULT 0,
            -- );

            -- Create Task table
            CREATE TABLE Task (
                id INT PRIMARY KEY IDENTITY(1,1),
                priority INTEGER NOT NULL DEFAULT 1,
                name NVARCHAR(255) NOT NULL,
                description NVARCHAR(255),
                category VARCHAR(20),
                notes NVARCHAR(max),
                archived BIT NOT NULL DEFAULT 0 -- ,
            --    FOREIGN KEY (categoryID) REFERENCES Category(id)
            );
            -- CREATE TABLE TaskDocuments (
            --     id INT PRIMARY KEY IDENTITY(1,1),
            --     name NVARCHAR(255) NOT NULL,
            --     description VARCHAR(255),
            --     taskID INTEGER,
            --     extension NVARCHAR(20) NOT NULL,
            --     documentData NVARBINARY(MAX),
            --     archived BIT NOT NULL DEFAULT 0,
            --     FOREIGN KEY (taskID) REFERENCES Task(id)
            -- );
            CREATE TABLE youCanBan_data (
                dummyId int
            );

";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                //MessageBox.Show("Table created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // create new Connection object
                newConnection = new Connection(const_type: "prog", server: txtServer.Text.Trim(),
                    database: txtDatabase.Text.Trim(), _port: txtPort.Text.Trim(),
                    user: txtUsername.Text.Trim(), password: txtPassword.Text.Trim(),
                    connType: "local",connectionName: "Local SQL Server "+txtServer.Text.Trim(),
                    // generate a new guid string
                    guid_string: Guid.NewGuid().ToString());


            
            }
            catch (Exception ex)
            {
                newConnection = null;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void TestDBExists()
        {
            string connectionString = $"Data Source={txtServer.Text.Trim()};Initial Catalog={txtDatabase.Text.Trim()};User ID={txtUsername.Text.Trim()};Password={txtPassword.Text.Trim()};";
            // string connectionString = $"Data Source={txtServer.Text.Trim()},{txtPort.Text.Trim()};Initial Catalog={txtDatabase.Text.Trim()};User ID={txtUsername.Text.Trim()};Password={txtPassword.Text.Trim()};";

            SqlConnection connection = new SqlConnection(connectionString);

            // read string from the resource text file
            //string resourceName = "createdatabase_statement.txt"; // Change to your namespace and text file name

            //string query = //ReadEmbeddedResourceText(resourceName);



            string query = @"
            use youcanban_db;
            
            select * from youCanBan_data;
            ";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                command.ExecuteReader();
                //MessageBox.Show("Table created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // create new Connection object
                newConnection = new Connection(const_type: "prog", server: txtServer.Text.Trim(),
                    database: txtDatabase.Text.Trim(), _port: txtPort.Text.Trim(),
                    user: txtUsername.Text.Trim(), password: txtPassword.Text.Trim(),
                    connType: "local", connectionName: "Local SQL Server " + txtServer.Text.Trim(),
                    // generate a new guid string
                    guid_string: Guid.NewGuid().ToString());



            }
            catch (Exception ex)
            {
                newConnection = null;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (isANewDatabase)
            {
                string db_name =CreateDatabase();
                if (db_name != null) {
                    CreateTables(db_name);
                }
                
            }
            else { 
            TestDBExists();
            
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}

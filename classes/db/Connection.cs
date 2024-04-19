using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouCanBan.classes.db
{
    
    public class Connection
    {
        public string connString;
        public string connType;
        public string connectionName;
        public Guid connectionID;
        public string server;
        public string database;
        public string user;
        public string password;
        public string port;

        // generate a constructor
        public Connection(string const_type,string server, string database, string _port, string user, string password, string connType, string connectionName, string guid_string)
        {
            if (const_type == "from_con_str")
            {
                this.connectionID = Guid.Parse(guid_string.Split("=")[1]);
                this.server = server.Split("=")[1];
                this.database = database.Split("=")[1];
                this.user = user.Split("=")[1];
                this.password = password.Split("=")[1];
                this.connType = connType.Split("=")[1];
                this.connectionName = connectionName.Split("=")[1];
                this.port = _port.Split("=")[1]; ;
            }
            else if (const_type == "prog")
            {
                this.connectionID = Guid.Parse(guid_string);
                this.server = server;
                this.database = database;
                this.user = user;
                this.password = password;
                this.connType = connType;
                this.connectionName = connectionName;
                this.port = _port;
            }
            
            //connString = "Server=" + server + ";Database=" + database + ";User Id=" + user + ";Password=" + password + ";Port=" + port + ";";
            connString = $"Data Source={this.server};Initial Catalog={this.database};User ID={this.user};Password={this.password};";
        }

        public static bool TestConnection(Connection _connection)
        {
            string connectionString = _connection.connString;
            // string connectionString = $"Data Source={txtServer.Text.Trim()},{txtPort.Text.Trim()};Initial Catalog={txtDatabase.Text.Trim()};User ID={txtUsername.Text.Trim()};Password={txtPassword.Text.Trim()};";

            SqlConnection connection = new SqlConnection(connectionString);

            // read string from the resource text file
            //string resourceName = "createdatabase_statement.txt"; // Change to your namespace and text file name

            //string query = //ReadEmbeddedResourceText(resourceName);



            string query = @"
            use "+ _connection.database+ @";
            
            select * from youCanBan_data;
            ";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                command.ExecuteReader();
                //MessageBox.Show("Table created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                return false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}

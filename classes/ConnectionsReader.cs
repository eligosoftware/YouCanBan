using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouCanBan.classes.db;

namespace YouCanBan.classes
{
    public class ConnectionsReader
    {
        public Connection active_connection;
        public List<Connection> connections;

        public ConnectionsReader()
        {
            // read the file connList.config from the appdata folder of my application and
            // create a list of connections from it
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string yourAppDataPath = System.IO.Path.Combine(appDataPath, "YouCanBan");

            connections = new List<Connection>();
            // Check if directory exists
            if (!Directory.Exists(yourAppDataPath))
            {
                // If it doesn't exist, create it
                Directory.CreateDirectory(yourAppDataPath);
            }
            else
            {
                //@"Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;"
                if (File.Exists(Path.Combine(yourAppDataPath, "connList.config")))
                {
                    string[] lines = System.IO.File.ReadAllLines(Path.Combine(yourAppDataPath, "connList.config"));
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(';');
                        //
                        Connection connection = new Connection(const_type: "from_con_str", server: parts[0], database: parts[1], _port: parts[2], user: parts[3],
                                                           password: parts[4], connType: parts[5], connectionName: parts[6], guid_string: parts[7]);

                        connections.Add(connection);

                        if (parts[8].Split("=")[1]=="1")
                        {
                            active_connection = connection;
                        }
                    }
                }

            }

        }

        // write a method that saves the connections to the file connList.config
        public void SaveConnectionsToFile()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string yourAppDataPath = System.IO.Path.Combine(appDataPath, "YouCanBan");

            // Check if directory exists
            if (!Directory.Exists(yourAppDataPath))
            {
                // If it doesn't exist, create it
                Directory.CreateDirectory(yourAppDataPath);
            }
            else
            {
                //@"Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;"
                if (File.Exists(Path.Combine(yourAppDataPath, "connList.config")))
                {
                    File.Delete(Path.Combine(yourAppDataPath, "connList.config"));
                }
                using (StreamWriter sw = File.CreateText(Path.Combine(yourAppDataPath, "connList.config")))
                {
                    foreach (Connection connection in connections)
                    {
                       
                        //sw.WriteLine(connection.connString + ";" + connection.connectionName + ";" + connection.connectionID + ";" + active);
                        
                        if (connection == active_connection)
                        {
                            sw.WriteLine($"server={connection.server};database={connection.database};port={connection.port};user={connection.user};password={connection.password};connType={connection.connType};connectionName={connection.connectionName};guidString={connection.connectionID};active=1");
                        }
                        else
                        {
                            sw.WriteLine($"server={connection.server};database={connection.database};port={connection.port};user={connection.user};password={connection.password};connType={connection.connType};connectionName={connection.connectionName};guidString={connection.connectionID};active=0");
                        }
                        

                    }
                }
            }
        }
    }
}

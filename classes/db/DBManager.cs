using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.HadrData;
using Microsoft.SqlServer.Management.Smo;

namespace YouCanBan.classes.db
{
    internal class DBManager
    {
        public static bool RestoreDatabase(string server,
            string databaseName,
            string username,
            string password,
            string backupPath)
        {
            bool result = false;

            try
            {
                ServerConnection conn = new ServerConnection(server,username,password);
                Server srv = new Server(conn);

                // Perform restore operation
                Restore restore = new Restore();
                restore.Database = databaseName;
                restore.Action = RestoreActionType.Database;
                restore.Devices.AddDevice(backupPath, DeviceType.File);

                srv.KillAllProcesses(databaseName); // Kill existing connections to the database
                restore.ReplaceDatabase = true;
                restore.SqlRestore(srv);

                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }
            
            return result;

        }


        public static bool BackupDatabase(string server,
            string databaseName,
            string username,
            string password,
            string backupPath)
        {
            bool result = false;

            try
            {
                ServerConnection conn = new ServerConnection(server, username, password);
                Server srv = new Server(conn);
                Backup backup = new Backup
                {
                    Action = BackupActionType.Database,
                    Database = databaseName
                };

                //backup.Devices.AddDevice(backupPath, DeviceType.File);
                BackupDeviceItem destination = new BackupDeviceItem(backupPath, DeviceType.File);
                backup.Devices.Add(destination);


                //srv.KillAllProcesses(databaseName); // Kill existing connections to the database

                backup.SqlBackup(srv);

                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }

            return result;

        }
    }

    
}

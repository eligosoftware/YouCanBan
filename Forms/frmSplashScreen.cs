using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YouCanBan.classes;
using YouCanBan.classes.db;
using YouCanBan.Forms;


namespace YouCanBan
{


    public partial class frmSplashScreen : Form
    {
        public bool connectionSuccess= false;
        public string activeConnectionString;
        //System.Windows.Forms.Timer timer;
        public frmSplashScreen()
        {
            InitializeComponent();

            lblVersion.Text = "Version 1.0.0";


            this.BackgroundImage = Properties.Resources.youcanban_logo2;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            // lblVersion.BringToFront();




            //Erstellen Sie einen Timer
            //timer = new System.Windows.Forms.Timer();
            //timer.Interval = 3000; // Setzen Sie das Intervall auf 3 Sekunden
            //timer.Tick += Timer_Tick;

            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string yourAppDataPath = Path.Combine(appDataPath, "YouCanBan");

            // Check if directory exists
            if (!Directory.Exists(yourAppDataPath))
            {
                // If it doesn't exist, create it
                //Directory.CreateDirectory(yourAppDataPath);
                connectionSuccess = false;
                //Close();
            }
            else
            {
                //ConnectionsReader cr = new ConnectionsReader();
                InitConnectionsReader();
            }


        }

        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    // Stoppen Sie den Timer und schließen Sie das Formular, wenn der Timer abgelaufen ist
        //    timer.Stop();
        //    this.Close();
        //}

        // write a method that inits the connectionsreader and checks if the active connection is valid
        private void InitConnectionsReader()
        {
            // create a new instance of the ConnectionsReader class
            ConnectionsReader cr = new ConnectionsReader();
            // if the active connection is not valid, show the start form
            if (cr.active_connection == null)
            {
                connectionSuccess = false;
                //frmStart frmStart = new frmStart();
                //frmStart.Show();
            }
            else
            {
                connectionSuccess = Connection.TestConnection(cr.active_connection);
                if (connectionSuccess)
                {
                    activeConnectionString = cr.active_connection.connString;
                }   
            }
        }

        // write a method that test the connection by querying the database against table 


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //timer.Start();
        }
    }
}

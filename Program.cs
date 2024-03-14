using System.Threading;
using YouCanBan.Forms;

namespace YouCanBan
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            //string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //string yourAppDataPath = Path.Combine(appDataPath, "YourAppName");

            //// Check if directory exists
            //if (!Directory.Exists(yourAppDataPath))
            //{
            //    // If it doesn't exist, create it
            //    Directory.CreateDirectory(yourAppDataPath);
            //}

            //// Now you can save your data in the 'yourAppDataPath' directory
            //string filePath = Path.Combine(yourAppDataPath, "yourfile.txt");
            //File.WriteAllText(filePath, "Your data");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the splash screen
            frmSplashScreen splashScreen = new frmSplashScreen();

            // Show the main form after the splash screen is closed
            //splashScreen.FormClosed += (sender, e) =>
            //{
                
            //};

            //Application.Run(splashScreen);
            splashScreen.Show();

            // Create a timer to close the splash screen after 3 seconds
            System.Threading.Timer timer = new System.Threading.Timer((state) =>
            {
                // After the timer interval elapses, close the splash screen
                splashScreen.Invoke((MethodInvoker)delegate {
                    splashScreen.Close();
                });
            }, null, 3000, Timeout.Infinite);

            // Show the main form after the splash screen is closed
            splashScreen.FormClosed += (sender, e) =>
            {
                Console.WriteLine("Splash screen closed");

                Form frm= null;
                if (splashScreen.connectionSuccess)
                {
                    frm = new frmMain();
                    ((frmMain)frm).connectionString = splashScreen.activeConnectionString;
                    ((frmMain)frm).UpdateDataSource();
                }
                else
                {
                    frm = new frmStart();
                }   


                frm.Show();
            };

            //Application.Run(new frmStart());
            Application.Run();







        }
    }
}
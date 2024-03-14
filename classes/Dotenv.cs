using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouCanBan.classes
{
    internal class Dotenv
    {
        public Dictionary<string, string> env;
       // create a constructor
        public Dotenv()
        {
            // create a dictionary to store the key value pairs
            env = new Dictionary<string, string>();
            // read the file
            string[] lines = System.IO.File.ReadAllLines(".env");
            // loop through the lines
            foreach (string line in lines)
            {
                // split the line into parts
                string[] parts = line.Split('=');
                // check if the line has two parts
                if (parts.Length == 2)
                {
                    // add the key value pair to the dictionary
                    env.Add(parts[0], parts[1]);
                }
            }
            // set the environment variables
            //foreach (var item in env)
            //{
            //    Environment.SetEnvironmentVariable(item.Key, item.Value);
            //}
        }   

    }
}

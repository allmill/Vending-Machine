using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    public class SalesLog
    {
        /* Transactions that occur
         * Start/Ending money
         * Date/Time
         * File name assignment*/
<<<<<<< HEAD
        
=======

        public static void WriteLog(List<string> saleLog)
        {
                string directory = Environment.CurrentDirectory;
                string outputFile = "Log.txt";
                string outputFullPath = Path.Combine(directory, outputFile);
            try
            {
                using (StreamWriter sw = new StreamWriter(outputFullPath))
                {
                    foreach (string sale in saleLog)
                    {
                        sw.WriteLine(sale);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error has occured.");
            }
        }
>>>>>>> 410d1b0c6b0f2f8a3f6003efee731a41f2834b3d
    }
}

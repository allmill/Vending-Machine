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
    }
}

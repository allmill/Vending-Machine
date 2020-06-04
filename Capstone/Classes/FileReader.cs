using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    public class FileReader
    {
        public static string[] inventoryWords;

        /* Importing initial csv
         * Assign values to inventory
         * Update # inventory
         * Redistribute remaining inventory list */

        public static void InventoryImport()
        {
            //FileAssignment variables
            Environment.CurrentDirectory = @"C:\Users\Student\workspace\capstone\csharp-capstone-module-1-team-4";
            string directoryPath = Environment.CurrentDirectory;
            string fileName = "vendingmachine.csv";
            string inventoryPath = Path.Combine(directoryPath, fileName);

            //ReaderVariables
            string selectionLine;
            List<string> allWords = new List<string>();

            //Invenotry Menu variables


            try
            {
                
                using (StreamReader sr = new StreamReader(inventoryPath))
                {
                    while(!sr.EndOfStream)
                    {
                        selectionLine = sr.ReadLine();
                        inventoryWords = selectionLine.Split("|");
                        allWords.AddRange(inventoryWords);

                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading file or file not found");
            }

        }

                        //        if (selectionLine.Contains(**** selectionVariable****))
                        //{


                        //}
        


    }
}

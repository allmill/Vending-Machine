using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    public class FileReader
    {
        public static Dictionary<string, string> CodeAndName;

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
            Dictionary<string,string> dictCodeandName = new Dictionary<string,string>();

            //Invenotry Menu variables


            try
            {
                
                using (StreamReader sr = new StreamReader(inventoryPath))
                {
                    while(!sr.EndOfStream)
                    {
                        selectionLine = sr.ReadLine();
                        string[] inventoryWords = selectionLine.Split("|");
                        allWords.AddRange(inventoryWords);
                        dictCodeandName.Add(inventoryWords[0], inventoryWords[1]);

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

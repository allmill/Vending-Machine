using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    public class FileReader
    {
        //Dictionaries for ivnentory to use, they are stored entirely as strings,
        //will have to convert price to decimal
        public static Dictionary<string, string> CodeAndName;
        public static Dictionary<string, string> NameAndPrice;
        public static Dictionary<string, string> NameAndType;

        /* Importing initial csv
         * Assign values to inventory
         * Update # inventory
         * Redistribute remaining inventory list */

        public static void InventoryImport()
        {
            //FileAssignment variables
            //Environment.CurrentDirectory = @"C:\Users\Student\workspace\capstone\csharp-capstone-module-1-team-4";
            string directoryPath = @"C:\Users\Student\workspace\capstone\csharp-capstone-module-1-team-4";
            string fileName = "vendingmachine.csv";
            string inventoryPath = Path.Combine(directoryPath, fileName);

            //ReaderVariables
            string selectionLine;
            List<string> allWords = new List<string>();

            Dictionary<string,string> dictCodeandName = new Dictionary<string,string>();
            Dictionary<string,string> dictNameandPrice = new Dictionary<string,string>();
            Dictionary<string, string> dictNameandType = new Dictionary<string, string>();



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
                        dictNameandPrice.Add(inventoryWords[1], inventoryWords[2]);
                        dictNameandType.Add(inventoryWords[1], inventoryWords[3]);
                        //allwords.AddRange(inventoryWords);
                        //dictCodeandName.Add(inventoryWords[0], inventoryWords[1]);
                        string slotID = inventoryWords[0];
                        string productName = inventoryWords[1];
                        decimal itemPrice = decimal.Parse(inventoryWords[2]);

                        if (slotID.StartsWith("A"))
                        {
                            List<InventoryItem> chips = new List<InventoryItem>();
                            for (int i=0; i < 5; i++)
                            {
                                chips.Add(new Chips(productName, slotID, itemPrice));
                            }
                        }


                    }

                }
                CodeAndName = dictCodeandName;
                NameAndPrice = dictNameandPrice;
                NameAndType = dictNameandType;

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

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    public class SalesLog
    {
        public static decimal salesFigures;
        /* TODO needs to be called when purchase is made*/
        
        public static void UpdateAuditLog(List<string> auditLog)
        {
            string directory = Environment.CurrentDirectory;
            string outputFile = "Log.txt";
            string outputFullPath = Path.Combine(directory, outputFile);
            try
            {
                using (StreamWriter sw = new StreamWriter(outputFullPath))
                {
                    foreach (string sale in auditLog)
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


        public static void WriteSalesReport(Dictionary<string, int> salesReport, decimal totalSales)
        {
            // Sales report outputs
            salesFigures = totalSales;
            string currentDirectory = Environment.CurrentDirectory;
            string fileName = "SalesReport.txt";
            string filePath = Path.Combine(currentDirectory, fileName);

            try
            {
                // Loop through items and print quantity sold
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (KeyValuePair<string, int> kvp in salesReport)
                    {
                        sw.WriteLine($"{kvp.Key} | {kvp.Value}");
                    }
                    sw.WriteLine();

                    // Print total sales of all products
                    sw.WriteLine($" ***TOTAL SALES*** \n{totalSales:C2}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" An error has occurred");
                Console.ReadLine();
            }

        

        }
        public static void AddNewAudit(string slotID)
        {
            VendingMachine.newAuditEntries.Add($"{DateTime.Today} {VendingMachine.slot[slotID].slotItem[0].ItemName} {VendingMachine.slot[slotID].SlotID} {CashRegister.previousBalance:C2} {CashRegister.balance:C2} ");
        }
    }
}
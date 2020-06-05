﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Classes
{
    public class Menu
    {

        /*prompt
         * display items
         * purchase items
         * Exit
         * Buttons
         * */

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("---- Welcome to the Vendo-Matic 800 ----");
            Console.WriteLine("Please select a number 1 - 3 for the following menu options.");
            Console.WriteLine();
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
            string startingMenuSelect = Console.ReadLine();
            int[] inventoryAmount = new int[5];

            if (startingMenuSelect == "1")
            {
                //display VendingMachine dictionary.ItemName and List.Amount
                FileReader.InventoryImport();
                foreach(KeyValuePair<string, string> kvp in FileReader.CodeAndName)
                {
                        Console.WriteLine();
                        Console.Write(kvp.Key); Console.Write(" : "); Console.Write(kvp.Value); Console.Write("\t" + 5); 
                }
                Console.WriteLine();
                Console.WriteLine("Press a key to return to Main Menu");
                Console.ReadLine();
                MainMenu();

            }
            else if (startingMenuSelect == "2")
            {
                PurchaseMenu();
            }
            else if (startingMenuSelect == "3")
            {
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Not a valid menu selection. Restarting...");
                MainMenu();
            }

        }

        public static void PurchaseMenu()
        {
            Console.Clear();
            Console.WriteLine("---- Purchasing Menu ----");
            Console.WriteLine("Please select a number 1 - 3 for the following menu options.");
            Console.WriteLine();
            Console.WriteLine("(1) Feed Money");
            Console.WriteLine("(2) Select Product");
            Console.WriteLine("(3) Finish Transaction");
            string purchaseMenuSelect = Console.ReadLine();

            if (purchaseMenuSelect == "1")
            {
                CashRegister.TakeInMoney();
            }
            else if (purchaseMenuSelect == "2")
            {
                VendingMachine.VendingSelection();
                // Show list of products available and Customer Enters a code to select. 
                //if code doesnt exist return info and back to PurchaseMenu()
                //if sold out, informed then returned to PurchaseMenu()
                //if valid product selected it is dispensed:
                        //reference call to ISounds,
                        //update balance
                        //update Inventory, 
                        
            }
            else if (purchaseMenuSelect == "3")
            {
                //Customer finalizes all transactions and is returned to the MainMenu()
                //return change - using fewest coins using division and modulus probably
                //Machine current balance should be udpated to 0$ remaining
                //salesLog updated here or in option 2


            MainMenu();
            }
            else
            {
                Console.WriteLine("Not a valid menu selection.");
                PurchaseMenu();
            }

        }

    }
}

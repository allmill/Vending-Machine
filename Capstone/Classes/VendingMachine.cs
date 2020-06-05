using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace Capstone.Classes
{
    public class VendingMachine
    {

        public static List<Chips> chips;
        public static List<Candy> candy;
        public static List<Drinks> drinks;
        public static List<Gum> gum;

        /* Check for selection - valid/invalid/sold out
         * Menu is outward facing part of Vending Machine
         * Vending Machine slots
         * 
        */
        public static string itemSelection;
        public static decimal itemCost;

        public static void VendingSelection()
        {
            Console.Clear();
            Console.WriteLine("Please make your selection");
            Console.WriteLine("Please enter a letter and number to select the item you want.");
            Console.WriteLine("Example: A2");
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in FileReader.CodeAndName)
            {
                Console.WriteLine();
                Console.Write(kvp.Key); Console.Write(" : "); Console.Write(kvp.Value);
            }
            Console.WriteLine();
            Console.WriteLine();
            itemSelection = Console.ReadLine().ToUpper();

            CompareInput();
           




            Console.WriteLine($"Is {itemSelection} in an object or dictionary?");

            //if invalid code state invalid code, restart vendingSelection
            //if itemSelection = itemCode, check inventory amount
            //check balance against cost
            //if good vendingItem() produce object name, cost, new balance, object message

            //return to PurchaseMenu()


        }

        public static void CompareInput()
        {
            foreach (var itemSlot in gum)
            {
                if (itemSelection == Gum.itemSlot)
                {

                }
            }
        }

        public static void VendingItem()
        {

        }
         
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        public static Dictionary<string, Slot> slot = new Dictionary<string, Slot>();
        public static string itemSelection;
        public static decimal itemCost;

        public static void VendingSelection()
        {
            Console.Clear();
            Console.WriteLine("Please make your selection");
            Console.WriteLine("Please enter a letter and number to select the item you want.");
            Console.WriteLine("Example: A2");
            Console.WriteLine();
            foreach (KeyValuePair<string, Slot> kvp in slot)
            {
                Console.WriteLine();
                Console.Write(kvp.Key); Console.Write(" : "); Console.Write(kvp.Value);
            }
            itemSelection = Console.ReadLine().ToUpper();

            Console.WriteLine($"Is {itemSelection} in an object or dictionary?");

            //if invalid code state invalid code, restart vendingSelection
            //if itemSelection = itemCode, check inventory amount
            //check balance against cost
            //if good vendingItem() produce object name, cost, new balance, object message

            //return to PurchaseMenu()


        }

        public static void VendingItem()
        {

        }
         
    }
}

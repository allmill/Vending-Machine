using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

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
            //foreach (KeyValuePair<string, Slot> kvp in slot)
            //{
            //    Console.WriteLine();
            //    Console.Write(kvp.Key); Console.Write(" : "); Console.Write(kvp.Value);
            //}
            foreach (KeyValuePair<string, Slot> kvp in VendingMachine.slot)
            {
                Console.WriteLine();
                Console.Write($"{kvp.Key} : {kvp.Value.slotItem[0].ItemName}"); //the array[0] is throwing selection process off 
            }                                                                   //change this or change CompareInput() criteria
            Console.WriteLine();
            Console.WriteLine();
            itemSelection = Console.ReadLine().ToUpper();

            CompareInput();

            //Console.WriteLine($"Is {itemSelection} in an object or dictionary?");

            //if invalid code state invalid code, restart vendingSelection
            //if itemSelection = itemCode, check inventory amount
            //check balance against cost
            //if good vendingItem() produce object name, cost, new balance, object message

            //return to PurchaseMenu()


        }

        public static void CompareInput()
        {
            foreach (KeyValuePair<string, Slot> kvp in VendingMachine.slot)
            {
                if (itemSelection == kvp.Key && kvp.Value.NumberOfItemsRemaining == 0)
                {
                    Console.WriteLine("Item is sold out. Returning to Purchase Menu. Press any key to continue.");
                    Console.ReadLine();
                    Menu.PurchaseMenu();
                }
                else if (itemSelection == kvp.Key && CashRegister.balance > kvp.Value.slotItem[].ItemCost)
                {
                    VendingItem();
                }
                else if (itemSelection == kvp.Key && CashRegister.balance < kvp.Value.slotItem[0].ItemCost)
                {
                    Console.WriteLine("Insufficient funds. Please deposit more. Returning to Purchase Menu.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                    Menu.PurchaseMenu();
                }
                else
                {
                    Console.WriteLine("Invalid vending code used. Returning to Purchase Menu. Press any key to continue.");
                    Console.ReadLine();
                    Menu.PurchaseMenu();
                }
            }
        }

        public static void VendingItem()
        {
            Console.WriteLine("Vending item...");
            //Console.Write($"{kvp.Key} : {kvp.Value.slotItem[0].ItemName} : {kvp.Value.slotItem[0].ItemCost}
            //CashRegister.balance -= kvp.Value.slotItem[0].ItemCost;
        }
         
    }
}

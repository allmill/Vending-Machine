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
        public static decimal balance = CashRegister.GetBalance();

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

            CompareInput(itemSelection);

            //Console.WriteLine($"Is {itemSelection} in an object or dictionary?");

            //if invalid code state invalid code, restart vendingSelection
            //if itemSelection = itemCode, check inventory amount
            //check balance against cost
            //if good vendingItem() produce object name, cost, new balance, object message

            //return to PurchaseMenu()


        }

        public static void CompareInput(string slotId)
        {

                if (slot.ContainsKey(slotId))
                    {
                    if (slot[slotId].IsEmpty)
                    {
                        Console.WriteLine("Item is sold out. Returning to Purchase Menu. Press any key to continue.");
                        Console.ReadLine();
                        Menu.PurchaseMenu();
                    }
                    else if (CashRegister.balance < slot[slotId].ItemCost)
                    {
                        Console.WriteLine("Insufficient funds. Please deposit more. Returning to Purchase Menu.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        Menu.PurchaseMenu();
                    }
                    else
                    {
                        VendingItem(slotId);
                        //THIS IS NOW THE PASSING CONDITION
                    }
                }

        }

        public static void VendingItem(string slotID)
        {
            Console.WriteLine("Vending item...");
            Console.WriteLine($"{slotID} : {slot[slotID].slotItem[0].ItemName} : {slot[slotID].slotItem[0].ItemCost}");
            CashRegister.balance -= slot[slotID].slotItem[0].ItemCost;
            Console.Read();
            //slot[slotID].slotItem--;
            Menu.PurchaseMenu();
        
        }
         
    }
}

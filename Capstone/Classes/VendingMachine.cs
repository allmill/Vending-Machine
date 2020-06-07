using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;
using System.Linq;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        public static Dictionary<string, Slot> slot = new Dictionary<string, Slot>();
        public static string itemSelection;
        public static decimal itemCost;
        //public static decimal balance = CashRegister.GetBalance();

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
            try
            {
                foreach (KeyValuePair<string, Slot> kvp in VendingMachine.slot)
                {
                    //if (slots.Contains(kvp.Value.slotItem[0].ItemName))
                    Console.WriteLine();
                    Console.Write($"{kvp.Key} : ");
                    if (kvp.Value.slotItem[0].ItemName == null)
                    {
                        Console.Write($"SOLD OUT");
                    }
                    else if (kvp.Value.slotItem[0].ItemName != null)
                    {
                        Console.Write($"{kvp.Value.slotItem[0].ItemName} : Stock {kvp.Value.slotItem.Count}");
                    }
                    else
                    {
                        Console.Write($"{kvp.Value.slotItem[0].ItemName} : Stock {kvp.Value.slotItem.Count}");
                    }
                }
            } catch (ArgumentOutOfRangeException)
            {
                Console.Write($"SOLD OUT");

                itemSelection = Console.ReadLine().ToUpper();
                CompareInput(itemSelection);

            }
                
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
            CashRegister.balance -= slot[slotID].slotItem[0].ItemCost;
            Console.WriteLine($"Item: {slot[slotID].slotItem[0].ItemName} Cost: {slot[slotID].slotItem[0].ItemCost} Current Balance: {CashRegister.balance}");
            
            Console.WriteLine($"{slot[slotID].slotItem[0].ItemSound}");
            //slot[slotID].slotItem.
            slot[slotID].slotItem.RemoveAt(0);
            Console.WriteLine();
            Console.WriteLine("Press any key to return to the Purchasing Menu.");
            Console.Read();
            Menu.PurchaseMenu();

        }
         
    }
}

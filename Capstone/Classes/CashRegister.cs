using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    //Should not take in 20s
    public static class CashRegister
    {
        /* Take in money
         * Determine if enough money
         * If enough, subtract total from available
         * Make change */
        public static decimal balance = 0.0M;
        public static int amountOfItemsBought = 0;
        public static decimal runningTotal = 0.0M;
        public static void TakeInMoney()
        {
            Console.WriteLine("-------This vending machine only accepts whole dollar amounts: $1, $2, $5, $10, $20-------");
            Console.WriteLine();
            
               //boolean for if a user is finished despositing money
               bool finishedFeeding = false;
               //while the user is NOT finished depositing, add money to the balance
               //only accepts 1, 2, 5, 10
               while (finishedFeeding == false)
               {
                   Console.WriteLine("What type of bill would you like to insert?");
                   decimal billInserted = decimal.Parse(Console.ReadLine());
                   if (billInserted == 1.0M)
                   {
                            balance += 1.0M;
                   } else if (billInserted == 2.0M)
                   {
                       balance += 2.0M;
                   }
                   else if (billInserted == 5.0M)
                   {
                            balance += 5.0M;
                   }
                   else if (billInserted == 10.0M)
                   {
                       balance += 10.0M;
                   }
                   else if (billInserted == 20.0M)
                   {
                       balance += 20.0M;
                   }
                   //checks to see if user is done depositing money. if yes, exit while loop and return current balance
                   Console.WriteLine("Are you finished insterting bills? Y/N");
                   string userInput = Console.ReadLine();
                   if (userInput == "Y" || userInput == "y")
                   {
                       finishedFeeding = true;
                   }
                   else if (userInput == "N" || userInput == "n")
                   {
                       finishedFeeding = false;
                   }
               }
            Console.WriteLine("Current Money Provided: " + balance);
            Console.WriteLine("The vending machine will now display the products you can choose from.");

        }
        public static decimal MakeChange()
        {
            //runningTotal = (InventoryItem.Candy * price) + (InventoryItem.Drinks * price) + (InventoryItem.Gum * price) + (InventoryItem.Cips * price);
            decimal change = 0.0M;
            //as long as there is money to return after the user is done with its transactions
            if (balance > 0.0M)
            {
                //subtract the item cost * how many items you bought from the balance
                change = balance - runningTotal;
            }
                return change;
        }


    }
}

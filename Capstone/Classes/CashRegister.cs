using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public static class CashRegister
    {
        /* Take in money
         * Determine if enough money
         * If enough, subtract total from available
         * Make change */
        public static decimal balance = 0.0M;

        public static decimal TakeInMoney()
        {
            Console.WriteLine("-------This vending machine only accepts whole dollar amounts: $1, $2, $5, $10, $20-------");
            Console.WriteLine();
<<<<<<< HEAD
=======
            
               //boolean for if a user is finished despositing money
               bool finishedFeeding = false;
               //while the user is NOT finished depositing, add money to the balance
               //only accepts 1, 2, 5, 10, 20
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
            VendingMachine.VendingSelection();

>>>>>>> 410d1b0c6b0f2f8a3f6003efee731a41f2834b3d

            //boolean for if a user is finished despositing money
            bool finishedFeeding = false;
            //while the user is NOT finished depositing, add money to the balance
            //only accepts 1, 2, 5, 10, 20
            while (finishedFeeding == false)
            {
                Console.WriteLine("What type of bill would you like to insert?");
                decimal billInserted = decimal.Parse(Console.ReadLine());
                if (billInserted == 1.0M)
                {
                    balance += 1.0M;
                }
                else if (billInserted == 2.0M)
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
            Console.WriteLine("The vending machine will now take you back to the purchasing menu.");
            //need to take them to the purchasing menu with list of what they can purchase
            return balance;
        }

        public static string ChangeWithLeastAmountOfCoins()
        {
            //counts each coin denomination
            int quarterCounter = 0;
            int dimeCounter = 0;
            int nickelCounter = 0;
            //as long as there is left over money in the balance, calculate the change
            while (balance > 0M)
            {
                Console.WriteLine("Calculating your change...");
                if (balance >= 0.25M)
                {
                    balance = balance - 0.25M;
                    quarterCounter++;
                }
                else if (balance >= 0.1M)
                {
                    balance = balance - 0.1M;
                    dimeCounter++;
                }
                else if (balance >= 0.05M)
                {
                    balance = balance - 0.05M;
                    nickelCounter++;
                }
            }
            return $"Your change is {quarterCounter} quarters, {dimeCounter} dimes, and {nickelCounter} nickels";
        }
    }
}

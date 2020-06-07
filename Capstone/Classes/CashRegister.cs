using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class CashRegister
    //public static class CashRegister
    {
        /* Take in money
         * Determine if enough money
         * If enough, subtract total from available
         * Make change */
        public static decimal balance = 0.0M;
        public static decimal previousBalance;

        public static decimal TakeInMoney()
        {
            Console.WriteLine("-------This vending machine only accepts whole dollar amounts: $1, $2, $5, $10-------");
            Console.WriteLine();
            
            //boolean for if a user is finished despositing money
                bool finishedFeeding = false;
               //while the user is NOT finished depositing, add money to the balance
               //only accepts 1, 2, 5, 10
               while (finishedFeeding == false)
               {
                    previousBalance = balance;
                    Console.WriteLine("What type of bill would you like to insert?");
                   decimal billInserted = decimal.Parse(Console.ReadLine());
                //Check to see if bill is valid, and if so, add to balance
                switch (billInserted)
                { 
                    case 1.0M: 
                        balance = previousBalance + 1.0M;
                        break;
                    case 2.0M:
                        balance = previousBalance + 2.0M;
                        break;
                    case 5.0M:
                        balance = previousBalance + 5.0M;
                        break;
                    case 10.0M:
                        balance = previousBalance + 10.0M;
                        break;
                    default:
                        break;
                }

                   if (billInserted == 1.0M || billInserted == 2.0M || billInserted == 5.0M || billInserted == 10.0M)
                   {
                    VendingMachine.newAuditEntries.Add($"{DateTime.Today} FEED MONEY {previousBalance:C2} {balance:C2} ");
                   }
                   //checks to see if user is done depositing money. if yes, exit while loop and return current balance
                   Console.WriteLine("Are you finished insterting bills? Y/N");
                   string userInput = Console.ReadLine().ToLower();
                   if (userInput == "y")
                   {
                       finishedFeeding = true;
                   }
                   else if (userInput == "n")
                   {
                       finishedFeeding = false;
                   }
               }
            Console.WriteLine($"Current Money Provided: {balance:C2}");
            Console.WriteLine("The vending machine will now display the products you can choose from.");
            Console.Read();
            VendingMachine.VendingSelection();
            return balance;
        }

        public static void ChangeWithLeastAmountOfCoins()
        {
            //counts each coin denomination
            int quarterCounter = 0;
            int dimeCounter = 0;
            int nickelCounter = 0;
            previousBalance = balance;
            Console.WriteLine("Calculating your change...");
            //as long as there is left over money in the balance, calculate the change
            while (balance > 0M)
            {
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
            Console.WriteLine($"Your change is {quarterCounter} quarters, {dimeCounter} dimes, and {nickelCounter} nickels");
            VendingMachine.newAuditEntries.Add($"{DateTime.Today} GIVE CHANGE {previousBalance:C2} {balance:C2} ");
            
        }
        public static string CalculateChange()
        {
            int currentBalanceInCents = (int)balance * 100;
            int numberOfQuarters = currentBalanceInCents / 25;
            int numberOfDimes = currentBalanceInCents - (25 * numberOfQuarters) / 10;
            int numberNickelsBack = (currentBalanceInCents - 25 * numberOfQuarters - 10 * numberOfDimes) / 5;

            string CoinsChange = $"Change Received: " +
                $"\n\t{numberOfQuarters} Quarters" +
                $"\n\t{numberOfDimes}" +
                $"\n\t{numberNickelsBack}";

            return CoinsChange;
            
        }
    }
}

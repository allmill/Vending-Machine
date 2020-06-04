using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class CashRegister
    {
        /* Take in money
         * Determine if enough money
         * If enough, subtract total from available
         * Make change */

        

        public static decimal balance = 0.0M;
        public static int amountOfItemsBought = 0;
        public string TakeInMoney(decimal userMoney)
        {
            //boolean for if a user is finished despositing money
            bool finishedFeeding = true;
            //while the user is NOT finished depositing, add money to the balance
            while(finishedFeeding == false)
            {
                //adding the users money to the machines balance. should only be whole bill amounts?
                balance += userMoney;
                Console.WriteLine("Are you finished depositing money? Y/N");
                string userInput = Console.ReadLine();
                //if the user is finished depositing money and has more than 0.75cents, finihsed feeding is set to true
                if (userInput == "y" || userInput == "Y")
                {
                    if (balance >= 0.75M)
                    {
                        finishedFeeding = true;
                    }
                }
                //if they are not finishe dfeeding, loop back thru the while loop
                else if (userInput == "n" || userInput == "N")
                {
                    finishedFeeding = false;
                }
                
            }
            return "Current Money Provided: " + balance;
        }
        public decimal MakeChange()
        {
            decimal change = 0.0M;
            //as long as there is money to return after the user is done with its transactions
            if (balance > 0.0M)
            {
                //subtract the item cost * how many items you bought from the balance
                change = balance - (Inventory.candy * amountOfItemsBought) - (Inventory.chips * amountOfItemsBought) - (Inventory.drinks * amountOfItemsBought) - (Inventory.gum * amountOfItemsBought);
            }
                return change;
        }


    }
}

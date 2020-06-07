using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    [TestClass]
    public class CashRegisterTest
    {
        [TestMethod]

        public void NoMoneyAccepted()
        {
            CashRegister zero = new CashRegister();
            
            Assert.AreEqual(0M, CashRegister.balance = 0);
        }
        [TestMethod]
        public void MoneyAccepted()
        {
            CashRegister moreThanZero = new CashRegister();
            decimal balance = 0;
            Assert.AreEqual(balance > 0, CashRegister.balance > 0);
        }

        [TestMethod]
        public void NegativeMoneyAccepted()
        {
            CashRegister negativeNumber = new CashRegister();
            decimal balance = 0;
            Assert.AreEqual(balance < 0, CashRegister.balance < 0);
        }
        [TestMethod]
        public void ChangeCalculator()
        {
            CashRegister change = new CashRegister();
            int balance = 0;
            int currentBalanceInCents = (int)balance * 100;
            int numberOfQuarters = currentBalanceInCents / 25;
            int numberOfDimes = currentBalanceInCents - (25 * numberOfQuarters) / 10;
            int numberNickelsBack = (currentBalanceInCents - 25 * numberOfQuarters - 10 * numberOfDimes) / 5;
            string CoinsChange = $"Change Received: " +
                $"\n\t{numberOfQuarters} Quarters" +
                $"\n\t{numberOfDimes}" +
                $"\n\t{numberNickelsBack}";

            Assert.AreEqual(CoinsChange, CashRegister.CalculateChange());

        }
    }
}

﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    [TestClass]
    public class MenuTests
    {
        [TestMethod]
        public void DisplaysVendingMachineItems()
        {
            try
            {
                FileReader.InventoryImport();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
        [TestMethod]
        public void GiveChangeWhenExiting()
        {
            try
            {
                CashRegister.ChangeWithLeastAmountOfCoins();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}

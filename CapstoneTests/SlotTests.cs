using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    [TestClass]
    public class SlotTests
    {
        [TestMethod]
        public void DoesSlotIdExist()
        {
            string noSlotID = null;
            Assert.AreEqual(noSlotID, VendingMachine.itemSelection);
        }
        [TestMethod]
        public void DoesItemCostExist()
        {
            decimal cost = 3.05M;

        }
    }
}

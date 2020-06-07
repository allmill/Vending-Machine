using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    [TestClass]
    public class VendingMachineTests
    {
        [TestMethod]
        public void IsItSoldOut()
        {
            VendingMachine selection = new VendingMachine();

            string soldOut = "SOLD OUT";

            Assert.AreEqual(soldOut, VendingMachine.itemSelection);

        }
    }
}

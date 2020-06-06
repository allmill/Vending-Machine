using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    [TestClass]
    public class MenuTests
    {
        [TestMethod]
        
        public void UserSelection()
        {
           
            Menu test = new Menu();
            string startingMenuSelect = "";
            Assert.AreEqual(null, startingMenuSelect);
        }
    }
}

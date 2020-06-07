using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    [TestClass]
    public class FileReaderTests
    {
        [TestMethod]
        public void UsesCorrectPath()
        {
            FileReader correctPath = new FileReader();
            Assert.AreEqual(Environment.CurrentDirectory, FileReader.directoryPath);
        }
        [TestMethod]
        public void GetsCorrectFile()
        {
            FileReader correctFile = new FileReader();
            Assert.AreEqual("vendingmachine.csv", FileReader.fileName);
        }

    }
}

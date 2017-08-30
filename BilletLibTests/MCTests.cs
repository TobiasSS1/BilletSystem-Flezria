using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibTests
{
    [TestClass]
    public class MCTests
    {
        [TestMethod()]
        public void PrisTestMC ()
        {
            //Arrange
            MC MC = new MC ();
            int ExpectedPris = 125;
            //Act
            int Pris = MC.Pris();
            //Assert
            Assert.AreEqual(ExpectedPris, Pris);
        }

        [TestMethod()]
        public void KøretøjTestMC()
        {
            //Arrange
            MC MC = new MC();
            String ExpectedKøretøj = "MC";
            //Act
            String Køretøj = MC.Køretøj();
            //Assert
            Assert.AreEqual(ExpectedKøretøj, Køretøj);
        }
    }
}

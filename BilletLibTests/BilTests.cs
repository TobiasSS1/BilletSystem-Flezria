using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void PrisTestBil()
        {
            //Arrange
            Bil Bil = new Bil();
            int ExpectedPris = 240;
            //Act
            int Pris = Bil.Pris();
            //Assert
            Assert.AreEqual(ExpectedPris, Pris);
        }

        [TestMethod()]
        public void KøretøjTestBil()
        {
            //Arrange
            Bil Bil = new Bil();
            String ExpectedKøretøj = "Bil";
            //Act
            String Køretøj = Bil.Køretøj();
            //Assert
            Assert.AreEqual(ExpectedKøretøj, Køretøj);
        }
    }
}
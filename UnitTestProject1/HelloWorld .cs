using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using battleships;

namespace battleshipsUnitTest
{
    [TestClass]
    public class HelloWorld
    {
        private const string Expected = "Hello World!";

        [TestMethod]
        public void TestMethod1()
        {
            string result = battleships.GameController.HelloWorld();
            Assert.AreEqual(Expected, result);
        }
    }
}
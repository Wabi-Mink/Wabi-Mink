using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace battleshipsUnitTest
{
    [TestClass]
    public class test1
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
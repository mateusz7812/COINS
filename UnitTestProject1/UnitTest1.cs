using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COINS;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            long[] result = Program.BankExchange(10);
            Assert.AreEqual(5, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(2, result[2]);

        }

        [TestMethod]
        public void TestMethod2()
        {
            var list = new Dictionary<long, long>();
            long result = Program.FindTheBestExchange(ref list, 10);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var list = new Dictionary<long, long>();
            long result = Program.FindTheBestExchange(ref list, 12);
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var list = new Dictionary<long, long>();
            long result = Program.FindTheBestExchange(ref list, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            long[] result = Program.BankExchange(2);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(0, result[2]);
        }

        [TestMethod]
        public void TestMethod6()
        {
            long[] result = Program.BankExchange(12);
            Assert.AreEqual(6, result[0]);
            Assert.AreEqual(4, result[1]);
            Assert.AreEqual(3, result[2]);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var list = new Dictionary<long, long>();
            long result = Program.FindTheBestExchange(ref list, 520);
            Assert.AreEqual(689, result);
        }

    }
}

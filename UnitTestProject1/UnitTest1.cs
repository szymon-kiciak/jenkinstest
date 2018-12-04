using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private ITest test;

        public UnitTest1()
        {
            test = new Test();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var result = test.Sum(2, 2);
            Assert.AreEqual(4, result);

        }
    }
}

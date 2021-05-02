using System;
using CockRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CockGreyhound cockGreyhound = new CockGreyhound();
            Assert.AreEqual(23, cockGreyhound.SPos);
        }
    }
}

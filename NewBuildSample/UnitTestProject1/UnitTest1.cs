using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewBuildSample;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 c1 = new Class1();
            Assert.IsTrue(c1.m1());
        }

        [TestMethod]
        public void TestMethod2()
        {
            Class1 c1 = new Class1();
            Assert.IsFalse(c1.m2());
        }

        [TestMethod]
        public void TestMethod3()
        {
            Class1 c1 = new Class1();
            Assert.IsTrue(c1.m3());
        }
    }
}

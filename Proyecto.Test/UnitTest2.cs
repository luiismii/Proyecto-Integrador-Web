using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Proyecto.Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 0;
            int b = 1;
            Assert.AreEqual(1, a + b);
        }
    }
}

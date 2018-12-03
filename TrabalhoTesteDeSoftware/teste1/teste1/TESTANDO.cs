using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace teste1
{
    [TestClass]
    public class TESTANDO
    {
        [TestMethod]
        public void TestMethod1()
        {
            UnitTest1 ArrayChar = new UnitTest1();

            string expectedResult = ArrayChar.GetType(2, 3, 4);
            Assert.AreEqual(expectedResult, "ESCALENO");
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class TESTANDO3
    {
        [TestMethod]
        public void TestMethod1()
        {
            UnitTest1 ArrayChar = new UnitTest1();

            string expectedResult = ArrayChar.Getfribonacci("a");
            Assert.AreEqual(expectedResult, "Entre com um número inteiro positivo");
        }
    }

}


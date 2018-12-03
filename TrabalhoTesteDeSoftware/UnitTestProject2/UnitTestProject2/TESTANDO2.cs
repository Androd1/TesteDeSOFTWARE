using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class TESTANDO2
    {
        [TestMethod]
        public void TestMethod1()
        {
            UnitTest1 ArrayChar = new UnitTest1();

            string expectedResult = ArrayChar.getArrey("abc", "d");
            Assert.AreEqual(expectedResult, "O caractere não pertence a cadeia informada");
        }
    }
}

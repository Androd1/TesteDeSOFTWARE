using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace teste1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
    
            public string GetType(int measure1, int measure2, int measure3)
        {
            string type = "ESCALENO";

            if (measure1 <= 0 || measure2 <= 0 || measure3 <= 0)
                type = "INEXISTENTE";
            else if (!((measure1 + measure2 > measure3) && (measure1 + measure3 > measure2) && (measure2 + measure3 > measure1)))
                type = "INEXISTENTE";
            else if (measure1 == measure2)
            {
                type = "ISOCELES";
                if (measure2 == measure3)
                    type = "EQUILATERO";
            }
            else if (measure2 == measure3 || measure1 == measure3)
            {
                type = "ISOCELES";
            }

            return type;

        }

        internal string SearchChar(string p1, string p2)
        {
            throw new NotImplementedException();
        }
    }
}

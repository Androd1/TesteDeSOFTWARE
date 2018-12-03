using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public string Getfribonacci(string n)
        {
            int ohf = 0;
            bool ConvOk = int.TryParse(n, out ohf);
            if (ConvOk)
            {
                int a = 0;
                int b = 1;
                for (int i = 0; i < ohf; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                if (a == 0)
                    return "n deve ser maior do que 0";
                else
                    return a.ToString();
            }
            else
            {
                return "Entre com um número inteiro positivo";
            }
        }
        }
    }


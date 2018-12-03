using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;


namespace UnitTestProject2
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public string getArrey(string CharArray, string index)
        {
            char Char2Search = ' ';

            bool ConvOk = char.TryParse(index, out Char2Search);

            if (ConvOk)
            {
                if (CharArray.Length < 20 && CharArray.Length > 0)
                {
                    if (CharArray.IndexOf(index) != -1)
                    {
                        int count = 0;
                        foreach (char c in CharArray)
                        {
                            count++;
                            if (c == Char2Search)
                            {
                                //return $"Encontrado no index: {count}";
                                return count.ToString();
                            }
                        }
                    }
                    //return $"O caractere não pertence a cadeia informada: { CharArray}";
                    return "O caractere não pertence a cadeia informada";
                }
                else
                {
                    return "cadeia inválida";
                    //return "cadeia inválida(char entre 1~20 = ok)";
                }
            }
            else
            {
                if (index == "")
                    return "nenhum caractere informado";
                else
                    return "mais de um caractere informado";
            }
        }


        internal string getArrey()
        {
            throw new NotImplementedException();
        }

        internal string getArrey(string p)
        {
            throw new NotImplementedException();
        }

        internal string getArrey(string p1, string p2, string p3)
        {
            throw new NotImplementedException();
        }

        internal string getArrey(string p1, string p2)
        {
            throw new NotImplementedException();
        }
    }
}


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace less1_adrbook.examples
{
    [TestClass]
    public class IfThenElse
    {
        [TestMethod]
        public void TestMethod1()
        {
            double total = 1500;
            bool vipclient = true;

            if (total > 1000 && vipclient)
            //if (total > 1000 || vipclient)
            {
                total = total * 0.9;
                System.Console.Out.Write("Скидка 10%, общая сумма " + total);
            }
            else
            {
                System.Console.Out.Write("Скидки нет, общая сумма " + total);
            }
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AleevRI.Sprint1.Task3.V8.Lib;

namespace Tyuiu.AleevRI.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double startAmoun = 2500;
            double percent = 20;
            double timeDays = 30;
            var res = ds.IncomeAmount(startAmoun, percent, timeDays);
            Assert.AreEqual(2541.10, Math.Round(res, 2));
        }
     
    }
}

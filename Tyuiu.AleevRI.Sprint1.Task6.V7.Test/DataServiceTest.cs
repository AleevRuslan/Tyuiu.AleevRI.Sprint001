using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AleevRI.Sprint1.Task6.V7.Lib;

namespace Tyuiu.AleevRI.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string s1 = "Hello World";
            string res = ds.DeleteLastLetter(s1);
            string wait = "Hell Worl";
            Assert.AreEqual(wait, res);
        }
    }
}

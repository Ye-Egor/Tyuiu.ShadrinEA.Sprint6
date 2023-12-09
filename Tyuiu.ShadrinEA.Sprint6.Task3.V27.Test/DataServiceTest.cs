using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShadrinEA.Sprint6.Task3.V27.Lib;

namespace Tyuiu.ShadrinEA.Sprint6.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mx = { {1,2,3},
                          {2,2,3} };
            int[,] res = ds.Calculate(mx);
            int rows = 2;
            int col = 3;
            int[,] wait = { {1,2,3},
                            {0,0,3} };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}

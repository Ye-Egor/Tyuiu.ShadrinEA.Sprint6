using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShadrinEA.Sprint6.Task4.V21.Lib;

namespace Tyuiu.ShadrinEA.Sprint6.Task4.V21.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -1;
            int stop = 1;
            double[] valuearray = new double[stop - start + 1];
            valuearray[0] = 7.51;
            valuearray[1] = 0;
            valuearray[2] = 1.62;
            double[] wait = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(valuearray, wait);
        }
    }
}

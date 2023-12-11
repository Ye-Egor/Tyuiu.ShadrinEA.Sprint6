using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShadrinEA.Sprint6.Task2.V19.Lib;

namespace Tyuiu.ShadrinEA.Sprint6.Task2.V19.Test
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
            int len = stop - start + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -5.04;
            valueWaitArray[1] = -6;
            valueWaitArray[2] = -7.85;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(res, valueWaitArray);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShadrinEA.Sprint6.Task5.V25.Lib;
using System.IO;

namespace Tyuiu.ShadrinEA.Sprint6.Task5.V25.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\meteo\source\repos\Tyuiu.ShadrinEA.Sprint6\Tyuiu.ShadrinEA.Sprint6.Task5.V25\bin\Debug\InPutFileTask5V25.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}

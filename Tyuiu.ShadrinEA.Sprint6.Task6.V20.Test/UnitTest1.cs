using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShadrinEA.Sprint6.Task6.V20.Lib;

namespace Tyuiu.ShadrinEA.Sprint6.Task6.V20.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\meteo\source\repos\Tyuiu.ShadrinEA.Sprint6\Tyuiu.ShadrinEA.Sprint6.Task6.V20\bin\Debug\InPutFileTask6V20.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
  
}

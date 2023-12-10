using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShadrinEA.Sprint6.Task6.V20.Lib
{
    public class DataService : ISprint6Task6V20
    {
       
        public string CollectTextFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string result = "";
            
            using (StreamReader reader = new StreamReader(path))
            {
                

               
                    foreach (string line in lines)
                    {
                     
                        string[] words = line.Split(' ');
                        result += words[1] + " ";
                    }
                


            }
       
            return result;
        }
    }
}

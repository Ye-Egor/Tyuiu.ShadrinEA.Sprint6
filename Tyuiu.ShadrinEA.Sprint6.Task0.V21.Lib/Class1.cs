using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShadrinEA.Sprint6.Task0.V21.Lib
{
    public class DataService : ISprint6Task0V21
    {
        public double Calculate(int x)
        {
            double y = x;
            double res = 2 * Math.Pow(y, 3) + 0.5 * y * y - 3.5 * x + 2;
            return Math.Round(res, 3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShadrinEA.Sprint6.Task4.V21.Lib
{
    public class DataService : ISprint6Task4V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double f;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((double)x*2 - 1 != 0)
                {
                    f = Math.Round((2 * Math.Cos((double)x) + 2) / (2 * x - 1) + Math.Cos((double)x) - 5 * x + 3, 2);
                    valueArray[count] = f;
                    count++;
                }
                else
                {
                    f = 0;
                    valueArray[count] = f;
                    count++;
                }
            }
            return valueArray;
        }
    }
}

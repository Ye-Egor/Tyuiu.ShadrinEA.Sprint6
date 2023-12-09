using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShadrinEA.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / rows;

            int[] kal = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                kal[i] = matrix[i, 4];
            }
            Array.Sort(kal);

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[i, 4] = kal[i];
            }
            return matrix;

        }
    }
}

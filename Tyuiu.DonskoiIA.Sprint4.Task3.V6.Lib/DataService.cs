using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DonskoiIA.Sprint4.Task3.V6.Lib
{
    public class DataService : ISprint4Task3V6
    {
        public int Calculate(int[,] array)
        {
            int m = int.MaxValue;

            for (int i = 0; i < 5; i++)
            {
                m = Math.Min(m, array[1, i]);
            }
            return m;
        }
    }
}
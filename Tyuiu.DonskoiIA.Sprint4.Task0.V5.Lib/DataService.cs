using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DonskoiIA.Sprint4.Task0.V5.Lib
{
    public class DataService : ISprint4Task0V5
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int ans = 0;
            foreach (int i in array)
            {
                if (i % 2 == 0) ans += i;
            }

            return ans;
        }
    }
}
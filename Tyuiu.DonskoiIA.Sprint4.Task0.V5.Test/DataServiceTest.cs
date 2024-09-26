using System;
using Tyuiu.DonskoiIA.Sprint4.Task0.V5.Lib;

namespace Tyuiu.DonskoiIA.Sprint4.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetSumEvenArrEl(new int[] {8, 9, 4, 1, 2, 3, 4, 5, 6, 7});
            Assert.AreEqual(8+4+2+4+6, res);
        }
    }
}
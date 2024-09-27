using System;
using Tyuiu.DonskoiIA.Sprint4.Task5.V15.Lib;

namespace Tyuiu.DonskoiIA.Sprint4.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(new int[,] { { -3, 0, 0, 0, 0 }, { 1, 2, 5, -6, -7 }, { 0, 0, -3, 4, -5 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } });
            Assert.AreEqual(1 + 2 + 5 + 4, res);
        }
    }
}
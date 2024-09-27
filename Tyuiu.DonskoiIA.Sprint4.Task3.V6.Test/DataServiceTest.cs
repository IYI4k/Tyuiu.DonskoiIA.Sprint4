using System;
using Tyuiu.DonskoiIA.Sprint4.Task3.V6.Lib;

namespace Tyuiu.DonskoiIA.Sprint4.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(new int[,] { { 0, 0, 0, 0, 0 }, { 10, 2, 50, 60, 7 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } });
            Assert.AreEqual(2, res);
        }
    }
}
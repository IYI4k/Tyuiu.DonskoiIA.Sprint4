using System;
using Tyuiu.DonskoiIA.Sprint4.Task4.V2.Lib;

namespace Tyuiu.DonskoiIA.Sprint4.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(new int[,] { { 0, 0, 0, 0, 0 }, { 10, 2, 50, 60, 7 }, { 0, 0, 3, 4, 5 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } });
            CollectionAssert.AreEqual(new int[,] { { 0, 0, 0, 0, 0 }, { 10, 2, 50, 60, 0 }, { 0, 0, 0, 4, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }, res);
        }
    }
}
using System;
using Tyuiu.DonskoiIA.Sprint4.Task6.V8.Lib;

namespace Tyuiu.DonskoiIA.Sprint4.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(new string[] { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" });
            CollectionAssert.AreEqual(new string[] {"Пицца", "Пельмени", "Омлет", "Салат", "Роллы"}, res);
        }
    }
}
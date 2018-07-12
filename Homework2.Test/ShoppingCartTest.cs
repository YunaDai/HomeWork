using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework2.Test
{
    [TestClass]
    public class ShoppingCartTest
    {
        [TestMethod]
        public void AddProductTest()
        {
            int[] id = { 1, 4 };
            int[] quantity = { 3, 2 };
            var result = new ShoppingCart();
            var actual = result.AddProduct(id,quantity); // 8700*3+2250*2
            var expected = "在「XX商店」買了「二手蘋果手機」*3，在「OO商店」買了「哈利波特影集」*2，共花了30600元";
            Assert.AreEqual(expected, actual);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode.EasyCollection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.EasyCollection.Tests
{
    [TestClass()]
    public class BestTimeToBuyAndSellStockIITests
    {
        [TestMethod()]
        public void MaxProfitTest()
        {
            //Arrange
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            BestTimeToBuyAndSellStockII question = new BestTimeToBuyAndSellStockII();

            //Act
            var maxProfit = question.MaxProfit(prices);

            //Assert
            Assert.IsTrue(maxProfit == 7);
        }
    }
}
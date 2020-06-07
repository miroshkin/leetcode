using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.EasyCollection
{
    //https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/564/
    public class BestTimeToBuyAndSellStockII : IQuestion
    {
        int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
        public void Answer()
        {
            MaxProfit(prices);
        }

        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            int currentPrice;
            int previousPrice;

            for (int i = 1; i < prices.Length; i++)
            {
                currentPrice = prices[i];
                previousPrice = prices[i - 1];

                if (currentPrice > previousPrice)
                    profit += currentPrice - previousPrice;
            }
            return profit;
        }
    }
}

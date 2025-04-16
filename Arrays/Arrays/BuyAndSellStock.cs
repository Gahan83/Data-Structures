using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Arrays
{
    public class BuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            //int minPrice = int.MaxValue;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    maxProfit += prices[i] - prices[i - 1];
                }
                //else if (prices[i] - minPrice > maxProfit)
                //{
                //    maxProfit = prices[i] - minPrice;
                //}
            }
            return maxProfit;
        }
    }
}

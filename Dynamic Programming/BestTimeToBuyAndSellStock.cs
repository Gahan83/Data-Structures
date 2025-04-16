using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach (int price in prices)
            {
                if (price < minPrice)
                {
                    minPrice = price;  // update minimum buy price
                }
                else
                {
                    int profit = price - minPrice; // profit if sold today
                    maxProfit = Math.Max(maxProfit, profit); // update max profit
                }
            }

            return maxProfit;
        }
    }
}

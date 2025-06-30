using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Arrays
{
    public class BuyAndSellStock // Declaring public class BuyAndSellStock
    {
        public int MaxProfit(int[] prices) // Method to calculate maximum profit from stock prices
        {
            int maxProfit = 0; // Initialize maxProfit to 0
                               //int minPrice = int.MaxValue; // (Commented) Initialize minPrice to maximum integer value
            for (int i = 1; i < prices.Length; i++) // Loop through prices starting from second element
            {
                if (prices[i] > prices[i - 1]) // If current price is greater than previous price
                {
                    maxProfit += prices[i] - prices[i - 1]; // Add the difference to maxProfit
                }
                //else if (prices[i] - minPrice > maxProfit) // (Commented) If profit is greater than maxProfit
                //{
                //    maxProfit = prices[i] - minPrice; // (Commented) Update maxProfit
                //}
            }
            return maxProfit; // Return the calculated maxProfit
        }
    }
}

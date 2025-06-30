using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    public class BestTimeToBuyAndSellStock // Declaring the class for the stock problem
    {
        public int MaxProfit(int[] prices) // Method to calculate the maximum profit from stock prices
        {
            int minPrice = int.MaxValue; // Initialize minimum price to the largest possible integer value
            int maxProfit = 0; // Initialize maximum profit to zero

            foreach (int price in prices) // Iterate through each price in the prices array
            {
                if (price < minPrice) // If the current price is less than the minimum price seen so far
                {
                    minPrice = price;  // Update minimum buy price to the current price
                }
                else // Otherwise, calculate profit if sold at the current price
                {
                    int profit = price - minPrice; // Calculate profit by subtracting minPrice from current price
                    maxProfit = Math.Max(maxProfit, profit); // Update maxProfit if the current profit is higher
                }
            }

            return maxProfit; // Return the maximum profit found
        }
    }
}

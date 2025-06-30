using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    public class HouseRobber
    {
        // Main method to calculate the maximum amount that can be robbed
        public int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0; // If there are no houses, return 0
            if (nums.Length == 1) return nums[0]; // If only one house, rob it

            int prev1 = 0; // Stores the max amount robbed up to the previous house (dp[i-1])
            int prev2 = 0; // Stores the max amount robbed up to the house before the previous (dp[i-2])

            foreach (int num in nums) // Iterate through each house
            {
                int temp = prev1; // Temporarily store prev1 for updating prev2 later
                prev1 = Math.Max(prev2 + num, prev1); // Decide to rob current house or not
                prev2 = temp; // Update prev2 to previous prev1 value
            }

            return prev1; // Return the maximum amount robbed
        }
    }
}

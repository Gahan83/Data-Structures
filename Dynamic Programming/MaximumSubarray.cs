using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    public class MaximumSubarray // Defining the MaximumSubarray class
    {
        public int MaxSubArray(int[] nums) // Method to find the maximum subarray sum
        {
            int maxSum = nums[0]; // Initialize maxSum with the first element of the array
            int currentSum = nums[0]; // Initialize currentSum with the first element of the array

            for (int i = 1; i < nums.Length; i++) // Iterate through the array starting from the second element
            {
                // Choose the maximum between starting a new subarray at current element or extending the previous subarray
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                // Update maxSum if currentSum is greater than the previous maxSum
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum; // Return the maximum subarray sum found
        }
    }
}

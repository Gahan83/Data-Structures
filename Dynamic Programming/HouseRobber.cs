using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    public class HouseRobber
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            int prev1 = 0; // dp[i-1]
            int prev2 = 0; // dp[i-2]

            foreach (int num in nums)
            {
                int temp = prev1;
                prev1 = Math.Max(prev2 + num, prev1);
                prev2 = temp;
            }

            return prev1;
        }
    }
}

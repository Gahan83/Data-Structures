using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    public class ClimbingStairs // Defining the ClimbingStairs class
    {
        public int ClimbStairs(int n) // Method to calculate number of ways to climb n stairs
        {
            if (n <= 2) return n; // If n is 1 or 2, return n directly (base cases)

            int first = 1;  // Number of ways to reach step 1
            int second = 2; // Number of ways to reach step 2

            for (int i = 3; i <= n; i++) // Loop from step 3 to n
            {
                int third = first + second; // Number of ways to reach current step is sum of previous two
                first = second; // Update first to previous second for next iteration
                second = third; // Update second to current third for next iteration
            }

            return second; // Return the total number of ways to reach the nth step
        }
    }
}

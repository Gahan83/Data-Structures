using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    public class ShuffleAnArray
    {
        private int[] original; // Stores the original array for reset operations
        private int[] current;  // Stores the current (possibly shuffled) array
        private Random rand;    // Random number generator for shuffling

        public ShuffleAnArray(int[] nums)
        {
            original = (int[])nums.Clone(); // Clone input array to preserve original
            current = (int[])nums.Clone();  // Clone input array for shuffling
            rand = new Random();            // Initialize random number generator
        }

        public int[] Reset()
        {
            current = (int[])original.Clone(); // Reset current array to original state
            return current;                    // Return the reset array
        }

        public int[] Shuffle()
        {
            for (int i = current.Length - 1; i > 0; i--) // Iterate from end to start
            {
                int j = rand.Next(i + 1); // Pick random index from 0 to i (inclusive)
                (current[i], current[j]) = (current[j], current[i]); // Swap elements at i and j
            }
            return current; // Return the shuffled array
        }
    }
}

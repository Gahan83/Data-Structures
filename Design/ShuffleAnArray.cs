using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    public class ShuffleAnArray
    {
        private int[] original;
        private int[] current;
        private Random rand;

        public ShuffleAnArray(int[] nums)
        {
            original = (int[])nums.Clone();
            current = (int[])nums.Clone();
            rand = new Random();
        }

        public int[] Reset()
        {
            current = (int[])original.Clone();
            return current;
        }

        public int[] Shuffle()
        {
            for (int i = current.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1); // random index from 0 to i
                (current[i], current[j]) = (current[j], current[i]); // swap
            }
            return current;
        }
    }
}

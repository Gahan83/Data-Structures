using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
    public class NumberOfOneBit
    {
        public int HammingWeight(int n)
        {
            int count = 0;

            // Loop through the binary representation of n
            while (n != 0)
            {
                // Increment the count if the last bit is 1
                count += n & 1;

                // Right shift n by 1 to check the next bit
                n >>= 1;
            }

            return count;
        }
    }
}

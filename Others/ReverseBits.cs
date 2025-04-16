using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
    public class ReverseBits
    {
        public  uint ReverseBitsMethod(uint n)
        {
            uint result = 0;

            for (int i = 0; i < 32; i++)
            {
                // Left shift result to make space for the next bit
                result <<= 1;

                // Add the last bit of n to result
                result |= (n & 1);

                // Right shift n to process the next bit
                n >>= 1;
            }

            return result;
        }

    }
}

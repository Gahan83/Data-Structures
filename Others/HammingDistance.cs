using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
    public class HammingDistance
    {
        public int HammingDistanceMethod(int x, int y)
        {
            int xor = x ^ y; // XOR gives bits that are different
            int distance = 0;

            // Count number of 1's in the XOR result
            while (xor != 0)
            {
                distance += xor & 1; // Add 1 if the last bit is set
                xor >>= 1;           // Right shift by 1 to check the next bit
            }

            return distance;
        }
    }
}

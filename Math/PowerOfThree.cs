using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class PowerOfThree
    {
        public bool IsPowerOfThree(int n)
        {
            if (n < 1)
                return false;

            while (n % 3 == 0)
            {
                n /= 3;
            }

            return n == 1;
        }
    }
}

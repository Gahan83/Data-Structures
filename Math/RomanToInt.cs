using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class RomanToInt
    {
        public int RomanToIntMethod(string s)
        {
            Dictionary<char, int> romanMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            int total = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int current = romanMap[s[i]];
                int next = (i + 1 < s.Length) ? romanMap[s[i + 1]] : 0;

                // If next symbol is larger, subtract current from total (like IV, IX, etc.)
                if (current < next)
                {
                    total -= current;
                }
                else
                {
                    total += current;
                }
            }

            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings.Strings
{
    public class ReverseString
    {
        public void Reverse(char[] s)
        {
            int left =0, right= s.Length - 1;

            while (left < right)
            {   //swap characters
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                //move pointers
                left++;
                right--;
            }
        }
    }
}

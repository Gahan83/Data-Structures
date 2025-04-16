using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings.Strings
{
    public class LongestCommonPrefix
    {
        public string MyLongestCommonPrefix(string[] strs)
        {
            // If the input array is empty, return an empty string
            if (strs == null || strs.Length == 0)
                return "";

            // Take the first word as the prefix
            string prefix = strs[0];

            // Iterate over the array and compare the prefix with each word
            for (int i = 1; i < strs.Length; i++)
            {
                // Keep reducing the prefix until it matches the current word
                while (strs[i].IndexOf(prefix) != 0)
                {
                    // Shorten the prefix by removing the last character
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    // If prefix becomes empty, return ""
                    if (prefix == "")
                        return "";
                }
            }

            return prefix; // Return the final longest common prefix
        }
    }
}

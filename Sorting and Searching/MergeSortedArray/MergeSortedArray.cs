using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_and_Searching.MergeSortedArray
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1; // Last element of nums1 (actual)
            int j = n - 1; // Last element of nums2
            int k = m + n - 1; // Last index of nums1 (extra space included)

            // Fill nums1 from the back
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }

            // If any elements left in nums2, copy them
            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
}

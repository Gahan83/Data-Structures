namespace DataStructures
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            // Merge nums1 and nums2 from the end
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i]; // Place the larger element at the end of nums1
                    i--; // Move the pointer in nums1
                }
                else
                {
                    nums1[k] = nums2[j]; // Place the larger element at the end of nums1
                    j--; // Move the pointer in nums2
                }
                k--;
            }

            // If elements are remaining in nums2, place them in nums1
            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }
        }
    }
}

//////////////////////////////: MergeSortedArray

using Sorting_and_Searching.MergeSortedArray;


MergeSortedArray solution = new MergeSortedArray();

int[] nums1 = { 1, 2, 3, 0, 0, 0 };
int[] nums2 = { 2, 5, 6 };
int m = 3, n = 3;

solution.Merge(nums1, m, nums2, n);

Console.WriteLine(string.Join(",", nums1)); // Output: 1,2,2,3,5,6
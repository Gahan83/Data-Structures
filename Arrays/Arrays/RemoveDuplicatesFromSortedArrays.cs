namespace Arrays.Arrays
{
    public class RemoveDuplicatesFromSortedArrays
    {
        public int RemoveDuplicates(int[] nums)
        {
            // Check if the input array is empty; if so, return 0 as there are no elements
            if (nums.Length == 0) return 0;

            // Initialize k to 1, which will track the position of the next unique element
            int k = 1;

            // Iterate through the array starting from the second element
            for (int i = 1; i < nums.Length; i++)
            {
                // If the current element is not equal to the previous unique element
                if (nums[i] != nums[k - 1])
                {
                    // Assign the current element to the next unique position
                    nums[k] = nums[i];
                    // Increment k to move to the next position for unique elements
                    k++;
                }
            }
            // Return the number of unique elements found
            return k;
        }
    }
}

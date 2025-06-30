namespace Arrays.Arrays
{
    public class NonZeros // Declares the NonZeros class
    {
        public void MoveZeros(int[] nums) // Method to move all zeros in the array to the end
        {
            int nonZeroIndex = 0; // Index to place the next non-zero element

            foreach (int num in nums) // Iterate through each element in the array
            {
                if (num != 0) // Check if the current element is not zero
                {
                    nums[nonZeroIndex++] = num; // Place the non-zero element at the current nonZeroIndex and increment the index
                }
            }

            for (int i = nonZeroIndex; i < nums.Length; i++) // Fill the rest of the array with zeros starting from nonZeroIndex
            {
                nums[i] = 0; // Set the current element to zero
            }
        }
    }
}



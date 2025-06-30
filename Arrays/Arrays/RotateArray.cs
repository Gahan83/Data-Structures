namespace Arrays.Arrays
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n; //K is not greater than nums

            if (k < 0)
            {
                k = k + n;
            }
            Reverse(nums, 0, n - 1); //Reverse the entire array
            Reverse(nums, 0, k - 1); //Reverse the first k elements
            Reverse(nums, k, n - 1); // Reverse the rest of the elements
        }

        public void Reverse(int[] nums, int start, int end)
        {
            // Continue swapping until start index is less than end index
            while (start < end)
            {
                // Store the value at the start index in a temporary variable
                int temp = nums[start];
                // Assign the value at the end index to the start index
                nums[start] = nums[end];
                // Assign the value stored in temp to the end index
                nums[end] = temp;
                // Move the start index forward
                start++;
                // Move the end index backward
                end--;
            }
        }
    }
}

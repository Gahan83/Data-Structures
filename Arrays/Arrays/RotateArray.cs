namespace Arrays.Arrays
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n; //K is not greater than nums

            //if (k < 0)
            //{
            //    k = k + n;
            //}
            Reverse(nums, 0, n - 1); //Reverse the entire array
            Reverse(nums, 0, k - 1); //Reverse the first k elements
            Reverse(nums, k, n - 1); // Reverse the rest of the elements
        }

        public void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}

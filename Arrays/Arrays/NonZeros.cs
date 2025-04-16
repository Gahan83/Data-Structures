namespace Arrays.Arrays
{
    public class NonZeros
    {
        public void MoveZeros(int[] nums)
        {
            int nonZeroIndex = 0;

            foreach (int num in nums)
            {
                if (num != 0)
                {
                    nums[nonZeroIndex++] = num;
                }
            }

            for (int i = nonZeroIndex; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}



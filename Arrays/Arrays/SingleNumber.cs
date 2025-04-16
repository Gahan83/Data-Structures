namespace Arrays.Arrays
{
    public class SingleNumber
    {
        public int FindSingleNumber(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result ^= num;
            }
            return result;
        }
    }
}

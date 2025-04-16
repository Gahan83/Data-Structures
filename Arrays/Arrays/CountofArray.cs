namespace Arrays.Arrays
{
    public class CountofArray
    {
        public void Count(int[] nums)
        {
            int result = 0;

            foreach (int i in nums)
            {
                if (i % 2 == 0)
                {
                    result = result + 1;
                }
            }

            Console.WriteLine(result);
        }
    }
}

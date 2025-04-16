namespace Arrays.Arrays
{
    public class SumofArray
    {
        public void Sum(int[] nums)
        {
            int result = 0;

            foreach (int i in nums)
            {
                if (i % 2 == 0)
                {
                    result += i;
                }
            }

            Console.WriteLine(result);
        }
    }
}

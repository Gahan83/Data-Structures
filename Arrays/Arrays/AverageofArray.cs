namespace Arrays.Arrays
{
    public class AverageofArray
    {
        public void Average(int[] nums)
        {
            double total = 0;
            int sum = 0;
            double result = 0;


            foreach (int i in nums)
            {
                sum += i;
                total = total + 1;
            }
            result = sum / total;

            Console.WriteLine(result);
        }
    }
}

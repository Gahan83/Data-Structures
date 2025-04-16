namespace Arrays.Arrays
{
    public class MinimumEvenNumber
    {
        public void MinEvenNumber(int[] value)
        {
            int? result = null;

            foreach (var item in value)
            {
                if (item % 2 == 0)
                {
                   if(!result.HasValue || item<result)
                    {
                        result = item;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}

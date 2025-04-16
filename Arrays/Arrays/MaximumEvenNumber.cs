namespace Arrays.Arrays
{
    public class MaximumEvenNumber
    {
        public void MaxEvenNumber(int[] value)
        {
            int? result = null;

            foreach (var item in value)
            {
                if (item % 2 == 0)
                {
                   if(!result.HasValue || item>result)
                    {
                        result = item;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}

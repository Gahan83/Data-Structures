namespace Arrays.Arrays
{
    public class MaxNumber
    {
        public void PickMaxNumber(int[] numbers)
        {
            int? result = null;

            foreach (int number in numbers)
            {
                if (!result.HasValue || number>result)
                {
                    result = number;
                    //result=number.Length;
                }
            }
            Console.WriteLine(result);
        }
            
    }
}

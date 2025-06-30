namespace Arrays.Arrays
{
    public class SumofArray
    {
        public void Sum(int[] nums) // Method to calculate the sum of even numbers in the array
        {
            int result = 0; // Initialize result variable to store the sum

            foreach (int i in nums) // Iterate through each element in the input array
            {
                //if (i % 2 != 0) // (Commented out) Would check for odd numbers
                if (i % 2 == 0) // Check if the current number is even
                {
                    result += i; // Add the even number to the result
                }
            }

            Console.WriteLine(result); // Output the final sum to the console
        }
    }
}

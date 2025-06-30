namespace Arrays.Arrays
{
    public class CountofArray // Declares a public class named CountofArray
    {
        public void Count(int[] nums) // Public method that takes an integer array as input
        {
            int result = 0; // Initializes a variable to store the count of even numbers

            foreach (int i in nums) // Iterates through each integer in the input array
            {
                if (i % 2 == 0) // Checks if the current integer is even
                                //if (i % 2 != 0) // (Commented out) Would check if the integer is odd
                {
                    result = result + 1; // Increments the count if the integer is even
                }
            }
            Console.WriteLine(result); // Outputs the final count to the console
        }
    }
}

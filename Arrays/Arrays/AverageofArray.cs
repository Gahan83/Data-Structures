namespace Arrays.Arrays
{
    public class AverageofArray
    {
        // Method to calculate and print the average of an integer array
        public void Average(int[] nums)
        {
            double total = 0; // Variable to count the number of elements
            int sum = 0; // Variable to store the sum of all elements
            double result = 0; // Variable to store the calculated average

            // Loop through each integer in the array
            foreach (int i in nums)
            {
                sum += i; // Add the current element to the sum
                total = total + 1; // Increment the total count by 1
            }
            result = sum / total; // Calculate the average (integer division)

            Console.WriteLine(result); // Print the average to the console
        }
    }
}

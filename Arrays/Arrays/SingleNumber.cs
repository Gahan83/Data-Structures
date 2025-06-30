namespace Arrays.Arrays
{
    public class SingleNumber // Declares the SingleNumber class
    {
        public int FindSingleNumber(int[] nums) // Method to find the single number in the array
        {
            int result = 0; // Initialize result to 0
            foreach (int num in nums) // Iterate through each number in the array
            {
                result ^= num; // Apply XOR operation between result and current number
            }
            return result; // Return the single number found
        }
    }
}

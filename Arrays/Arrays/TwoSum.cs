namespace Arrays.Arrays
{
    public class TwoSum
    {
        public int[] Sum(int[] nums, int target)
        {
            // Create a dictionary to store numbers and their indices
            var map = new Dictionary<int, int>();

            // Iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {
                // Calculate the complement needed to reach the target
                int complement = target - nums[i];
                // Check if the complement exists in the dictionary
                if (map.ContainsKey(complement))
                {
                    // If found, return the indices of the complement and current number
                    return new int[] { map[complement], i };
                }
                // Add the current number and its index to the dictionary
                map[nums[i]] = i;
            }

            // Return an empty array if no solution is found
            return new int[0];
        }
    }
}

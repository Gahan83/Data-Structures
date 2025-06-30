namespace Arrays.Arrays
{
    public class CombineToSingleString // Defines a public class named CombineToSingleString
    {
        public void Combine(string[] names) // Public method that takes an array of strings as input
        {
            string result = string.Empty; // Initializes an empty string to store the combined result

            foreach (var name in names) // Iterates over each string in the names array
            {
                result = result + name + ","; // Appends the current name and a comma to the result string
            }

            int lastIndex = result.LastIndexOf(','); // Finds the index of the last comma in the result string
            result = result.Remove(lastIndex); // Removes the last comma from the result string

            Console.WriteLine(result); // Outputs the final combined string to the console
        }
    }
}

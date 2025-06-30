namespace Arrays.Arrays
{
    public class PlusOne
    {
        public int[] AddOne(int[] digits) // Method to add one to the number represented by the digits array
        {
            for (int i = digits.Length - 1; i >= 0; i--) // Loop from the last digit to the first
            {
                if (digits[i] < 9) // If the current digit is less than 9
                {
                    digits[i]++; // Increment the current digit by 1
                    return digits; // Return the updated array as no further carry is needed
                }
                digits[i] = 0; // Set the current digit to 0 as it was 9 and caused a carry
            }
            int[] newNumber = new int[digits.Length + 1]; // Create a new array with an extra digit for the carry
            newNumber[0] = 1; // Set the first digit to 1 to account for the carry
            return newNumber; // Return the new array representing the incremented number
        }
    }
}

namespace Strings.Strings
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            int reversed = 0; // Variable to store the reversed number

            while (x != 0) // Continue until all digits are processed
            {
                int digit = x % 10; // Extract the last digit from x
                x /= 10; // Remove the last digit from x (integer division)

                // Check for overflow before performing the multiplication and addition
                if (reversed > int.MaxValue / 10 || reversed < int.MinValue / 10)
                {
                    return 0; // Return 0 if reversing causes an overflow
                }

                // Append the extracted digit to reversed
                reversed = reversed * 10 + digit;
            }

            return reversed; // Return the reversed number
        }

    }
}

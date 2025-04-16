namespace Strings.Strings
{
    public class Palindrome
    {
        public bool IsPalindrome(string s)
        {
            string cleaned = ""; // Convert the string to lowercase and remove non-alphanumeric characters
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c)) // Check if the character is a letter or digit
                {
                    cleaned += char.ToLower(c); // Convert the character to lowercase and add it to the cleaned string 
                }
            }

            // Check if the cleaned string is a palindrome
            int left = 0, right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}

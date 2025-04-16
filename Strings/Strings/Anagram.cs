namespace Strings.Strings
{
    public class Anagram
    {
        public bool isAnagram(string s, string t)
        {
            //if the length are different, they cannot be anagram
            if (s.Length != t.Length) return false;

            //convert strings to character arrrays
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();

            //Sort both character array 
            Array.Sort(sArray);
            Array.Sort(tArray);

            return new string(sArray) == new string(tArray);
        }
    }
}

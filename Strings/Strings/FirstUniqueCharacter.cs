namespace Strings.Strings
{
    public class FirstUniqueCharacter
    {
        public int FirstUniqChar(string s)
        {
            // Dictionary to store character counts
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // First pass: Count occurrences of each character
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            // Second pass: Find the first character with count 1
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    return i; // Return the index of the first unique character
                }
            }

            return -1;

        }

        //or-easy way
        public int SimpleFirstUniqChar(string s)
        {
           return s.Select((c,i)=> new {Char = c, Index=i})
                   .FirstOrDefault(x=>s.Count(c=>c==x.Char)==1)?.Index ?? -1;
        }
    }
}

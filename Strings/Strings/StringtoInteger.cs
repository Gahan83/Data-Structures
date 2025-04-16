namespace Strings.Strings
{
    public class StringtoInteger
    {
        public int MyAtoi(string s)
        {
            int i = 0, sign = 1, result = 0;
            int n = s.Length;

            //step 1: ignore leading whitespace

            while (i < n && s[i] == ' ')
            {
                i++;
            }

            //step 2: check for sign 
            if (i < n && s[i] == '+' || s[i] == '-')
            {
                sign = (s[i] == '-') ? -1 : 1;
                i++;
            }

            // step 3: Convert digit to integer
            while (i < n && char.IsDigit(s[i]))
            {
                int digit = s[i] - '0';

                //Step 4: Handle Overflow cases
                if (result > (int.MaxValue - digit) / 10)
                {
                    return (sign == 1) ? int.MaxValue : int.MinValue;
                }

                result = result * 10 + digit;
                i++;
            }
            return result * sign;
        }
    }

}

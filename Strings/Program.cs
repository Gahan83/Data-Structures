// See https://aka.ms/new-console-template for more information
using Strings.Strings;


//-----------------------------------------------------
//STRINGS:

//Reverse String:
//char[] c = { 'h', 'e', 'l', 'l', 'o' };
//ReverseString reverseString = new ReverseString();
//reverseString.Reverse(c);
//Console.WriteLine(string.Join("", c));

//var s= c.Reverse().ToArray();   
//Console.WriteLine(string.Join("",s));

//Reverse Integer:
//int x = 123;
//int x1 = -123;
//int x2 = 120;

//ReverseInteger reverseInteger = new ReverseInteger();
//int r= reverseInteger.Reverse(x2);
//Console.WriteLine(r);

//FirstUniqueCharacter solution = new FirstUniqueCharacter();

//Console.WriteLine(solution.FirstUniqChar("leetcode"));
//Console.WriteLine(solution.FirstUniqChar("loveleetcode"));
//Console.WriteLine(solution.FirstUniqChar("aabb"));

//Anagram anagram = new Anagram();

//string s = "anagram";
//string t = "nagaram";

//string s1 = "rat";
//string t2 = "cat";
//Console.WriteLine(anagram.isAnagram(s1, t2));


//Palindrome palindrome = new Palindrome();

//string s0 = "A man, a plan, a canal: Panama";
//Console.WriteLine(palindrome.IsPalindrome(s0));

//string s2 = "madam";
//Console.WriteLine(palindrome.IsPalindrome(s2));


//string s3 = "123321";
//Console.WriteLine(palindrome.IsPalindrome(s3));

//StringtoInteger stringtoInteger=new StringtoInteger();

//Console.WriteLine(stringtoInteger.MyAtoi("42"));         // Output: 42
//Console.WriteLine(stringtoInteger.MyAtoi("   -42"));     // Output: -42
//Console.WriteLine(stringtoInteger.MyAtoi("4193 with words")); // Output: 4193
//Console.WriteLine(stringtoInteger.MyAtoi("words and 987"));  // Output: 0
//Console.WriteLine(stringtoInteger.MyAtoi("-91283472332"));   // Output: -2147483648 (int.MinValue)

//strStr strStr = new strStr();

//Console.WriteLine(strStr.MyStrStr("sadbutsad", "sad"));   // Output: 0
//Console.WriteLine(strStr.MyStrStr("leetcode", "leeto")); // Output: -1
//Console.WriteLine(strStr.MyStrStr("hello", "ll"));       // Output: 2
//Console.WriteLine(strStr.MyStrStr("abcdef", "cd"));      // Output: 2
//Console.WriteLine(strStr.MyStrStr("aaaaa", "bba"));      // Output: -1

LongestCommonPrefix longestCommonPrefix = new LongestCommonPrefix();

Console.WriteLine(longestCommonPrefix.MyLongestCommonPrefix(new string[] { "flower", "flow", "flight" })); // Output: "fl"
Console.WriteLine(longestCommonPrefix.MyLongestCommonPrefix(new string[] { "dog", "racecar", "car" }));     // Output: ""
Console.WriteLine(longestCommonPrefix.MyLongestCommonPrefix(new string[] { "apple", "apricot", "ape" }));   // Output: "ap"
Console.WriteLine(longestCommonPrefix.MyLongestCommonPrefix(new string[] { "banana", "band", "banner" }));  // Output: "ban"
Console.WriteLine(longestCommonPrefix.MyLongestCommonPrefix(new string[] { "abc" }));                      // Output: "abc"
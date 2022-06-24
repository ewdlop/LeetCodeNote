namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// Not Manacher's Algorithm
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string LongestPalindrome(string s)
    {
        int sLength = s.Length;
        if (sLength < 2) return s;
        int maxLength = 1, begin = 0;
        bool[,] IsPalindromeSubstring = new bool[sLength, sLength];
        for (int i = 0; i < sLength; i++) IsPalindromeSubstring[i, i] = true;
        for (int l = 2; l <= sLength; l++)
        {
            for (int i = 0, j = l+i-1; i < sLength && j < sLength; i++, j++)
            {
                if ((IsPalindromeSubstring[i, j] = s[i] == s[j] && (j - i < 3 || IsPalindromeSubstring[i + 1, j - 1])) && j - i + 1 > maxLength)
                {
                    (maxLength, begin) = (j - i + 1, i);
                }
            }
        }
        return s.Substring(begin, maxLength);
    }
}

public static partial class StringExtension
{
    public static string GetLongestPalindromeSubstring(this string s)
    {
        int sLength = s.Length;
        if (sLength < 2) return s;
        int maxLength = 1, begin = 0;
        bool[,] IsPalindromeSubstring = new bool[sLength, sLength];
        for (int i = 0; i < sLength; i++) IsPalindromeSubstring[i, i] = true;
        for (int l = 2; l <= sLength; l++)
        {
            for (int i = 0, j = l + i - 1; i < sLength && j < sLength; i++, j++)
            {
                if ((IsPalindromeSubstring[i, j] = s[i] == s[j] && (j - i < 3 || IsPalindromeSubstring[i + 1, j - 1])) && j - i + 1 > maxLength)
                {
                    (maxLength, begin) = (j - i + 1, i);
                }
            }
        }
        return s.Substring(begin, maxLength);
    }
}
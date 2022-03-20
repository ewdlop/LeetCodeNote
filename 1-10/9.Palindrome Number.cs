namespace LeetCodeNote;

public partial interface ISolution
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static bool IsPalindrome(int x)
    {
        int original = x;
        int final = 0;
        while (x > 0)
        {
            int lastDigit = x % 10;
            final = final * 10 + lastDigit;
            x /= 10;
        }
        return final == original;
    }
}

public static partial class IntegerArrayExtension
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static bool IsPalindrome(this int x)
    {
        int original = x;
        int final = 0;
        while (x > 0)
        {
            int lastDigit = x % 10;
            final = final * 10 + lastDigit;
            x /= 10;
        }
        return final == original;
    }
}
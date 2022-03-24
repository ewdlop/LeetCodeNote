using System;

namespace LeetCodeNote;

public partial interface ISolution
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int LengthOfLongestSubstring(string s)
    {
        int result = 0;
        //sliding window
        Span<int> cache = stackalloc int[128];
        for (int rightAnchor = 0, leftAnchor = 0; rightAnchor < s.Length; rightAnchor++)
        {
            leftAnchor = cache[s[rightAnchor]] > 0 ? Math.Max(leftAnchor, cache[s[rightAnchor]]) : leftAnchor;
            cache[s[rightAnchor]] = rightAnchor + 1;
            result = Math.Max(result, rightAnchor - leftAnchor + 1);
        }
        return result;
    }
}

public static partial class StringExtension
{
    public static int LengthOfTheLongestSubstringWithoutRepeatingCharacters(this string s)
    {
        int result = 0;
        //sliding window
        Span<int> cache = stackalloc int[128];
        for (int rightAnchor = 0, leftAnchor = 0; rightAnchor < s.Length; rightAnchor++)
        {
            leftAnchor = cache[s[rightAnchor]] > 0 ? Math.Max(leftAnchor, cache[s[rightAnchor]]) : leftAnchor;
            cache[s[rightAnchor]] = rightAnchor + 1;
            result = Math.Max(result, rightAnchor - leftAnchor + 1);
        }
        return result;
    }
}
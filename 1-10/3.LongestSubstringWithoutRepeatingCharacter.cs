using System;

namespace LeetCodeNote;

public static partial class Solution
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
        Span<int> seen = stackalloc int[128];
        for (int rightAnchor = 0, leftAnchor = 0; rightAnchor < s.Length; rightAnchor++)
        {
            leftAnchor = seen[s[rightAnchor]] > 0 ? Math.Max(leftAnchor, seen[s[rightAnchor]]) : leftAnchor;
            seen[s[rightAnchor]] = rightAnchor + 1;
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
        Span<int> seen = stackalloc int[128];
        for (int rightAnchor = 0, leftAnchor = 0; rightAnchor < s.Length; rightAnchor++)
        {
            leftAnchor = seen[s[rightAnchor]] > 0 ? Math.Max(leftAnchor, seen[s[rightAnchor]]) : leftAnchor;
            seen[s[rightAnchor]] = rightAnchor + 1;
            result = Math.Max(result, rightAnchor - leftAnchor + 1);
        }
        return result;
    }
}
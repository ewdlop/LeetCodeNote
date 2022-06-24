using System;

namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// https://leetcode.com/problems/isomorphic-strings/
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public static bool IsIsomorphic(string s, string t)
    {
        Span<int> encodedS = stackalloc int[256];
        Span<int> encodedT = stackalloc int[256];
        for (int i = 0; i < s.Length; i++)
        {
            if (encodedS[s[i]] != encodedT[t[i]])
            {
                return false;
            }
            encodedS[s[i]] = i + 1;
            encodedT[t[i]] = i + 1;
        }
        return true;
    }
}

public static partial class StringExtension
{
    public static bool IsIsomorphic(this string s, string t)
    {
        Span<int> encodedS = stackalloc int[256];
        Span<int> encodedT = stackalloc int[256];
        for (int i = 0; i < s.Length; i++)
        {
            if (encodedS[s[i]] != encodedT[t[i]])
            {
                return false;
            }
            encodedS[s[i]] = i + 1;
            encodedT[t[i]] = i + 1;
        }
        return true;
    }
}
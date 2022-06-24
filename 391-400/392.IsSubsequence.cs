namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// https://leetcode.com/problems/is-subsequence/
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public static bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0) return true;
        int anchor = 0;
        foreach (var c in t)
        {
            if (c == s[anchor]) anchor++;
            if (anchor == s.Length) return true;
        }
        return false;
    }

    public static bool IsSubsequence2(string given, string s)
    {
        if (s.Length == 0) return true;
        int anchor = 0;
        foreach (var c in given)
        {
            if (c == s[anchor]) anchor++;
            if (anchor == s.Length) return true;
        }
        return false;
    }
}

namespace LeetCodeNote;

public partial interface ISolution
{
    /// <summary>
    /// https://leetcode.com/problems/is-subsequence/
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public bool IsSubsequence(string s, string t)
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

    public bool IsSubsequence2(string given, string s)
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

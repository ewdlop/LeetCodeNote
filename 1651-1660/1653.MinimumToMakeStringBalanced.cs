using System;

namespace LeetCodeNote;
public static partial class Solution
{
    public static int MinimumDeletions(string s)
    {
        int contB = 0;
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a') result = Math.Min(++result, contB);
            else if (s[i] == 'b') contB++;
        }
        return result;
    }
}

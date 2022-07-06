using System;
using System.Collections.Generic;

namespace LeetCodeNote;

public static partial class Solution
{
    public static int MinDeletions(string s)
    {
        int result = 0;
        Span<int> count = stackalloc int[26];
        HashSet<int> used = new HashSet<int>();
        for(int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a'] = count[s[i] - 'a'] + 1;
        }
        for (int i = 0; i < 26; i++)
        {
            while(count[i] > 0 && !used.Add(count[i]))
            {
                count[i] = count[i] - 1;
                result++;
            }
        }
        return result;
    }
}

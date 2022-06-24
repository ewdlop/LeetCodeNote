using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeNote;

public static partial class Solution
{
    public static string[] DivideString(string s, int k, char fill)
    {
        StringBuilder[] result = new StringBuilder[(s.Length + k - 1) / k];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = new StringBuilder(new string(fill, k));
        }

        for (int i = 0; i < s.Length; i++)
        {
            result[i / k][i % k] = s[i];
        }

        return result.Select(r => r.ToString()).ToArray();
    }
}

using System;
using System.Linq;

namespace LeetCodeNote;

public static partial class Solution
{
    public static string GetSmallestString(int n, int k)
    {
        int l = (int)Math.Ceiling((k - n) / 25.0f);
        return $"{string.Join("", Enumerable.Repeat('a', n - l))}{(char)(k - (n - l) - (l - 1) * 26 + 'a' - 1)}{string.Join("", Enumerable.Repeat('z', l - 1))}";
    }
}

using System;
using System.Linq;

namespace LeetCodeNote;

public static partial class Solution
{
    public static string GetSmallestString(int n, int k)
    {
        //Span<char> x = stackalloc char[n];
        ////x.Fill('a');
        //Memory<char> m = new char[2];
        //(Memory<char> x, Memory<char> y, Memory<char> z) = (new char[n], new char[n], new char[n]);
        int l = (int)System.Math.Ceiling((k - n) / 25.0f);
        return $"{string.Join("", Enumerable.Repeat('a', n - l))}" +
               $"{(char)(k - (n - l) - (l - 1) * 26 + 'a' - 1)}" +
               $"{string.Join("", Enumerable.Repeat('z', l - 1))}";
    }
}

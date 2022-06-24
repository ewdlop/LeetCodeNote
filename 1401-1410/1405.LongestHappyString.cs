using System;
using System.Text;

namespace LeetCodeNote;

public static partial class Solution
{
    public static string LongestDiverseString(int a, int b, int c, char aa = 'a', char bb = 'b', char cc = 'c')
    {
        if (a < b) return LongestDiverseString(b, a, c, bb, aa, cc); // b > a ? c
        if (b < c) return LongestDiverseString(a, c, b, aa, cc, bb); // a > c > b  
        if (b == 0) return new string(aa, Math.Min(2, a)); // a > b, b = c = 0
        //a > b > c
        int use_a = Math.Min(2, a), use_b = a - use_a >= b ? 1 : 0;
        return $"{new string(aa, use_a)}{new string(bb, use_b)}{LongestDiverseString(a - use_a, b - use_b, c, aa, bb, cc)}";
    }
    
    public static string LongestDiverseString(int a, int b, int c)
    {
        return LongestDiverseStringBuilder(a, b, c, stringBuilder: new StringBuilder()).ToString();
    }

    public static StringBuilder LongestDiverseStringBuilder(int a, int b, int c, char aa = 'a', char bb = 'b', char cc = 'c', StringBuilder? stringBuilder = null)
    {
        if (stringBuilder is null) stringBuilder = new StringBuilder();
        if (a < b) return LongestDiverseStringBuilder(b, a, c, bb, aa, cc, stringBuilder); // b > a ? c
        if (b < c) return LongestDiverseStringBuilder(a, c, b, aa, cc, bb, stringBuilder); // a > c > b  
        if (b == 0)
        {
            Span<char> chars = stackalloc char[Math.Min(2, a)];
            chars.Fill(aa);
            return stringBuilder.Append(chars);
        }// a > b, b = c = 0
        //a > b > c
        int use_a = Math.Min(2, a), use_b = a - use_a >= b ? 1 : 0;
        Span<char> achars = stackalloc char[use_a];
        achars.Fill(aa);
        Span<char> bchars = stackalloc char[use_b];
        bchars.Fill(bb);
        return stringBuilder.Append(achars)
            .Append(bchars)
            .Append(LongestDiverseStringBuilder(a - use_a, b - use_b, c, aa, bb, cc));
    }
}

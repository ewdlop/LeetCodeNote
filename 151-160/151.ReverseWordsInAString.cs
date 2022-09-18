using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNote;

public static partial class Solution
{
    public static string ReverseWords(string s)
    {
        IEnumerable<string> pts = s.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Reverse();
        return string.Join(' ', pts);
    }
}
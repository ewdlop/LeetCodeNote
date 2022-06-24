using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// https://leetcode.com/problems/generate-parentheses/m
    /// Space Complexity = Catalan number * n
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static IList<string> GenerateParenthesis(int n)
    {
        List<string> result = new();
        if (n == 0)
        {
            result.Add(string.Empty);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                var list = GenerateParenthesis(i);
                for (var index = 0; index < list.Count; index++)
                {
                    string left = list[index];
                    foreach (string right in GenerateParenthesis(n - 1 - i))
                    {
                        result.Add($"({left}){right}");
                    }
                }
            }
        }
        return result;
    }
}

public static partial class IntegerExtension
{
    public static IList<string> GenerateParenthesis(this int n)
    {
        List<string> result = new();
        if (n == 0)
        {
            result.Add(string.Empty);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                result.AddRange(GenerateParenthesis(i).SelectMany(_ => GenerateParenthesis(n - 1 - i),
                    (left, right) => $"({left}){right}"));
            }
        }
        return result;
    }
}
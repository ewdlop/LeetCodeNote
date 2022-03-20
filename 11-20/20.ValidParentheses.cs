using System.Collections.Generic;

namespace LeetCodeNote;

public partial interface ISolution
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static bool IsValidParentheses(string s)
    {
        Stack<char> characterStack = new();
        foreach (char c in s)
        {
            switch (c)
            {
                case '(':
                    characterStack.Push(')');
                    break;
                case '{':
                    characterStack.Push('}');
                    break;
                case '[':
                    characterStack.Push(']');
                    break;
                default:
                {
                    if (characterStack.Count == 0 || characterStack.Pop() != c) return false;
                    break;
                }
            }
        }
        return characterStack.Count == 0;
    }
}

public static partial class StringExtension
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static bool IsValid(this string s)
    {
        Stack<char> characterStack = new();
        foreach (char c in s)
        {
            switch (c)
            {
                case '(':
                    characterStack.Push(')');
                    break;
                case '{':
                    characterStack.Push('}');
                    break;
                case '[':
                    characterStack.Push(']');
                    break;
                default:
                {
                    if (characterStack.Count == 0 || characterStack.Pop() != c) return false;
                    break;
                }
            }
        }
        return characterStack.Count == 0;
    }
}
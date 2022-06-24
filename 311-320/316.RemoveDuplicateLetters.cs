using System.Collections.Generic;
using System.Text;

namespace LeetCodeNote;

public static partial class Solution
{
    public static string RemoveDuplicateLetters(string s)
    {
        Stack<char> stack = new();
        HashSet<char> seen = new();
        Dictionary<char, int> lastOccurence = new();

        for (int i = 0; i < s.Length; i++)
        {
            lastOccurence[s[i]] = i;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (seen.Contains(s[i])) continue;
            while (stack.Count > 0 && s[i].CompareTo(stack.Peek()) < 0 && lastOccurence[stack.Peek()] > i)
            {
                seen.Remove(stack.Pop());
                //lastOccurence[stack.Peek()] > i allows it to be added again after
            }
            seen.Add(s[i]);
            stack.Push(s[i]);
        }
        StringBuilder sb = new StringBuilder(stack.Count);
        foreach (char c in stack)
        {
            sb.Insert(0, c);
        }
        return sb.ToString();
    }
}

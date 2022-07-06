namespace LeetCodeNote;

public static partial class Solution
{
    public static void ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            (s[left], s[right]) = (s[right--], s[left++]);
        }
    }
}

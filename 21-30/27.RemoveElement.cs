using System;

namespace LeetCodeNote;

public partial interface ISolution
{
    /// <summary>
    /// https://leetcode.com/problems/remove-element/
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public int RemoveElement(int[] nums, int val)
    {
        int begin = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[begin++] = nums[i];
            }
        }
        return begin;
    }

    /// <summary>
    /// Modifies the original
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public static int RemoveAllOccurrences(ref int[] nums, int val)
    {
        int begin = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[begin++] = nums[i];
            }
        }
        return begin;
    }
}

public static partial class IntegerArrayExtension
{
    public static int[] ToAllOccurrencesRemoved(this int[] nums, int val)
    {
        int begin = 0;
        Span<int> span = stackalloc int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                span[begin++] = nums[i];
            }
        }
        return span[..begin].ToArray();
    }
}
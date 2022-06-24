using System;

namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int RemoveDuplicates(int[] nums)
    {
        int duplicateCount = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1]) duplicateCount++;
            else nums[i - duplicateCount] = nums[i];
        }
        return nums.Length - duplicateCount;
    }
}

public static partial class IntegerArrayExtension
{
    public static int RemoveDuplicates(this int[] nums, bool isSorted = false)
    {
        if(!isSorted) Array.Sort(nums);
        int duplicateCount = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1]) duplicateCount++;
            else nums[i - duplicateCount] = nums[i];
        }
        return nums.Length - duplicateCount;
    }
}

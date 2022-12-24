using System;

namespace LeetCodeNote;

public static partial class Solution
{
    public static int MinMoves(int[] nums)
    {
        int sum = 0;
        int min = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }
        return sum - min * nums.Length;
    }
}
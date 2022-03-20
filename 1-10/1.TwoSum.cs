using System.Collections.Generic;

namespace LeetCodeNote;

public partial interface ISolution
{
    /// <summary>
    ///  https://leetcode.com/problems/two-sum
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> differenceMap = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (differenceMap.TryGetValue(nums[i], out int index))
            {
                return new[] { i, index };
            }
            differenceMap.TryAdd(target - nums[i], i);
        }
        return new[] { 0, 1 };
    }

    public static (bool hasTwoSum, int[]? result) TryGetTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> differenceMap = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (differenceMap.TryGetValue(nums[i], out int index))
            {
                return (true, new[] { i, index });
            }
            differenceMap.TryAdd(target - nums[i], i);
        }
        return (false, null);
    }
}
public static partial class IntegerArrayExtension
{
    public static int[] ToTwoSum(this int[] nums, int target)
    {
        Dictionary<int, int> differenceMap = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (differenceMap.TryGetValue(nums[i], out int index))
            {
                return new [] { i, index };
            }
            differenceMap.TryAdd(target - nums[i], i);
        }
        return new[] { 0, 1 };
    }
    public static (bool hasTwoSum, int[]? result) TryGetTwoSum(this int[] nums, int target)
    {
        Dictionary<int, int> differenceMap = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (differenceMap.TryGetValue(nums[i], out int index))
            {
                return (true, new[] { i, index });
            }
            differenceMap.TryAdd(target - nums[i], i);
        }
        return (false, null);
    }
}
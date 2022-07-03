using System.Collections.Generic;

namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// Use Prefix sum
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public static int SubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int sum = 0;
        int total = 0;
        map[sum] = 1;
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (map.ContainsKey(sum - k))
            {
                total += map[sum - k];
            }
            if (map.TryGetValue(sum, out int value))
            {
                map[sum] = value + 1;
            }
            else
            {
                map[sum] = 1;
            }
        }
        return total;
    }
}
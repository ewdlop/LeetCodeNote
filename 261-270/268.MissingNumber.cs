namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// https://leetcode.com/problems/missing-number/
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int MissingNumber(int[] nums)
    {
        double sum = 0.5 * (nums.Length + 1) * nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            sum -= nums[i];
        }
        return (int)sum;
    }

    public static int MissingNumberInRangeXOR(int[] nums)
    {
        int missing = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            missing ^= i ^ nums[i];
        }
        return missing;
    }
}

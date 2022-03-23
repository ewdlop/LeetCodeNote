namespace LeetCodeNote;

public partial interface ISolution
{
    /// <summary>
    /// https://leetcode.com/problems/missing-number/
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MissingNumber(int[] nums)
    {
        double sum = 0.5 * (nums.Length + 1) * nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            sum -= nums[i];
        }
        return (int)sum;
    }

    public int MissingNumberXOR(int[] nums)
    {
        int missing = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            missing ^= i ^ nums[i];
        }
        return missing;
    }
}

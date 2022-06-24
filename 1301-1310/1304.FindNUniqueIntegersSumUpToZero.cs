namespace LeetCodeNote;

public static partial class Solution
{
    public static int[] SumZero(int n)
    {
        int[] nums = new int[n];
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] = i;
        }
        nums[0] = -1 * n*(n + 1)/2;
        return nums;
    }

    public static int[] SumZero2(int n)
    {
        int[] nums = new int[n];
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] = i * 2 - n + 1;
        }
        return nums;
    }
}

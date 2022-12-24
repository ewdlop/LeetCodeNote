namespace LeetCodeNote;

public static partial class Solution
{
    public static void WiggleSort(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (i % 2 == 0 && nums[i] > nums[i + 1] ||
               (i % 2 == 1 && nums[i] < nums[i + 1] ))
            {
                (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
            }
        }
    }
}
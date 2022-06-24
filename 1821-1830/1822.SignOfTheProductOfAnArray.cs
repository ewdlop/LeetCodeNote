namespace LeetCodeNote;

public static partial class Solution
{
    public static int ArraySign(int[] nums)
    {
        int sign = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            switch (nums[i])
            {
                case 0:
                    return 0;
                default:
                    if (nums[i] < 0) sign *= -1;
                    break;
            }
        }
        return sign;
    }
}

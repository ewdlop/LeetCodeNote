namespace LeetCodeNote;

public partial interface ISolution
{
    public int NumberOfArithmeticSlices(int[] nums)
    {
        int current = 0;
        int total = 0;
        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] == nums[i - 1] - nums[i - 2])
            {
                total += ++current;
            }
            else
            {
                current = 0;
            }
        }
        return total;
    }

    public (bool IsArithmetic, int count) HasArithmeticSlices(int[] nums)
    {
        int current = 0;
        int total = 0;
        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] == nums[i - 1] - nums[i - 2])
            {
                total += ++current;
            }
            else
            {
                current = 0;
            }
        }
        return (total > 0, total);
    }
}

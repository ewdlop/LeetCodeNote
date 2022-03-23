namespace LeetCodeNote;

public partial interface ISolution
{
    /// <summary>
    /// https://leetcode.com/problems/counting-bits/
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] CountBits(int n)
    {
        int[] counts = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            counts[i] = counts[i / 2] + i % 2;
        }
        return counts;
    }

    public int[] Count1BitsInRange(int n)
    {
        int[] counts = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            counts[i] = counts[i & (i - 1)] + 1;
        }
        return counts;
    }
}

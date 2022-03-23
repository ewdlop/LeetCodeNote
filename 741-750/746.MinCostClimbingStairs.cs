using System;

namespace LeetCodeNote;

public partial interface ISolution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        (int n, int first, int second) = (cost.Length, cost[0], cost[1]);
        if (n <= 2) return Math.Min(first, second);
        for (int i = 2; i < n; i++)
        {
            (first, second) = (second, cost[i] + Math.Min(first, second));
        }
        return Math.Min(first, second);
    }
}

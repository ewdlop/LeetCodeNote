using System;
using System.Collections.Generic;

namespace LeetCodeNote;

public partial interface ISolution
{

    public class PriceComparer : IComparer<int[]>
    {
        int IComparer<int[]>.Compare(int[] o1, int[] o2)
        {
            return o1[0] - o1[1] - (o2[0] - o2[1]);
        }
    }

    public int TwoCitySchedCost(int[][] costs)
    {
        Array.Sort(costs, new PriceComparer());
        int total = 0;
        int n = costs.Length / 2;
        // To optimize the company expenses,
        // send the first n persons to the city A
        // and the others to the city B
        for (int i = 0; i < n; ++i) total += costs[i][0] + costs[i + n][1];
        return total;
    }
}

using System.Collections.Generic;

namespace LeetCodeNote;

public static partial class Solution
{
    public static int MaxNumberOfFamilies(int n, int[][] reservedSeats)
    {
        Dictionary<int, int> graph = new Dictionary<int, int>();
        foreach (int[] reserved in reservedSeats)
        {
            int row = reserved[0];
            int col = reserved[1];

            graph[row] = graph.GetValueOrDefault(row, 0) | (1 << col);
        }
        int max = 0;
        foreach(int key in graph.Keys)
        {
            int reserved = graph[key];
            int count = 0;
            if((reserved & 60) ==0) count++;
            if ((reserved & 240) == 0 && count == 0) count = 1;
            if((reserved & 960) == 0) count++;
            max += count;
        }
        return max + 2 * (n - graph.Count);
    }
}
using System;

namespace LeetCodeNote;


public static partial class Solution
{
    public static int MaximalNetworkRank(int n, int[][] roads)
    {
        int[] degree = new int[n];
        int maxRank = int.MinValue;
        int[,] adjcentMatrix = new int[n, n];
        for (int i = 0; i < roads.Length; i++)
        {
            int[] road = roads[i];
            degree[road[0]]++;
            degree[road[1]]++;
            adjcentMatrix[road[0], road[1]] = 1;
            adjcentMatrix[road[1], road[0]] = 1;
        }
        //upper trianglular matrix except diagonal
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                maxRank = Math.Max(maxRank, degree[i] + degree[j] - adjcentMatrix[i, j]);
            }
        }
        return maxRank;
    }
}

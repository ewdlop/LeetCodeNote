using System;

namespace LeetCodeNote;

public partial interface ISolution
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-domino-rotations-for-equal-row/
    /// </summary>
    /// <param name="top"></param>
    /// <param name="bottom"></param>
    /// <returns></returns>
    public int MinDominoRotations(int[] top, int[] bottom)
    {
        int[] countA = new int[7], countB = new int[7], same = new int[7];
        int n = top.Length;
        for (int i = 0; i < n; ++i)
        {
            countA[top[i]]++;
            countB[bottom[i]]++;
            if (top[i] == bottom[i])
                same[top[i]]++;
        }
        for (int i = 1; i < 7; ++i)
        {
            if (countA[i] + countB[i] - same[i] == n)
            {
                return n - Math.Max(countA[i], countB[i]);
            }
        }

        return -1;
    }

    public (bool possible, int? move) IsMinDominoRotationsPossible(int[] top, int[] bottom)
    {
        int[] countA = new int[7], countB = new int[7], same = new int[7];
        int n = top.Length;
        for (int i = 0; i < n; ++i)
        {
            countA[top[i]]++;
            countB[bottom[i]]++;
            if (top[i] == bottom[i])
                same[top[i]]++;
        }
        for (int i = 1; i < 7; ++i)
        {
            if (countA[i] + countB[i] - same[i] == n)
            {
                return (true, n - Math.Max(countA[i], countB[i]));
            }
        }

        return (false, null);
    }
}

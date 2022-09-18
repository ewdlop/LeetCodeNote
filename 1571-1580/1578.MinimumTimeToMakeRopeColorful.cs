using System;

namespace LeetCodeNote;

public static partial class Solution
{
    public static int MinimumTimeToMakeRopeColorful(string colors, int[] neededTime)
    {
        int totalTime = 0;
        int currentMaxTime = 0;

        for (int i = 0; i < colors.Length; i++)
        {
            if (i > 0 && colors[i - 1] != colors[i])
            {
                currentMaxTime = 0;
            }

            totalTime += Math.Min(currentMaxTime, neededTime[i]);
            currentMaxTime = Math.Max(currentMaxTime, neededTime[i]);
        }
        return totalTime;
    }
}

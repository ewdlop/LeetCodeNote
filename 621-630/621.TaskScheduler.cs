using System;

namespace LeetCodeNote;

public static partial class Solution
{
    public static int LeastInterval(char[] tasks, int n)
    {
        Span<int> counts = stackalloc int[26];
        int usingMax = 0;
        int usingMaxCount = 0;
        for(int i = 0; i < tasks.Length; i++)
        {
            counts[tasks[i] - 'A']++;
            if (counts[tasks[i] - 'A'] > usingMax)
            {
                usingMax = counts[tasks[i] - 'A'];
                usingMaxCount = 1;
            }
            else if (counts[tasks[i] - 'A'] == usingMax)
            {
                usingMaxCount++;
            }
        }

        int partition = usingMax - 1;
        int partitionLength = n - (usingMaxCount - 1);
        int emptySlots = partition * partitionLength;
        int availableTasks = tasks.Length - usingMax * usingMaxCount;
        int idles = Math.Max(0, emptySlots - availableTasks);
        return tasks.Length + idles;
    }

    public static int LeastInterval2(char[] tasks, int n)
    {
        Span<int> counts = stackalloc int[26];
        int usingMax = 0;
        int usingMaxCount = 0;
        for (int i = 0; i < tasks.Length; i++)
        {
            counts[tasks[i] - 'A']++;
            if (counts[tasks[i] - 'A'] == usingMax)
            {
                usingMaxCount++;
            }
            else if (counts[tasks[i] - 'A'] > usingMax)
            {
                usingMaxCount = 1;
                usingMax = counts[tasks[i] - 'A'];
            }
        }
        int emptyGapsCount = usingMax - 1; //number of empty gaps
        int gapLength = n + 1;
        return Math.Max(tasks.Length, emptyGapsCount * gapLength + usingMaxCount);
    }
}

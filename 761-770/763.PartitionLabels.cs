using System;
using System.Collections.Generic;

namespace LeetCodeNote;

public partial interface ISolution
{
    /// <summary>
    /// https://leetcode.com/problems/partition-labels/
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public IList<int> PartitionLabels(string s)
    {
        Span<int> lastPlaceOfOccurrenceForLetter = stackalloc int[26];
        for (int i = 0; i < s.Length; ++i)
        {
            lastPlaceOfOccurrenceForLetter[s[i] - 'a'] = i;
        }
        int partitionEndAnchor = 0, previousPartitionStartAnchor = 0;
        IList<int> partitions = new List<int>();
        for (int i = 0; i < s.Length; ++i)
        {
            partitionEndAnchor = Math.Max(partitionEndAnchor, lastPlaceOfOccurrenceForLetter[s[i] - 'a']);
            if (i != partitionEndAnchor) continue;
            partitions.Add(i - previousPartitionStartAnchor + 1);
            previousPartitionStartAnchor = i + 1;
        }
        return partitions;
    }
}

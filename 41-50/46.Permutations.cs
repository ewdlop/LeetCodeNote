using System.Collections.Generic;

namespace LeetCodeNote;

public static partial class Solution
{
    public static IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> permutations = new List<IList<int>>();
        Backtrack(nums.Length, ref nums, ref permutations, 0);
        return permutations;
    }

    private static void Backtrack(int n, ref int[] nums, ref IList<IList<int>> permutations, int first)
    {
        if (first == n)
        {
            permutations.Add(new List<int>(nums));
        }

        for (int i = first; i < n; i++)
        {
            (nums[first], nums[i]) = (nums[i], nums[first]); //prepare for backtracking
            Backtrack(n, ref nums, ref permutations, first + 1);
            (nums[first], nums[i]) = (nums[i], nums[first]); //backtrack
        }
    }
}

public static partial class IntegerArrayExtension
{
    public static IList<IList<int>> ToPermutation(this int[] nums)
    {
        IList<IList<int>> permutations = new List<IList<int>>();
        Backtrack(nums.Length, ref nums, ref permutations, 0);
        return permutations;
    }

    private static void Backtrack(int n, ref int[] nums, ref IList<IList<int>> permutations, int first)
    {
        if (first == n)
        {
            permutations.Add(new List<int>(nums));
        }

        for (int i = first; i < n; i++)
        {
            (nums[first], nums[i]) = (nums[i], nums[first]); //prepare for backtracking
            Backtrack(n, ref nums, ref permutations, first + 1);
            (nums[first], nums[i]) = (nums[i], nums[first]); //backtrack
        }
    }
}
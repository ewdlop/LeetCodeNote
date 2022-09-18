namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// this is a place holder
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    private static bool Knows(int a, int b) => true;
    public static int FindCelebrity(int n)
    {
        if (n <= 0) return -1;
        int candidate = 0;
        for (int i = candidate; i < n; i++)
        {
            if (Knows(candidate, i))
            {
                candidate = i;
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (i != candidate && (Knows(candidate, i) || !(Knows(i, candidate)))) return -1;
        }
        return candidate;
    }
}
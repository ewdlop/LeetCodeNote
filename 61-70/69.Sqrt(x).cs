namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// https://leetcode.com/problems/sqrtx/. Newton's method
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int MySqrt(int x)
    {
        long r = x;
        while (r * r > x) //convergence criteria
        {
            r = (r + x / r) >> 1;
        }
        return (int)r;
    }
}
public static partial class IntegerExtension
{
    public static int ToSqrt(this int x)
    {
        long r = x;
        while (r * r > x) //convergence criteria
        {
            r = (r + x / r) >> 1;
        }
        return (int)r;
    }
}
namespace LeetCodeNote;

public static partial class IntegerExtension
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int Reverse(int x)
    {
        int prevReverse = 0;
        int reverse = 0;
        while (x != 0)
        {
            reverse = reverse * 10 + x % 10;
            if ((reverse - x % 10) / 10 != prevReverse)
            {
                return 0;
            }
            prevReverse = reverse;
            x /= 10;
        }
        return reverse;
    }
}

public static partial class IntegerExtension
{
    public static int ToReverse(this int x)
    {
        int prevReverse = 0;
        int reverse = 0;
        while (x != 0)
        {
            reverse = reverse * 10 + x % 10;
            if ((reverse - x % 10) / 10 != prevReverse)
            {
                return 0;
            }
            prevReverse = reverse;
            x /= 10;
        }
        return reverse;
    }
}
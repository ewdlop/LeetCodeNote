namespace LeetCodeNote;

public static partial class Solution
{
    public static double Pow(double x, int n) =>
        n switch
        {
            0 => 1,
            < 0 => 1 / x * Pow(1 / x, -(n + 1)),
            _ => n % 2 == 0 ? Pow(x * x, n / 2) : x * Pow(x * x, n / 2)
        };
}

public static partial class DoubleExtension
{
    public static double Pow(this double x, int n) =>
        n switch
        {
            0 => 1,
            < 0 => 1 / x * Pow(1 / x, -(n + 1)),
            _ => n % 2 == 0 ? Pow(x * x, n / 2) : x * Pow(x * x, n / 2)
        };
}
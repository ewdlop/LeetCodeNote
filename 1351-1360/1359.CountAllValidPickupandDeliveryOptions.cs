namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// https://leetcode.com/problems/count-all-valid-pickup-and-delivery-options/
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int CountOrders(int n)
    {
        long res = 1;
        long mod = (long)1e9 + 7;
        for (int i = 1; i <= n; i++)
        {
            res = res * (i * 2 - 1) * i % mod;
        }
        //total ways to arrange all pickups and deliveries = N!*Product over from i = 1...N of (2*i -1)
        return (int)res;
    }
}

public static partial class IntegerExtension
{
    public static int ArrangementsOFNOrdersAndDelivery(this int n)
    {
        long res = 1;
        long mod = (long)1e9 + 7;
        for (int i = 1; i <= n; i++)
        {
            res = res * (i * 2 - 1) * i % mod;
        }
        //total ways to arrange all pickups and deliveries = N!*Product over from i = 1...N of (2*i -1)
        return (int)res;
    }
}
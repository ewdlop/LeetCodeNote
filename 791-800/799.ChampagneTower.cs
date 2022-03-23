namespace LeetCodeNote;

public partial interface ISolution
{
    /// <summary>
    /// https://leetcode.com/problems/champagne-tower/
    /// </summary>
    /// <param name="poured"></param>
    /// <param name="query_row"></param>
    /// <param name="query_glass"></param>
    /// <returns></returns>
    public double ChampagneTower(int poured, int query_row, int query_glass)
    {
        double[,] result = new double[101, 101];
        result[0, 0] = poured;
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (!(result[i, j] >= 1)) continue;
                result[i + 1, j] += (result[i, j] - 1) / 2.0; //spill over/2
                result[i + 1, j + 1] += (result[i, j] - 1) / 2.0; //spillover/2
                result[i, j] = 1; //remainder
            }
        }
        return result[query_row, query_glass];
    }
}

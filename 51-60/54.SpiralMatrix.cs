using System.Collections.Generic;

namespace LeetCodeNote;

public static partial class Solution
{
    public static IList<int> SpiralOrder(int[][] matrix)
    {
        if (matrix is null || matrix.Length == 0  || matrix[0].Length == 0) return new List<int>();
        int n = matrix.Length;
        int m = matrix[0].Length;
        List<int> result = new List<int>(n * m);
        int up = 0;
        int down = n - 1;
        int left = 0;
        int right = m - 1;
        while (up <= down && left <= right)
        {
            for (int j = left; j <= right; j++)
            {
                result.Add(matrix[up][j]);
            }
            up++;
            for (int i = up; i <= down; i++)
            {
                result.Add(matrix[i][right]);
            }
            right--;

            if (up > down || left > right) break;
            
            for (int j = right; j >= left; j--)
            {
                result.Add(matrix[down][j]);
            }
            down--;
            for (int i = down; i >= up; i--)
            {
                result.Add(matrix[i][left]);
            }
            left++;
        }
        return result;
    }
}
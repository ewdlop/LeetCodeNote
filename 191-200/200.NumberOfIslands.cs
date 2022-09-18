using System.Collections.Generic;

namespace LeetCodeNote;

public static partial class Solution
{
    public static int NumIslands(char[][] grid)
    {
        if (grid is null || grid.Length == 0)
        {
            return 0;
        }
        int nr = grid.Length;
        int nc = grid[0].Length;
        int numberOfIslands = 0;

        for (int r = 0; r < nr; r++)
        {
            for (int c = 0; c < nc; c++)
            {
                if (grid[r][c] == '1')
                {
                    numberOfIslands++;
                    grid[r][c] = '0';
                    Queue<int> neighbors = new Queue<int>();
                    neighbors.Enqueue(r * nc + c);
                    while (neighbors.Count > 0)
                    {
                        int id = neighbors.Dequeue();
                        int row = id / nc;
                        int col = id % nc;
                        if (row - 1 >= 0 && grid[row - 1][col] == '1')
                        {
                            neighbors.Enqueue((row - 1) * nc + col);
                            grid[row - 1][col] = '0';
                        }
                        if (row + 1 < nr && grid[row + 1][col] == '1')
                        {
                            neighbors.Enqueue((row + 1) * nc + col);
                            grid[row + 1][col] = '0';
                        }
                        if (col - 1 >= 0 && grid[row][col - 1] == '1')
                        {
                            neighbors.Enqueue(row * nc + col - 1);
                            grid[row][col - 1] = '0';
                        }
                        if (col + 1 < nc && grid[row][col + 1] == '1')
                        {
                            neighbors.Enqueue(row * nc + col + 1);
                            grid[row][col + 1] = '0';
                        }
                    }
                }
            }
        }
        return numberOfIslands;
    }
}

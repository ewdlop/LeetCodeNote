using System.Collections.Generic;

namespace LeetCodeNote;

public static partial class Solution
{
    public static bool IsValidSudoku(char[][] board)
    {
        HashSet<string> seen = new HashSet<string>();
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char number = board[i][j];
                if (number == '.') continue;
                if (!seen.Add($"{number}r{i}") ||
                    !seen.Add($"{number}c{j}") ||
                    !seen.Add($"{number}{i / 3}{j / 3}"))
                    return false;
            }
        }
        return true;
    }
}

public static partial class CharArrayExtension
{
    public static bool IsValidSudokuBoard(this char[][] board)
    {
        HashSet<string> seen = new HashSet<string>();
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char number = board[i][j];
                if (number == '.') continue;
                if (!seen.Add($"{number}r{i}") ||
                    !seen.Add($"{number}c{j}") ||
                    !seen.Add($"{number}{i / 3}{j / 3}"))
                    return false;
            }
        }
        return true;
    }
}
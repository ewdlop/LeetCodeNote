﻿namespace LeetCodeNote;

public static partial class Solution
{
    public static bool JudgeCircle(string moves)
    {
        (int x, int y) = (0, 0);
        foreach (char ch in moves)
        {
            switch (ch)
            {
                case 'U':
                    y++;
                    break;
                case 'D':
                    y--;
                    break;
                case 'R':
                    x++;
                    break;
                case 'L':
                    x--;
                    break;
            }
        }
        return (x, y) == (0, 0);
    }

    public static bool JudgeCircle2(string moves)
    {
        (int x, int y) = (0, 0);
        for(int i = 0; i < moves.Length; i++)
        {
            switch (moves[i])
            {
                case 'U':
                    y++;
                    break;
                case 'D':
                    y--;
                    break;
                case 'R':
                    x++;
                    break;
                case 'L':
                    x--;
                    break;
            }
        }
        return (x, y) == (0, 0);
    }

    public static bool ReturnToOrigin(string moves)
    {
        (int x, int y) = (0, 0);
        foreach (char ch in moves)
        {
            switch (ch)
            {
                case 'U':
                    y++;
                    break;
                case 'D':
                    y--;
                    break;
                case 'R':
                    x++;
                    break;
                case 'L':
                    x--;
                    break;
            }
        }
        return (x, y) == (0, 0);
    }
}

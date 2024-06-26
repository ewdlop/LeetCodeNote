﻿namespace LeetCodeNote;

public static partial class Solution
{
    public static int MyAtoi(string s)
    {
        if (s is null || s == string.Empty)return 0;

        int res = 0,sign = 1;
        bool findSign = false,findDigit = false;

        foreach (var c in s)
        {
            if (!findSign && !findDigit && (c == '+' || c == '-'))
            {
                findSign = true;
                sign = c == '+' ? 1 : -1;
            }
            else if (c >= '0' && c <= '9')
            {
                findDigit = true;

                if (res == 0 && c == '0')
                    continue;
                else if (res > int.MaxValue / 10 || (res == int.MaxValue / 10 && c - '0' > int.MaxValue % 10))
                    return sign == 1 ? int.MaxValue : int.MinValue;
                else
                    res = res * 10 + (c - '0');
            }
            else if (c != ' ' || ((findDigit || findSign) && c == ' ') || (findDigit && c == '.'))
            {
                break;
            }
        }
            

        return res * sign;
    }
}
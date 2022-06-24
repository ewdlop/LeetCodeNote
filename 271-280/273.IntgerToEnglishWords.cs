using System;

namespace LeetCodeNote;

public static partial class Solution
{
    public readonly static Lazy<string[]> LESS_THAN_20 = new(() => new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" });
    public readonly static Lazy<string[]> TENS = new(()=> new string[] { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" });
    public readonly static Lazy<string[]> THOUSANDS = new(() => new string[] { "", "Thousand", "Million", "Billion" });

    public static string NumberToWords(int num)
    {
        if (num == 0) return "Zero";
        int i = 0;
        string words = string.Empty;
        while(num > 0)
        {
            if (num % 1000 != 0)
            {
                words = $"{GetGroup(num % 1000)}{THOUSANDS.Value[i]} {words}";
            }
            num /= 1000;
            i++;
        }
        return words.Trim();
    }

    public static string GetGroup(int num) => num switch
    {
        0 => string.Empty,
        < 20 => $"{LESS_THAN_20.Value[num]} ",
        < 100 => $"{TENS.Value[num / 10]} {GetGroup(num % 10)}",
        < 1000 => $"{LESS_THAN_20.Value[num / 100]} Hundred {GetGroup(num % 100)}",
        _ => $"{LESS_THAN_20.Value[num / 100]} Hundred {GetGroup(num % 100)}"
    };
}

public static partial class IntegerExtension
{
    public static string ToWords(this int num)
    {
        if (num == 0) return "Zero";
        int i = 0;
        string words = string.Empty;
        while (num > 0)
        {
            if (num % 1000 != 0)
            {
                words = $"{Solution.GetGroup(num % 1000)}{Solution.THOUSANDS.Value[i]} {words}";
            }
            num /= 1000;
            i++;
        }
        return words.Trim();
    }
}

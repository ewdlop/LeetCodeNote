using System;

namespace LeetCodeNote;

public partial interface ISolution
{
    /// <summary>
    /// https://leetcode.com/problems/complex-number-multiplication/
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public string ComplexNumberMultiply(string num1, string num2)
    {
        string[] newa = num1.Split("+");
        string[] newb = num2.Split("+");
        string[] newa2 = newa[1].Split("i");
        string[] newb2 = newb[1].Split("i");
        int real = int.Parse(newa[0]) * int.Parse(newb[0]) - int.Parse(newa2[0]) * int.Parse(newb2[0]);
        int img = int.Parse(newa[0]) * int.Parse(newb2[0]) + int.Parse(newa2[0]) * int.Parse(newb[0]);
        return $"{real}+{img}i";
    }
}

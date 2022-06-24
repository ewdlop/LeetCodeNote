using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeNote;

public static partial class Solution
{
    public int Sum(int num1, int num2) => (num1 ^ num2) + 2 * (num1 & num2);
}

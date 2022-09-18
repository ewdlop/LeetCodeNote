namespace LeetCodeNote;

public static partial class Solution
{
    public static int NumSteps(string s)
    {
        int result = 0;
        int carry = 0;
        for(int i = s.Length - 1; i > 0; i--)
        {
            result++; //shit right
            if (s[i] - '0' + carry == 1)
            {
                carry = 1;
                result++; //add one to it
            }
        }
        return result + carry;
    }
}

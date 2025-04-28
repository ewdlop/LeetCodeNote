using System;

namespace LeetCodeNote;

public static partial class Solution
{
    public static int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;

        int L = MaxDepth(root.left);
        int R = MaxDepth(root.right);
        return Math.Max(L, R) + 1;
    }
}

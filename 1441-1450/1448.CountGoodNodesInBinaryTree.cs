using System;

namespace LeetCodeNote;

public static partial class Solution
{
    public static int GoodNodes(TreeNode root, int currentMax = int.MinValue)
    {
        if (root is null) return 0;
        if (root.val < currentMax)
        {
            return GoodNodes(root.left, currentMax) + GoodNodes(root.right, currentMax);
        }
        else
        {
            return 1 + GoodNodes(root.left, root.val) + GoodNodes(root.right, root.val);
        }
    }
}
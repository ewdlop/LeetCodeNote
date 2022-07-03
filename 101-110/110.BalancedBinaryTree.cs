using System;

namespace LeetCodeNote;

public static partial class Solution
{
    public static bool IsBalanced(TreeNode root)
    {
        if (root is null) return true;
        return Math.Abs(Height(root.left) - Height(root.right)) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }

    public static int Height(TreeNode root)
    {
        if (root is null) return 0;
        return 1 + Math.Max(Height(root.left), Height(root.right));
    }

    public static bool IsBalanced2(TreeNode root)
    {
        return DepthFirstSearchHeight(root) != 0;
    }

    public static int DepthFirstSearchHeight(TreeNode root)
    {
        if (root is null) return 1;

        int leftHeight = DepthFirstSearchHeight(root.left);
        if (leftHeight == 0) return 0;
        int rightHeight = DepthFirstSearchHeight(root.right);
        if (rightHeight == 0) return 0;

        if (Math.Abs(leftHeight - rightHeight) > 1) return 0;
        return Math.Max(leftHeight, rightHeight) + 1;
    }

}

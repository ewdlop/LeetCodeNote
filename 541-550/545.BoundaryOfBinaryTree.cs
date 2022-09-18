using System.Collections.Generic;

namespace LeetCodeNote;

public static partial class Solution
{
    public static IList<int> BoundaryOfBinaryTree(TreeNode root)
    {
        IList<int> result = new List<int>();
        if (root is null) return result;
        result.Add(root.val);
        if (root.left is null && root.right is null) return result;
        LeftBoundary(root.left, ref result);
        Leaves(root, ref result);
        RightBoundary(root.right, ref result);
        return result;
    }

    private static void LeftBoundary(TreeNode root, ref IList<int> result)
    {
        if (root is null || (root.left is null && root.right is null)) return;
        result.Add(root.val);
        if (root.left is null)
        {
            LeftBoundary(root.right, ref result);
        }
        else
        {
            LeftBoundary(root.left, ref result);
        }
    }

    private static void RightBoundary(TreeNode root, ref IList<int> result)
    {
        if (root is null || (root.left is null && root.right is null)) return;
        if (root.right is null)
        {
            RightBoundary(root.left, ref result);
        }
        else
        {
            RightBoundary(root.right, ref result);
        }
        result.Add(root.val);
    }

    private static void Leaves(TreeNode root, ref IList<int> result)
    {
        if (root is null) return;
        if (root.left is null && root.right is null)
        {
            result.Add(root.val);
            return;
        }
        Leaves(root.left, ref result);
        Leaves(root.right, ref result);
    }
}

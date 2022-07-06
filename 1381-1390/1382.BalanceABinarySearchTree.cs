using System;
using System.Collections.Generic;

namespace LeetCodeNote;

public static partial class Solution
{
    public static TreeNode BalanceBST(TreeNode root)
    {
        if (root.left is null && root.right is null) return root;
        List<TreeNode> sortedList = new List<TreeNode>();
        InOrder(root, ref sortedList);
        return BuildBST(sortedList, 0, sortedList.Count - 1);
    }

    // InOrder traversal to get sorted list of nodes in BST
    public static void InOrder(TreeNode root, ref List<TreeNode> sortedList)
    {
        if (root is null) return;
        InOrder(root.left, ref sortedList);
        sortedList.Add(root);
        InOrder(root.right, ref sortedList);
    }

    public static TreeNode BuildBST(List<TreeNode> sortedList, int start, int end)
    {
        if (start > end) return null;
        int mid = (start + end) / 2;
        TreeNode root = sortedList[mid];
        root.left = BuildBST(sortedList, start, mid - 1);
        root.right = BuildBST(sortedList, mid + 1, end);
        return root;
    }
}

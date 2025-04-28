using System;
using System.Linq;

namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// need more details and understanding
    /// </summary>
    /// <param name="preorder"></param>
    /// <param name="inorder"></param>
    /// <returns></returns>
    public static TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder is null || !preorder.Any() ||
           inorder is null || !inorder.Any()) return null;

        TreeNode root = new TreeNode(preorder[0]);
        int middle = Array.IndexOf(inorder, preorder[0]);
        root.left = BuildTree(preorder[1..(middle + 1)], inorder[..middle]);
        root.right = BuildTree(preorder[(middle + 1)..], inorder[(middle + 1)..]);

        return root;
    }
}

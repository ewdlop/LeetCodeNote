using System.Collections.Generic;

namespace LeetCodeNote;

public static partial class Solution
{
    public static TreeNode? InvertTree(TreeNode? root)
    {
        if (root is null) return null;
        (root.left, root.right) = (InvertTree(root.right), InvertTree(root.left));
        return root;
    }

    public static TreeNode? InvertTree2(TreeNode? root)
    {
        if (root is null) return null;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();
            (node.left, node.right) = (node.right, node.left);
            if (node.left is not null) queue.Enqueue(node.left);
            if (node.right is not null) queue.Enqueue(node.right);
        }
        return root;
    }
}

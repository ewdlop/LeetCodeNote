namespace LeetCodeNote;

public static partial class Solution
{
    public static TreeNode? InvertTree(TreeNode? root)
    {
        if (root is null) return null;
        (root.left, root.right) = (InvertTreeHelper(root.right), InvertTreeHelper(root.left));
        return root;
    }

    public static TreeNode? InvertTreeHelper(TreeNode? root)
    {
        if (root is null) return root;
        if (root.left is not null && root.right is not null)
        {
            (root.left, root.right) = (InvertTreeHelper(root.right), InvertTreeHelper(root.left));
        }
        else if (root.left is not null)
        {
            (root.left, root.right) = (null, InvertTreeHelper(root.left));
        }
        else if (root.right is not null)
        {
            (root.left, root.right) = (InvertTreeHelper(root.right), null);
        }
        return root;
    }
}

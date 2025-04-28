namespace LeetCodeNote;

public static partial class Solution
{
    public static bool IsSymmetric(TreeNode root)
    {
        return IsMirror(root.left, root.right);
    }
    public static bool IsMirror(TreeNode root1, TreeNode root2)
    {

        if (root1 == null && root2 == null)
        {
            return true;
        }
        if (root1 == null || root2 == null)
        {
            return false;
        }
        if (root1.val != root2.val)
        {
            return false;
        }
        bool left = IsMirror(root1.left, root2.right);
        bool right = IsMirror(root1.right, root2.left);
        return (left && right);

    }
}
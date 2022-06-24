namespace LeetCodeNote;

public static partial class Solution
{
    public static bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root is null)
        {
            return false;
        }

        if (targetSum - root.val == 0 && root.left is null && root.right is null)
        {
            return true;
        }

        return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
    }
    public static bool HasPathSum(TreeNodeCustom? root, int targetSum) =>
        root is not null && (targetSum - root.Value == 0 && root.Left is null && root.Right is null ||
                             HasPathSum(root.Left, targetSum - root.Value) ||
                             HasPathSum(root.Right, targetSum - root.Value));
}

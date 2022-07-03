namespace LeetCodeNote;

public static partial class Solution
{
    public static TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if (root is null) return new TreeNode(val);
        TreeNode current = root;
        while(true)
        {
            if(current.val < val)
            {
                if (current.right is null)
                {
                    current.right = new TreeNode(val);
                    return root;
                }
                current = current.right;
            }
            else
            {
                if (current.left is null)
                {
                    current.left = new TreeNode(val);
                    return root;
                }
                current = current.left;
            }
        }
    }
}

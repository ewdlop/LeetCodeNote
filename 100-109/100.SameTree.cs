namespace LeetCodeNote;

public partial interface ISolution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p is not null && q is not null)
        {
            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }

        return p is null && q is null;
    }

    public bool IsSameTree(TreeNodeCustom? p, TreeNodeCustom? q)
    {
        if (p is not null && q is not null)
        {
            return p.Value == q.Value && IsSameTree(p.Left, q.Left) && IsSameTree(p.Right, q.Right);
        }

        return p is null && q is null;
    }
}

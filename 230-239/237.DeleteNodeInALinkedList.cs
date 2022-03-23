namespace LeetCodeNote;

public partial interface ISolution
{
    /// <summary>
    /// https://leetcode.com/problems/delete-node-in-a-linked-list/
    /// Notice this also updates value
    /// </summary>
    /// <param name="node"></param>
    public void DeleteNode(ListNode node)
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}

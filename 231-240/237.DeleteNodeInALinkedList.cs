namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// https://leetcode.com/problems/delete-node-in-a-linked-list/
    /// Notice this also updates value
    /// </summary>
    /// <param name="node"></param>
    public static void DeleteNode(ListNode node)
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}

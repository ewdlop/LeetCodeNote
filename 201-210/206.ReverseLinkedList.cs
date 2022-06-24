namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-linked-list/submissions/
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public static ListNode ReverseList(ListNode head)
    {
        ListNode previous = null;
        ListNode current = head;
        ListNode next;
        while (current is not null)
        {
            next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }
        return previous;
    }

    public static ListNodeCustom? ReverseLinkedList(ListNodeCustom? head)
    {
        ListNodeCustom? previous = null;
        ListNodeCustom? current = head;
        while (current is not null)
        {
            (previous, current, current.Next) = (current, current.Next, previous);
        }
        return previous;
    }
}

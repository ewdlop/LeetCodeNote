namespace LeetCodeNote;

public partial interface ISolution
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-linked-list/submissions/
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode ReverseList(ListNode head)
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

    public ListNodeCustom? ReverseLinkedList(ListNodeCustom? head)
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

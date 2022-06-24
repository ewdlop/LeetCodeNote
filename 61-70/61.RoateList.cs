namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// https://leetcode.com/problems/rotate-list/
    /// </summary>
    /// <param name="head"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public static ListNode RotateRight(ListNode head, int k)
    {
        if (head?.next is null) return head;
        ListNode oldTail = head;
        int n = 1;
        for (; oldTail.next is not null; n++)
        {
            oldTail = oldTail.next;
        }
        if (k % n == 0) return head;
        oldTail.next = head;
        ListNode newTail = head;
        for (int i = 0; i < n - k % n - 1; i++)
        {
            newTail = newTail.next;
        }
        ListNode newHead = newTail.next;
        newTail.next = null;
        return newHead;
    }

    public static ListNodeCustom? RotateRight(ListNodeCustom? head, int k)
    {
        if (head?.Next is null) return head;
        ListNodeCustom oldTail = head;
        int n = 1;
        for (; oldTail.Next is not null; n++)
        {
            oldTail = oldTail.Next;
        }
        if (k % n == 0) return head;
        oldTail.Next = head;
        ListNodeCustom newTail = head;
        for (int i = 0; i < n - k % n - 1 && newTail.Next is not null; i++)
        {
            newTail = newTail.Next;
        }
        ListNodeCustom? newHead = newTail.Next;
        newTail.Next = null;
        return newHead;
    }
}

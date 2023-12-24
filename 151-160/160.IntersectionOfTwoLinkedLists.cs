namespace LeetCodeNote;

public static partial class Solution
{
    public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        ListNode? pA = headA;
        ListNode? pB = headB;
        while (pA != pB)
        {
            pA = pA is null ? headB : pA.next;
            pB = pB is null ? headA : pB.next;
        }
        return pA;
    }
}
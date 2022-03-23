namespace LeetCodeNote;

public partial interface ISolution
{
    public bool HasCycle(ListNode head)
    {
        if (head is null) return false;
        ListNode slow = head;
        ListNode fast = head.next;
        while (slow != fast)
        {
            if (fast is null || fast.next is null)
            {
                return false;
            }
            slow = slow.next;
            fast = fast.next.next;
        }
        return true;
    }

    public bool HasCycle(ListNodeCustom? head)
    {
        if (head is null) return false;
        ListNodeCustom? slow = head;
        ListNodeCustom? fast = head.Next;
        while (slow != fast)
        {
            if (slow?.Next is null || fast?.Next is null)
            {
                return false;
            }
            slow = slow.Next;
            fast = fast.Next.Next;
        }
        return true;
    }
}

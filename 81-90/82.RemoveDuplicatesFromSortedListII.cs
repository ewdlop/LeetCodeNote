using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeNote;

public partial interface ISolution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head?.next is null) return head;
        ListNode current = head;
        ListNode previous = null;
        while (current?.next is not null)
        {
            if (current.val == current.next.val)
            {
                while (current.next is not null && current.val == current.next.val)
                {
                    current = current.next;
                }
                if (previous is not null)
                {
                    previous.next = current.next;
                }
                else
                {
                    head = current.next;
                }
            }
            else
            {
                previous = current;
            }
            current = current.next;
        }
        return head;
    }

    public ListNodeCustom? DeleteDuplicatesFromSortedLinkedList(ListNodeCustom? head)
    {
        if (head?.Next is null) return head;
        ListNodeCustom? current = head;
        ListNodeCustom? previous = null;
        while (current?.Next is not null)
        {
            if (current.Value == current.Next.Value)
            {
                while (current.Next is not null && current.Value == current.Next.Value)
                {
                    current = current.Next;
                }
                if (previous is not null)
                {
                    previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }
            }
            else
            {
                previous = current;
            }
            current = current.Next;
        }
        return head;
    }
}
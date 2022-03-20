using System;
using System.Collections.Generic;

namespace LeetCodeNote;

public partial interface ISolution
{
    public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode prehead = new();
        ListNode merged = prehead;
        while (l1 is not null && l2 is not null)
        {
            if (l1.val <= l2.val)
            {
                merged.next = l1;
                l1 = l1.next;
            }
            else
            {
                merged.next = l2;
                l2 = l2.next;
            }
            merged = merged.next;
        }
        merged.next = l1 ?? l2;
        return prehead.next;
    }

    public static ListNodeCustom? MergeTwoLists(ListNodeCustom? l1, ListNodeCustom? l2)
    {
        ListNodeCustom prehead = new();
        ListNodeCustom merged = prehead;
        while (l1 is not null && l2 is not null)
        {
            if (l1.Value <= l2.Value)
            {
                merged.Next = l1;
                l1 = l1.Next;
            }
            else
            {
                merged.Next = l2;
                l2 = l2.Next;
            }
            merged = merged.Next;
        }
        merged.Next = l1 ?? l2;
        return prehead.Next;
    }
}

public static partial class LinkedListNodeExtension
{
    public static LinkedListNode<int>? ToMergedLinkedListNode(this LinkedListNode<int>? l1, LinkedListNode<int>? l2)
    {
        LinkedList<int> preheadList = new();
        while (l1 is not null && l2 is not null)
        {
            if (l1.Value <= l2.Value)
            {
                preheadList.AddLast(l1);
                l1 = l1.Next;
            }
            else
            {
                preheadList.AddLast(l2);
                l2 = l2.Next;
            }
        }

        if (l2 is not null) preheadList.AddLast(l2);
        if (l1 is not null) preheadList.AddLast(l1);
        return preheadList.First;
    }

    public static LinkedListNode<T>? ToMergedLinkedListNode<T>(LinkedListNode<T>? l1, LinkedListNode<T>? l2)
        where T : IComparable<T>
    {
        LinkedList<T> preheadList = new();
        while (l1 is not null && l2 is not null)
        {
            if (l1.Value.CompareTo(l2.Value) <= 0 )
            {
                preheadList.AddLast(l1);
                l1 = l1.Next;
            }
            else
            {
                preheadList.AddLast(l2);
                l2 = l2.Next;
            }
        }

        if (l2 is not null) preheadList.AddLast(l2);
        if (l1 is not null) preheadList.AddLast(l1);
        return preheadList.First;
    }
}
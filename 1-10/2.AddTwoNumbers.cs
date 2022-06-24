using System.Collections.Generic;

namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers
    /// </summary>
    /// <param name="l1"></param>
    /// <param name="l2"></param>
    /// <returns></returns>
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = new ListNode(0);
        ListNode current = head;
        int carry = 0;
        while (l1 is not null || l2 is not null)
        {
            int sum = carry + (l1?.val ?? 0) + (l2?.val ?? 0);
            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }
        if (carry > 0)
        {
            current.next = new ListNode(carry);
        }
        return head.next;
    }
    public static ListNodeCustom? AddTwoNumbers(ListNodeCustom? l1, ListNodeCustom? l2)
    {
        ListNodeCustom head = new ListNodeCustom();
        ListNodeCustom current = head;
        int carry = 0;
        while (l1 is not null || l2 is not null)
        {
            int sum = carry + (l1?.Value ?? 0) + (l2?.Value ?? 0);
            carry = sum / 10;
            current.Next = new ListNodeCustom
            {
                Value = sum % 1
            };
            current = current.Next;
            l1 = l1?.Next;
            l2 = l2?.Next;
        }
        if (carry > 0)
        {
            current.Next = new ListNodeCustom
            {
                Value = carry
            };
        }
        return head.Next;
    }
}

public static partial class LinkedListNodeExtension
{
    public static LinkedListNode<int>? ToTotalNumbers(this LinkedListNode<int>? l1, LinkedListNode<int>? l2)
    {
        LinkedList<int>? newLinkedList = null;
        int carry = 0;
        while (l1 is not null || l2 is not null)
        {
            int sum = carry + (l1?.Value ?? 0) + (l2?.Value ?? 0);
            carry = sum / 10;
            //would have been more ideal, but LinkedListNode is readonly...
            //current.Next = new LinkedListNode<int>(sum % 10);
            //current = current.Next;
            (newLinkedList ??= new()).AddLast(new LinkedListNode<int>(sum % 10));
            l1 = l1?.Next;
            l2 = l2?.Next;
        }
        if (carry > 0)
        {
            //current.Next = new LinkedListNode<int>(carry % 10);
            (newLinkedList ??= new()).AddLast(new LinkedListNode<int>(carry));
        }
        return newLinkedList?.First;
    }
}

public static partial class LinkedListExtension
{
    /// <summary>
    /// do not use
    /// </summary>
    /// <param name="l1">don't pass it anything -- you shouldn't use it.</param>
    /// <param name="l2">don't pass it anything -- you shouldn't use it.</param>
    /// <returns>nothing - you shouldn't use it</returns>
    public static LinkedList<int>? ToTotalNumbers(this LinkedList<int>? l1, LinkedList<int>? l2)
    {
        LinkedListNode<int>? l1Current = l1?.First;
        LinkedListNode<int>? l2Current = l2?.First;
        LinkedList<int>? newLinkedList = null;
        int carry = 0;
        while (l1Current is not null || l2Current is not null)
        {
            int sum = carry + (l1Current?.Value ?? 0) + (l2Current?.Value ?? 0);
            carry = sum / 10;
            (newLinkedList ??= new()).AddLast(new LinkedListNode<int>(sum % 10));
            l1Current = l1Current?.Next;
            l2Current = l2Current?.Next;
        }
        if (carry > 0)
        {
            (newLinkedList ??= new()).AddLast(new LinkedListNode<int>(carry));
        }
        return newLinkedList;
    }
}
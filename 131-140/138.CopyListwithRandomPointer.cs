namespace LeetCodeNote;

public partial interface ISolution
{
    public Node CopyRandomList(Node head)
    {
        if (head is null) return head;
        Node current = head;
        while (current is not null)
        {
            Node newNode = new Node(current.val);
            newNode.next = current.next;
            current.next = newNode;
            current = newNode.next;
        }
        current = head;
        while (current?.next != null)
        {
            //Random is in the new list
            current.next.random = current.random?.next ?? null; ; //offset by one next, so  that it points to a clone one 
            current = current.next.next;
        }
        current = head;
        Node newCurrent = head.next;
        Node newHead = head.next;
        while (current is not null && newCurrent is not null)
        {
            current.next = current.next?.next;
            newCurrent.next = newCurrent.next?.next ?? null;
            current = current.next;
            newCurrent = newCurrent.next;
        }
        return newHead;
    }

    public NodeWithRandomNodePointer? CopyRandomList(NodeWithRandomNodePointer? head)
    {
        if (head is null) return head;
        NodeWithRandomNodePointer? current = head;
        while (current is not null)
        {
            NodeWithRandomNodePointer newNode = new()
            {
                Value = current.Value,
                Next = current.Next
            };
            current.Next = newNode;
            current = newNode.Next;
        }
        current = head;
        while (current?.Next != null)
        {
            //Random is in the new list
            current.Next.Random = current.Random?.Next ?? null; //offset by one next, so  that it points to a clone one 
            current = current.Next.Next;
        }
        current = head;
        NodeWithRandomNodePointer? newCurrent = head.Next;
        NodeWithRandomNodePointer? newHead = head.Next;
        while (current is not null && newCurrent is not null)
        {
            current.Next = current.Next?.Next;
            newCurrent.Next = newCurrent.Next?.Next ?? null;
            current = current.Next;
            newCurrent = newCurrent.Next;
        }
        return newHead;
    }
}



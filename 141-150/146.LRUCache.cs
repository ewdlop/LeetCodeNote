using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// https://leetcode.com/problems/lru-cache/
    /// Least Recently Used (LRU) cache.
    /// </summary>
    public class LRUCache
    {
        public int Capacity { get; }
        public int Size { get; private set; }
        private DoubleLinkedNode Head { get;} = new();
        private DoubleLinkedNode Tail { get;} = new();
        private Dictionary<int, DoubleLinkedNode> Cache { get;} = new();

        public class DoubleLinkedNode
        {
            public int Key { get; set; }
            public int Value { get; set; }
            public DoubleLinkedNode? Previous { get; set; }
            public DoubleLinkedNode? Next { get; set; }
        }

        private void AddNode(DoubleLinkedNode node)
        {
            node.Previous = Head;
            node.Next = Head.Next;
            if (Head.Next is not null)
            {
                Head.Next.Previous = node;
                Head.Next = node;
            }
        }

        private void RemoveNode(DoubleLinkedNode node)
        {
            DoubleLinkedNode? previous = node.Previous;
            DoubleLinkedNode? next = node.Next;
            if(previous is not null) previous.Next = next;
            if(next is not null)next.Previous = previous;
        }

        private void MoveToHead(DoubleLinkedNode node)
        {
            RemoveNode(node);
            AddNode(node);
        }

        private DoubleLinkedNode PopTail()
        {
            DoubleLinkedNode? res = Tail.Previous;
            RemoveNode(res);
            return res;
        }

        public LRUCache(int capacity)
        {
            Capacity = capacity;
            Head.Next = Tail;
            Tail.Previous = Head;
        }

        public int Get(int key)
        {
            if (!Cache.TryGetValue(key, out DoubleLinkedNode? node)) return -1;
            MoveToHead(node);
            return node.Value;
        }

        public void Put(int key, int val)
        {
            if (Cache.TryGetValue(key, out DoubleLinkedNode? node))
            {
                node.Value = val;
                MoveToHead(node);
            }
            else
            {
                if (++Size > Capacity)
                {
                    Cache.Remove(PopTail().Key);
                    Size--;
                }
                DoubleLinkedNode newNode = new()
                {
                    Key = key,
                    Value = val
                };
                Cache.Add(key, newNode);
                AddNode(newNode);

            }
        }
    }

    public class LRUCache2
    {
        public int Size { get; private set; }
        public int Capacity { get; }
        private LinkedList<LRUCacheNode> CircularLinkedList { get; } = new();
        private Dictionary<int, LRUCacheNode> Cache { get; } = new();

        private class LRUCacheNode
        {
            public int Key { get; set; }
            public int Value { get; set; }
        }

        public LRUCache2(int capacity)
        {
            Capacity = capacity;
        }

        public int Get(int key)
        {
            if (!Cache.TryGetValue(key, out LRUCacheNode? node)) return -1;
            CircularLinkedList.Remove(node);
            CircularLinkedList.AddFirst(node);
            return node.Value;
        }

        public void Put(int key, int val)
        {
            if (Cache.TryGetValue(key, out LRUCacheNode? node))
            {
                CircularLinkedList.Remove(node);
                CircularLinkedList.AddFirst(node);
                node.Value = val;
            }
            else
            {
                if (++Size > Capacity)
                {
                    if (CircularLinkedList.Last is not null)
                    {
                        Cache.Remove(CircularLinkedList.Last.Value.Key);
                        CircularLinkedList.RemoveLast();
                        Size--;
                    }
                }
                LRUCacheNode newNode = new()
                {
                    Key = key,
                    Value = val
                };
                CircularLinkedList.AddFirst(newNode);
                Cache.Add(key, newNode);
            }
        }
    }
}
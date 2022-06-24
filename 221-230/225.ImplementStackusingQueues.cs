using System.Collections.Generic;

namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// https://leetcode.com/problems/implement-stack-using-queues/
    /// </summary>
    public class MyStack
    {
        private readonly Queue<int> _queueStack;
        public MyStack()
        {
            _queueStack = new();
        }

        public void Push(int x)
        {
            _queueStack.Enqueue(x);
            for (int i = 0; i < _queueStack.Count - 1; i++)
            {
                _queueStack.Enqueue(_queueStack.Dequeue());
            }
        }

        public int Pop() => _queueStack.Dequeue();

        public int Top() => _queueStack.Peek();

        public bool Empty() => _queueStack.Count == 0;
    }
}

using System;
using System.Collections.Generic;

namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-frequency-stack/
    /// </summary>
    public class FreqStack
    {

        private readonly Dictionary<int, int> _frequency;
        private readonly Dictionary<int, Stack<int>> _frequencyGroup;
        private int _maxFrequency;

        public FreqStack()
        {
            _frequency = new();
            _frequencyGroup = new();
            _maxFrequency = 0;
        }

        public void Push(int val)
        {
            if (_frequency.TryGetValue(val, out var itemFrequency))
            {
                _frequency[val] = ++itemFrequency;
            }
            else
            {
                _frequency[val] = itemFrequency;
            }

            _maxFrequency = Math.Max(_maxFrequency, itemFrequency);

            if (!_frequencyGroup.TryGetValue(itemFrequency, out var stack))
            {
                stack = new();
                stack.Push(val);
                _frequencyGroup[itemFrequency] = stack;
            }
            else
            {
                stack.Push(val);
            }
        }

        public int Pop()
        {
            int x = _frequencyGroup[_maxFrequency].Pop();
            _frequency[x] -= 1;
            if (_frequencyGroup[_maxFrequency].Count == 0)
                _maxFrequency--;
            return x;
        }
    }
}
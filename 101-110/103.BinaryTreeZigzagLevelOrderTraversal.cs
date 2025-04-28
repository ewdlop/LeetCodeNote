using System.Collections.Generic;

namespace LeetCodeNote;

public static partial class Solution
{
    public static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        int level = 0;

        while (stack.Count > 0)
        {
            IList<int> currLevel = new List<int>();
            Queue<TreeNode> q = new Queue<TreeNode>();

            while (stack.Count > 0)
            {
                q.Enqueue(stack.Pop());
            }

            if (level % 2 == 0)
            {

                while (q.Count > 0)
                {
                    TreeNode temp = q.Dequeue();

                    if (temp.left != null)
                    {
                        stack.Push(temp.left);
                    }

                    if (temp.right != null)
                    {
                        stack.Push(temp.right);
                    }

                    currLevel.Add(temp.val);
                }
            }
            else
            {

                while (q.Count > 0)
                {
                    TreeNode temp = q.Dequeue();

                    if (temp.right != null)
                    {
                        stack.Push(temp.right);
                    }

                    if (temp.left != null)
                    {
                        stack.Push(temp.left);
                    }

                    currLevel.Add(temp.val);
                }
            }

            result.Add(currLevel);
            level++;
        }

        return result;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeNote;

public static partial class Solution
{
    /// <summary>
    /// The original implementation on LeetCode.
    /// </summary>
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class TreeNodeCustom
    {
        public int Value { get; set; }
        public TreeNodeCustom? Left { get; set; }
        public TreeNodeCustom? Right { get; set; }
    }
}
namespace LeetCodeNote;

public partial interface ISolution
{   
    /// <summary>
    /// The original implementation on LeetCode.
    /// </summary>
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }

    public class NodeWithRandomNodePointer
    {
        public int Value { get; set; }
        public NodeWithRandomNodePointer? Next { get; set; }
        public NodeWithRandomNodePointer? Random { get; set; }
    }
}
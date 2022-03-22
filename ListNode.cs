namespace LeetCodeNote;

public partial interface ISolution
{
    /// <summary>
    /// The original implementation on LeetCode.
    /// </summary>
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

    }
    /// <summary>
    /// Custom ListNode
    /// </summary>
    public class ListNodeCustom
    {
        public int Value { get; set; }
        public ListNodeCustom? Next { get; set; }
    }
}
using Xunit;
using static LeetCodeNote.Solution;

namespace LeetCodeNote.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Codec codec = new Codec();
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(5);
        string serialized = codec.Serialize(root);
        TreeNode? deserialized = codec.Deserialize(serialized);
    }
}
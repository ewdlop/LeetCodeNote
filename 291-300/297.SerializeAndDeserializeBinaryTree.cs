using System.Collections.Generic;
using System.Text;
using static LeetCodeNote.Solution;

namespace LeetCodeNote;

public class Codec
{
    private const string SPLITTER = ",";
    private const string NULL_NODE = "#";
    private const string NULL_NODE_WITH_SPLITTER = "#,";

    public string Serialize(TreeNode root)
    {
        StringBuilder stringBuilder = new StringBuilder();
        BuildString(root, stringBuilder);
        return stringBuilder.ToString();
    }

    private void BuildString(TreeNode node, StringBuilder stringBuilder)
    {
        if (node is null)
        {
            stringBuilder.Append(NULL_NODE_WITH_SPLITTER);
        }
        else
        {
            stringBuilder.Append(node.val).Append(SPLITTER);
            BuildString(node.left, stringBuilder);
            BuildString(node.right, stringBuilder);
        }
    }

    public TreeNode? Deserialize(string data)
    {
        LinkedList<string> serialized = new LinkedList<string>();
        string[] array = data.Split(SPLITTER);
        for (int i = 0; i < array.Length; i++)
        {
            string? node = array[i];
            serialized.AddLast(node);
        }
        return BuildTree(ref serialized);
    }

    private TreeNode? BuildTree(ref LinkedList<string> nodes)
    {
        string? headValue = nodes.First?.Value;
        nodes.RemoveFirst();
        if (string.IsNullOrEmpty(headValue) || headValue.Equals(NULL_NODE.ToString()))
        {
            return null;
        }
        else
        {
            TreeNode node = new TreeNode(int.Parse(headValue));
            node.left = BuildTree(ref nodes);
            node.right = BuildTree(ref nodes);
            return node;
        }
    }
}
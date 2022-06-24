namespace LeetCodeNote;

public static partial class Solution
{
    public class Trie
    {
        private TrieNode _root;
        public Trie()
        {
            _root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode ws = _root;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                switch (ws.children[c - 'a'])
                {
                    case not null:
                        break;
                    default:
                        ws.children[c - 'a'] = new TrieNode();
                        break;
                }
                ws = ws.children[c - 'a'];
            }
            ws.IsWord = true;
        }

        public bool Search(string word)
        {
            TrieNode ws = _root;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                switch (ws.children[c - 'a'])
                {
                    case not null:
                        ws = ws.children[c - 'a'];
                        break;
                    default:
                        return false;
                }
            }

            return ws.IsWord;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode ws = _root;
            for (int i = 0; i < prefix.Length; i++)
            {
                char c = prefix[i];
                switch (ws.children[c - 'a'])
                {
                    case not null:
                        ws = ws.children[c - 'a'];
                        break;
                    default:
                        return false;
                }
            }
            return true;
        }
    }

    public class TrieNode
    {
        public bool IsWord { get; set; }
        public TrieNode[] children = new TrieNode[26];
    }
}

using System;

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
                switch (ws.Children.Value[c - 'a'])
                {
                    case not null:
                        break;
                    default:
                        ws.Children.Value[c - 'a'] = new TrieNode();
                        break;
                }
                ws = ws.Children.Value[c - 'a'];
            }
            ws.IsWord = true;
        }

        public bool Search(string word)
        {
            TrieNode ws = _root;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                switch (ws.Children.Value[c - 'a'])
                {
                    case not null:
                        ws = ws.Children.Value[c - 'a'];
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
                switch (ws.Children.Value[c - 'a'])
                {
                    case not null:
                        ws = ws.Children.Value[c - 'a'];
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
        public Lazy<TrieNode[]> Children { get; } = new Lazy<TrieNode[]>(()=> new TrieNode[26]);
    }
}

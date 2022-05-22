using System.Collections.Generic;

namespace DataStructures
{
  public class Trie
  {
    private Dictionary<char, TrieNode> words = new Dictionary<char, TrieNode>();

    private class TrieNode
    {
      public char Value;

      public bool IsEndOfWord;

      public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();

      public TrieNode(char value, bool isEndOfWord = false) 
      {
        Value = value;
        IsEndOfWord = isEndOfWord;
      }
    }

    public void Insert(string word)
    {
      TrieNode root;
      if (words.ContainsKey(word[0]))
      {
        root = words[word[0]];
      }
      else
      {
        root = new TrieNode(word[0]);
        words[word[0]] = root;
      }

      TrieNode currentNode = root;
      for (int i = 1; i < word.Length; ++i) 
      {
        TrieNode nextNode;
        if (currentNode.Children.ContainsKey(word[i]))
        {
          nextNode = currentNode.Children[word[i]];
        }
        else
        {
          nextNode = new TrieNode(word[i]);
          currentNode.Children[word[i]] = nextNode; 
        }

        currentNode = nextNode;
      }

      currentNode.IsEndOfWord = true;
    }

    public bool Search(string word)
    {
      var children = words;
      bool isEndOfWord = false;
      foreach (char letter in word)
      {
        if (children.ContainsKey(letter))
        {
          TrieNode childNode = children[letter];
          children = childNode.Children;
          isEndOfWord = childNode.IsEndOfWord;
        }
        else
        {
          return false;
        }
      }

      return isEndOfWord;
    }

    public bool StartsWith(string prefix)
    {
      var children = words;
      foreach (char letter in prefix)
      {
        if (children.ContainsKey(letter))
        {
          TrieNode childNode = children[letter];
          children = childNode.Children;
        }
        else
        {
          return false;
        }
      }

      return true;
    }
  }
}

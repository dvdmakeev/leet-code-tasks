public class Solution 
{
    /*
        "hit" -> "cog"
        ["hot","dot","dog","lot","log","cog"]
    */
    
    private char[] GetAlphabet()
    {
        var alphabet = new char[26];
        for (int i = 0; i < 26; ++i)
        {
            alphabet[i] = (char)((int)'a' + i);
        }
        
        return alphabet;
    }
    
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) 
    {
        if (beginWord.Equals(endWord))
        {
            return 0;
        }
        
        var wordMap = new Dictionary<string, List<string>>();
        foreach (string word in wordList)
        {
            for (int i = 0; i < word.Length; ++i)
            {
                string regex = word.Remove(i, 1).Insert(i, "*");
                if (!wordMap.ContainsKey(regex))
                {
                    wordMap[regex] = new List<string>();
                }
                
                wordMap[regex].Add(word);
            }
        }
        
        var queue = new Queue<string>();
        queue.Enqueue(beginWord);
        
        var processed = new HashSet<string>();
        
        char[] alphabet = GetAlphabet();
        
        int distance = 0;
        while (queue.Count > 0)
        {
            ++distance;
            
            int queueSize = queue.Count;
            for (int i = 0; i < queueSize; ++i)
            {
                string current = queue.Dequeue();
                processed.Add(current);
                
                if (current.Equals(endWord))
                {
                    return distance;
                }
                
                for (int j = 0; j < current.Length; ++j)
                {
                    string regex = current.Remove(j, 1).Insert(j, "*");
                    if (!wordMap.ContainsKey(regex))
                    {
                        continue;
                    }
                    
                    foreach (string modified in wordMap[regex])
                    {
                        
                        if (!processed.Contains(modified))
                        {
                            queue.Enqueue(modified);
                        }
                    }
                }
            }
        }
        
        return 0;
    }
}

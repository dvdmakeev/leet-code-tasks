public class Solution 
{
    public IList<int> FindSubstring(string s, string[] words) 
    {
        var substrings = new List<int>();

        int wordLength = words[0].Length;
        int wordsCount = words.Length;

        var wordMap = new Dictionary<string, int>();

        int matchesToBe = 0;
        for (int i = 0; i < words.Length; ++i)
        {
            if (!wordMap.ContainsKey(words[i]))
            {
                wordMap[words[i]] = 0;
                matchesToBe++;
            }

            ++wordMap[words[i]];
        }

        for (int i = 0; i <= s.Length - wordsCount * wordLength; ++i)
        {
            var currentMatch = new Dictionary<string, int>();
            for (int j = 0; j < wordsCount; ++j)
            {
                var currentWord = s.Substring(i + j * wordLength, wordLength);
                if (!wordMap.ContainsKey(currentWord))
                {
                    break;
                }

                if (!currentMatch.ContainsKey(currentWord))
                {
                    currentMatch[currentWord] = 0;
                }
                ++currentMatch[currentWord];

                if (currentMatch[currentWord] > wordMap[currentWord])
                {
                    break;
                }

                if (j + 1 == wordsCount)
                {
                    substrings.Add(i);
                }
            }
        }

        return substrings;
    }
}

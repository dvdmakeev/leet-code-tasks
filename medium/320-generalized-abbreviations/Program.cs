public class Solution 
{
    private void GenerateAbbreviationsRec(string word, StringBuilder current, int start, int count, List<string> abbreviations)
    {
        if (start >= word.Length)
        {
            if (count > 0)
            {
                current.Append(count);
            }

            abbreviations.Add(current.ToString());
            return;
        }

        var newCurrent = new StringBuilder();
        newCurrent.Append(current);
        
        if (count > 0)
        {
            newCurrent.Append(count);
        }
        newCurrent.Append(word[start]);
        GenerateAbbreviationsRec(word, newCurrent, start + 1, 0, abbreviations);

        newCurrent = new StringBuilder();
        newCurrent.Append(current);

        GenerateAbbreviationsRec(word, newCurrent, start + 1, count + 1, abbreviations);
    }

    public IList<string> GenerateAbbreviations(string word) 
    {
        var abbreviations = new List<string>();
        var current = new StringBuilder();

        GenerateAbbreviationsRec(word, current, 0, 0, abbreviations);

        return abbreviations;
    }
}

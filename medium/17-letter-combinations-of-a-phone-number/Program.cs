public class Solution 
{
    private Dictionary<char, char[]> GetDigitLetters()
    {
        return new Dictionary<char, char[]> 
        {
            { '2', new char[] { 'a', 'b', 'c' } },
            { '3', new char[] { 'd', 'e', 'f' } },
            { '4', new char[] { 'g', 'h', 'i' } },
            { '5', new char[] { 'j', 'k', 'l' } },
            { '6', new char[] { 'm', 'n', 'o' } },
            { '7', new char[] { 'p', 'q', 'r', 's' } },
            { '8', new char[] { 't', 'u', 'v' } },
            { '9', new char[] { 'w', 'x', 'y', 'z' } },
        };
    }
    
    public IList<string> LetterCombinations(string digits) 
    {
        var digitLetters = GetDigitLetters();
        var allCombinations = new List<string>();
        
        if (string.IsNullOrEmpty(digits))
        {
            return allCombinations;
        }
        
        allCombinations.Add("");
        foreach (char digit in digits)
        {
            var newCombinations = new List<string>();
            for (int i = 0; i < allCombinations.Count; ++i)
            {
                var currentCombination = new string(allCombinations[i]);
                
                foreach (char letter in digitLetters[digit])
                {
                    newCombinations.Add(currentCombination + letter);
                }
            }
            allCombinations = newCombinations;
        }
        
        return allCombinations;
    }
}

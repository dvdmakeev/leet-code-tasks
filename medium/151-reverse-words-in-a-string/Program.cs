public class Solution 
{
    /*
        "  hello world  "
        
    */
    public string ReverseWords(string s) 
    {
        var words = s.Split(' ').Select(word => word.Trim()).Where(word => word != string.Empty).ToArray();

        Array.Reverse(words);
        
        return string.Join(" ", words);
    }
}

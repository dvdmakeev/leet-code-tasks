public class Solution 
{
    public bool UniqueOccurrences(int[] arr) 
    {
        var occurrences = new Dictionary<int, int>();
        
        for (int i = 0; i < arr.Length; ++i)
        {
            if (!occurrences.ContainsKey(arr[i]))
            {
              occurrences[arr[i]] = 0;  
            }
            ++occurrences[arr[i]];
        }
        
        return occurrences.Count() == occurrences.Values.Distinct().Count();
    }
}


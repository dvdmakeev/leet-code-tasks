public class Solution {
    public int PartitionString(string s) 
    {
        int partitionCount = 0;
        var partitionMap = new HashSet<char>();

        for (int i = 0; i < s.Length; ++i)
        {
            if (partitionMap.Contains(s[i]))
            {
                ++partitionCount;
                partitionMap = new HashSet<char>();
            }

            partitionMap.Add(s[i]);
        }

        if (partitionMap.Any())
        {
            ++partitionCount;
        }

        return partitionCount;
    }
}

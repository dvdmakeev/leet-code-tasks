public class Solution 
{
    public string RestoreString(string s, int[] indices) 
    {
        char[] restored = new char[s.Length];
        
        for (int i = 0; i < indices.Length; ++i)
        {
            restored[indices[i]] = s[i];
        }
        
        return new string(restored);
    }
}

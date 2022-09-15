public class Solution 
{
    public string SimplifyPath(string path) 
    {
        var canonicalPath = new StringBuilder();
        string[] components = path.Split('/');
        
        int toSkip = 0;
        for (int i = components.Length - 1; i >= 0; --i)
        {
            if (components[i] == "")
            {
                continue;
            }
            
            if (components[i] == ".")
            {
                continue;
            }
            
            if (components[i] == "..")
            {
                toSkip++;
                continue;
            }
            
            if (toSkip > 0)
            {
                --toSkip;
                continue;
            }
            
            canonicalPath.Insert(0, $"/{components[i]}");
        }
        
        if (canonicalPath.Length == 0)
        {
            canonicalPath.Append("/");
        }
        
        return canonicalPath.ToString();
    }
}

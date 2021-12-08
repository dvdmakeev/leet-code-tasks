public class Solution 
{
    public IList<IList<int>> Generate(int numRows) 
    {
        var list = new List<IList<int>>();
        var row = new List<int>();
        
        row.Add(1);
        list.Add(row);
        if (numRows == 1)
        {
            return list;
        }

        row = new List<int>();
        row.Add(1);
        row.Add(1);
        list.Add(row);
        if (numRows == 2)
        {   
            return list;
        }
        
        for (int n = 3; n <= numRows; ++n)
        {
            row = new List<int>();
            row.Add(1);
            var prev = list.Last();
            for (int i = 0; i < prev.Count - 1; ++i)
            {
                row.Add(prev[i] + prev[i + 1]);
            }
            row.Add(1);
            list.Add(row);
        }
        
        return list;
    }
}
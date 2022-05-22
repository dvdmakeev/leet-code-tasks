public class Solution 
{
    public IList<int> GetRow(int rowIndex) 
    {
        var row = new List<int>();
        
        if (rowIndex == 0)
        {
            row.Add(1);
            return row;
        }
        
        row.Add(1);
        row.Add(1);
        if (rowIndex == 1)
        {
            return row;
        }
        
        List<int> prevRow;
        for (int i = 2; i <= rowIndex; ++i)
        {
            prevRow = row;
            row = new List<int>();
            row.Add(1);
            for (int j = 0; j < prevRow.Count - 1; ++j)
            {
                row.Add(prevRow[j] + prevRow[j + 1]);
            }
            row.Add(1);
        }
        
        return row;
    }
}
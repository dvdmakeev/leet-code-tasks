public class Solution 
{
    /*
        1 2 3 4 5
        2 4 5 8 10
        3 5 7 9 11
        1 3 5 7 9
        
        1 2
        3
    */
    private class RowProcessingState
    {
        public int[] row;
        
        public RowProcessingState(int[] row)
        {
            this.row = row;
        }
        
        public int commonSmallest = 0;
    }
    
    public int SmallestCommonElement(int[][] mat) 
    {
        if (mat.Length == 1)
        {
            return mat[0][0];
        }
            
        var processedRows = new Queue<RowProcessingState>();
        processedRows.Enqueue(new RowProcessingState(mat[0]));
        
        var unprocessedRows = new Queue<RowProcessingState>();
        for (int i = 1; i < mat.Length; ++i)
        {
            unprocessedRows.Enqueue(new RowProcessingState(mat[i]));
        }
        
        
        while (unprocessedRows.Count > 0)
        {
            var processed = processedRows.Dequeue();
            var unprocessed = unprocessedRows.Dequeue();
            
            while (
                unprocessed.commonSmallest < unprocessed.row.Length &&
                unprocessed.row[unprocessed.commonSmallest] < processed.row[processed.commonSmallest])
            {
                unprocessed.commonSmallest++;
            }
            
            if (unprocessed.commonSmallest >= unprocessed.row.Length)
            {
                return -1;
            }
            
            if (processed.row[processed.commonSmallest] == unprocessed.row[unprocessed.commonSmallest])
            {
                processedRows.Enqueue(processed);
                processedRows.Enqueue(unprocessed);
            }
            else
            {
                unprocessedRows.Enqueue(processed);
                
                while (processedRows.Count > 0)
                {
                    unprocessedRows.Enqueue(processedRows.Dequeue());
                }
                
                processedRows.Enqueue(unprocessed);
            }
        }
        
        return processedRows.First().row[processedRows.First().commonSmallest];
    }
}

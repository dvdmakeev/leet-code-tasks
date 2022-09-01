public class Solution 
{
    // [1 3] [5 9] [11 13]
    // [2 7]
    // 
    // 1 7
    //
    //
    // [3 5] [6 7]
    // [1 2]
    //
    // [3 4] [5 9] [11 13]
    // [2 10]
    //
    public int[][] Insert(int[][] intervals, int[] newInterval) 
    {
        var newIntervals = new List<int[]>();
        
        int i = 0;
        while (i < intervals.Length && intervals[i][1] < newInterval[0])
        {
            newIntervals.Add(intervals[i]);
            ++i;
        }
        
        int start = newInterval[0];
        int end = newInterval[1];
        
        while (i < intervals.Length && end >= intervals[i][0])
        {
            start = Math.Min(intervals[i][0], start);
            end = Math.Max(intervals[i][1], end);
            
            ++i;
        }
        newIntervals.Add(new int[] { start, end });
        
        while (i < intervals.Length)
        {
            newIntervals.Add(intervals[i]);
            ++i;
        }
        
        return newIntervals.ToArray();
    }
}

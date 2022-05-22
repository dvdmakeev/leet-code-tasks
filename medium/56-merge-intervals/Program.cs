public class Solution 
{
    public int[][] Merge(int[][] intervals) 
    {
        Comparer<int> comparer = Comparer<int>.Default;
        Array.Sort<int[]>(intervals, (x, y) => comparer.Compare(x[0], y[0]));
        
        var mergedIntervals = new List<int[]>();
        foreach (int[] interval in intervals)
        {
            if (mergedIntervals.Count == 0 || mergedIntervals.Last()[1] < interval[0])
            {
                mergedIntervals.Add(interval);
            }
            else
            {
                mergedIntervals.Last()[1] = Math.Max(mergedIntervals.Last()[1], interval[1]);
            }
        }
        
        return mergedIntervals.ToArray();
    }
}
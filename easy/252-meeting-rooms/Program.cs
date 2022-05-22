public class Solution 
{
    public bool CanAttendMeetings(int[][] intervals) 
    {
        Array.Sort<int[]>(intervals, new Comparison<int[]>((i1, i2) => i1[0].CompareTo(i2[0])));
        
        for (int i = 0; i < intervals.Length - 1; ++i)
        {
            if (intervals[i][1] > intervals[i + 1][0])
            {
                return false;
            }
        }
        
        return true;
    }
}
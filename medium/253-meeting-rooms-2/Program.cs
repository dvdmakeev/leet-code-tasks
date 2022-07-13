public class Solution 
{
    // 0                           30
    //    3    7
    //      5     10
    //            10          20
    //
    // 1  2 3  2   2          1    0
    public int MinMeetingRooms(int[][] intervals) 
    {
        var starts = intervals.Select(interval => interval[0]).ToList();
        var ends = intervals.Select(interval => interval[1]).ToList();
        
        starts.Sort();
        ends.Sort();
        
        int i = 0;
        int j = 0;
        int maxOverlap = 0;
        int currentOverlap = 0;
        while (i < starts.Count && j < ends.Count)
        {
            bool incrementI = false;
            if (starts[i] <= ends[j])
            {
                ++currentOverlap;
                incrementI = true;
            }
            
            bool incrementJ = false;
            if (starts[i] >= ends[j])
            {
                --currentOverlap;
                incrementJ = true;
            }
            
            if (incrementI)
            {
                ++i;
            }
            if (incrementJ)
            {
                ++j;
            }
            
            maxOverlap = Math.Max(maxOverlap, currentOverlap);
        }
        
        return maxOverlap;
    }
}

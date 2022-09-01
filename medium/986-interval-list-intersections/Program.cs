public class Solution 
{
    private int[][] GetIntervalsSorted(int[][] firstList, int[][] secondList)
    {
        if (firstList == null || firstList.Length == 0)
        {
            return secondList;
        }
        if (secondList == null || secondList.Length == 0)
        {
            return firstList;
        }
        
        int i = 0;
        int j = 0;
        
        List<int[]> sorted = new List<int[]>();
        while (i < firstList.Length || j < secondList.Length)
        {
            if (i >= firstList.Length)
            {
                sorted.Add(secondList[j++]);
                continue;
            }
            if (j >= secondList.Length)
            {
                sorted.Add(firstList[i++]);
                continue;
            }
            
            if (firstList[i][0] < secondList[j][0])
            {
                sorted.Add(firstList[i++]);
                continue;
            }
            else if (firstList[i][0] > secondList[j][0])
            {
                sorted.Add(secondList[j++]);
                continue;
            }
            else
            {
                if (firstList[i][1] <= secondList[j][1])
                {
                    sorted.Add(firstList[i++]);
                    continue;
                }
                else
                {
                    sorted.Add(secondList[j++]);
                    continue;
                }
            }
        }
        
        return sorted.ToArray();
    }
    
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList) 
    {
        var intersections = new List<int[]>();
        if (firstList == null || firstList.Length == 0)
        {
            return intersections.ToArray();
        }
        if (secondList == null || secondList.Length == 0)
        {
            return intersections.ToArray();
        }
        int[][] sorted = GetIntervalsSorted(firstList, secondList);
        if (sorted.Length < 2)
        {
            return intersections.ToArray();
        }

        int[] prevInterval = null;
        for (int i = 1; i < sorted.Length; ++i)
        {
            if (prevInterval == null || prevInterval[1] < sorted[i - 1][1])
            {
                prevInterval = sorted[i - 1];
            }
            int[] currentInterval = sorted[i];
            
            if (prevInterval[1] >= currentInterval[0])
            {
                int[] newInterval = new int[] 
                { 
                    Math.Max(prevInterval[0], currentInterval[0]), 
                    Math.Min(prevInterval[1], currentInterval[1]) 
                };
                
                intersections.Add(newInterval);
            }
        }
        
        return intersections.ToArray();
    }
}

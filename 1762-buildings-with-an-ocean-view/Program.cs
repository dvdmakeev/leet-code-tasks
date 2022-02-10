public class Solution 
{
    public int[] FindBuildings(int[] heights) 
    {
        int heighestObstacle = 0;
        var oceanViewBuildings = new List<int>();
        for (int i = heights.Length - 1; i >= 0; --i)
        {
            if (heights[i] > heighestObstacle)
            {
                oceanViewBuildings.Add(i);
                heighestObstacle = heights[i];
            }
        }
        
        oceanViewBuildings.Reverse();
        return oceanViewBuildings.ToArray();
    }
}
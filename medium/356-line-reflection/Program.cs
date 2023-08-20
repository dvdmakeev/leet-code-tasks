public class Solution 
{
    private string ConstructKey(int x, int y)
    {
        return $"{x};{y}";
    }

    public bool IsReflected(int[][] points) 
    {
        var pointKeys = new HashSet<string>();
        int minX = int.MaxValue;
        int maxX = int.MinValue;
        foreach (int[] point in points)
        {
            string key = ConstructKey(point[0], point[1]);
            pointKeys.Add(key);

            minX = Math.Min(point[0], minX);
            maxX = Math.Max(point[0], maxX);
        }

        int shift = minX + maxX;
        foreach (int[] point in points)
        {
            int reflectedX = shift - point[0];

            if (!pointKeys.Contains(ConstructKey(reflectedX, point[1])))
            {
                return false;
            }
        }

        return true;
    }
}

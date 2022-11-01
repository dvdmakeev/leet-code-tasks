public class Solution 
{
    /*
        1  1  1 -1 -1
        1  1  1 -1 -1
    */
    public int[] FindBall(int[][] grid) 
    {
        int[] result = new int[grid[0].Length];
        
        for (int i = 0; i < grid[0].Length; ++i)
        {
            int k = i;
            bool isStuck = false;
            for (int j = 0; j < grid.Length; ++j)
            {
                if (grid[j][k] == 1 && k >= grid[0].Length - 1)
                {
                    isStuck = true;
                    break;
                }
                if (grid[j][k] == -1 && k <= 0)
                {
                    isStuck = true;
                    break;
                }
                
                if (grid[j][k] == 1)
                {
                    if (grid[j][k + 1] == -1)
                    {
                        isStuck = true;
                        break;
                    }
                    
                    ++k;
                }
                else
                {
                    if (grid[j][k - 1] == 1)
                    {
                        isStuck = true;
                        break;
                    }
                    
                    --k;
                }
            }
            
            if (!isStuck)
            {
                result[i] = k;
            }
            else
            {
                result[i] = -1;
            }
        }
        
        return result;
    }
}

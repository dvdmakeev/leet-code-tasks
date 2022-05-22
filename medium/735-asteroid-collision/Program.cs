public class Solution 
{
    public int[] AsteroidCollision(int[] asteroids) 
    {
        var remainAsteroids = new Stack<int>();
        for (int i = 0; i < asteroids.Length; ++i)
        {
            int asteroid = asteroids[i];
            remainAsteroids.Push(asteroid);
            
            while (remainAsteroids.Count > 0)
            {
                asteroid = remainAsteroids.Pop();
                if (remainAsteroids.Count == 0)
                {
                    remainAsteroids.Push(asteroid);
                    break;
                }
                
                int neighbour = remainAsteroids.Pop();
                if (WillAsteroidsCollapse(neighbour, asteroid))
                {
                    int resultedAsteroid = Collapse(neighbour, asteroid);
                    if (resultedAsteroid != 0)
                    {
                        remainAsteroids.Push(resultedAsteroid);
                    }
                }
                else
                {
                    remainAsteroids.Push(neighbour);
                    remainAsteroids.Push(asteroid);
                    
                    break;
                }
            }
        }
        
        var result = new int[remainAsteroids.Count];
        for (int i = result.Length - 1; i >= 0; --i)
        {
            result[i] = remainAsteroids.Pop();
        }
            
        return result;
    }
    
    private bool WillAsteroidsCollapse(int left, int right)
    {
        if (left * right < 0)
        {
            if (left < 0 && right > 0)
            {
                return false;
            }
            
            return true;
        }
        else
        {
            return false;
        }
    }
    
    private int Collapse(int left, int right)
    {
        if (!WillAsteroidsCollapse(left, right))
        {
            return -1;
        }
        
        if (Math.Abs(left) == Math.Abs(right))
        {
            return 0;
        }
        else if (Math.Abs(left) > Math.Abs(right))
        {
            return left;
        }
        else
        {
            return right;
        }
    }
}
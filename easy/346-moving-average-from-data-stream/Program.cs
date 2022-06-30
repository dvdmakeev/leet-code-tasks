public class MovingAverage 
{
    private int size;
    private Queue<int> queue = new Queue<int>();
    
    private int sum;
    
    public MovingAverage(int size) 
    {
        this.size = size;
        sum = 0;
    }
    
    public double Next(int val) 
    {
        if (queue.Count < size)
        {
            queue.Enqueue(val);
            
            sum += val;
        }
        else if (queue.Count == size)
        {
            sum -= queue.Dequeue();
            sum += val;
            queue.Enqueue(val);
        }
        
        return (double)sum / queue.Count;
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */

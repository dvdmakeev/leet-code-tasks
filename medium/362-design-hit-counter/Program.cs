public class HitCounter 
{
    private class HitAtTime
    {
        public int Time { get;set; }
        public int Count { get; set; }

        public HitAtTime(int time, int count)
        {
            Time = time;
            Count = count;
        }
    }

    private Queue<HitAtTime> hits;
    private int totalHits;

    private const int WindowSize = 300;

    public HitCounter() 
    {
        hits = new Queue<HitAtTime>();
        totalHits = 0;
    }
    
    public void Hit(int timestamp) 
    {
        if (hits.Count > 0 && hits.Peek().Time == timestamp)
        {
            hits.Peek().Count++;
        }
        else
        {
            hits.Enqueue(new HitAtTime(timestamp, 1));
        }

        totalHits++;
    }
    
    public int GetHits(int timestamp) 
    {
        while (hits.Count > 0 && hits.Peek().Time <= timestamp - WindowSize)
        {
            totalHits -= hits.Dequeue().Count;
        }

        return totalHits;
    }
}

/**
 * Your HitCounter object will be instantiated and called as such:
 * HitCounter obj = new HitCounter();
 * obj.Hit(timestamp);
 * int param_2 = obj.GetHits(timestamp);
 */

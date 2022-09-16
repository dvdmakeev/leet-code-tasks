public class StockSpanner 
{
    private Stack<int[]> stack;
    private int day;

    public StockSpanner() 
    {
        stack = new Stack<int[]>();
        day = 1;
    }
    
    /*
       100 80 60 70 60 75 85
       1   1  1  2  1  4  6
       100
       100 80
       100 80 60
       100 80 70
       100 80 70 60
       100 80 75
       100 85
    */
    public int Next(int price) 
    {
        while (stack.Count > 0 && stack.Peek()[1] <= price)
        {
            stack.Pop();
        }
        
        int lastPriceDay = 0;
        if (stack.Count > 0)
        {
            lastPriceDay = stack.Peek()[0];
        }
        else
        {
            lastPriceDay = 0;
        }
        
        stack.Push(new int[] { day, price });
        
        return day++ - lastPriceDay;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */
 

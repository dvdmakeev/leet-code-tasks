public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int maxProfit = 0;
        int minPrice = prices[0];
        for (int i = 1; i < prices.Length; ++i)
        {
            maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            minPrice = Math.Min(minPrice, prices[i]);
        }
        return maxProfit;
    }
}
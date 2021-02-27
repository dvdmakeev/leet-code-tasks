public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minPrice = int.MaxValue;
        
        for (int i = 0; i < prices.Length; ++i)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else if (maxProfit < prices[i] - minPrice)
            {
                maxProfit = prices[i] - minPrice;
            }
        }
        
        return maxProfit;
    }
}
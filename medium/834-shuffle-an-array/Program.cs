public class Solution 
{
    private int[] nums;
    private int[] newArray;

    private Random random = new Random();
    
    public Solution(int[] nums) 
    {
        this.nums = nums;
        this.newArray = new int[nums.Length];
        nums.CopyTo(this.newArray, 0);
    }
    
    public int[] Reset() 
    {
        newArray = new int[nums.Length];
        nums.CopyTo(newArray, 0);

        return newArray;
    }
    
    public int[] Shuffle() 
    {
        for (int i = 0; i < newArray.Length; ++i)
        {
            int indexToExchange = random.Next(i, newArray.Length);

            int tmp = newArray[i];
            newArray[i] = newArray[indexToExchange];
            newArray[indexToExchange] = tmp;
        }

        return newArray;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */
 

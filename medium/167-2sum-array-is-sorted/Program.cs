public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        int i = 0;
        int j = numbers.Length - 1;
        
        int[] ans = new int[2];
        while (i < j)
        {
            if (numbers[i] + numbers[j] < target)
            {
                ++i;
            }
            else if (numbers[i] + numbers[j] > target)
            {
                --j;
            }
            else
            {
                ans[0] = i + 1;
                ans[1] = j + 1;
                break;
            }
        }
        
        return ans;
    }
}

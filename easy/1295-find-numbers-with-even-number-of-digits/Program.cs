public class Solution 
{
    private bool IsEvenNumberOfDigits(int num)
    {
        int digitCount = 0;
        while (num != 0)
        {
            num /= 10;
            ++digitCount;
        }
        
        return digitCount % 2 == 0;
    }
    
    public int FindNumbers(int[] nums) 
    {
        int evenDigitsCount = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (IsEvenNumberOfDigits(nums[i]))
            {
                ++evenDigitsCount;
            }
        }
        
        return evenDigitsCount;
    }
}

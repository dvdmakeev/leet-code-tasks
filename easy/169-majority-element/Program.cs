public class Solution 
{
    public int MajorityElement(int[] nums) 
    {
        var elementCount = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            int curNum = nums[i];
            if (!elementCount.ContainsKey(curNum))
            {
                elementCount[curNum] = 0;
            }
            ++elementCount[curNum];
            
            if (elementCount[curNum] > nums.Length / 2)
            {
                
                return curNum;
            }
        }
        
        throw new Exception();
    }
}
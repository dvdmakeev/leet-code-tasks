public class Solution 
{
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        Array.Sort(nums);
        
        var triplets = new List<IList<int>>();
        for (int i = 0; i < nums.Length; ++i)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            
            int target = -nums[i];
            
            int start = i + 1;
            int end = nums.Length - 1;
            
            while (start < end)
            {
                if (nums[start] + nums[end] < target || start == i)
                {
                    ++start;
                }
                else if (nums[start] + nums[end] > target || end == i)
                {
                    --end;
                }
                else
                {
                    triplets.Add(new int[] { nums[i], nums[start], nums[end] }.ToList());
                    ++start;
                    --end;
                    
                    while (start < end && nums[start] == nums[start - 1])
                    {
                        ++start;
                    }
                }
            }
        }
        
        return triplets;
    }
}

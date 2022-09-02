public class Solution 
{
    public IList<IList<int>> FourSum(int[] nums, int target) 
    {
        Array.Sort(nums);
        
        var result = new List<IList<int>>();
        for (int i = 0; i < nums.Length; ++i)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            
            for (int j = i + 1; j < nums.Length; ++j)
            {
                if (j > i + 1 && nums[j] == nums[j - 1])
                {
                    continue;
                }
                
                int start = j + 1;
                int end = nums.Length - 1;
                
                while (start < end)
                {
                    long currentSum = (long)nums[i] + (long)nums[j] + (long)nums[start] + (long)nums[end];
                    if (currentSum < target)
                    {
                        ++start;
                    }
                    else if (currentSum > target)
                    {
                        --end;
                    }
                    else
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[start], nums[end] });
                        ++start;
                        --end;
                        
                        while (start < end)
                        {
                            if (nums[start] == nums[start - 1])
                            {
                                ++start;
                                continue;
                            }
                            if (nums[end] == nums[end + 1])
                            {
                                --end;
                                continue;
                            }
                            
                            break;
                        }
                    }
                }
            }
        }
        
        return result;
    }
}

public class Solution 
{
    private bool FindCircle(int[] nums, int i, bool isForward)
    {
        int slow = i;
        int fast = i;
        while (true)
        {
            slow = GetNextIndex(nums, slow, isForward);

            fast = GetNextIndex(nums, fast, isForward);
            if (fast != -1)
            {
                fast = GetNextIndex(nums, fast, isForward);
            }

            if (slow == -1 || fast == -1 || fast == slow)
            {
                break;
            }
        }

        return slow != -1 && fast != -1;
    }

    private int Mod(int i, int j)
    {
        int mod = i % j;
        if (mod < 0)
        {
            return mod + j;
        }

        return mod;
    }

    private int GetNextIndex(int[] nums, int i, bool isForward)
    {
        if ((nums[i] >= 0) ^ isForward)
        {
            return -1;
        }

        int newIndex = Mod(nums[i] + i, nums.Length);
        if (newIndex == i)
        {
            return -1;
        }

        return newIndex;
    }

    public bool CircularArrayLoop(int[] nums) 
    {
        for (int i = 0; i < nums.Length; ++i)
        {
            bool isForward = nums[i] >= 0;
            if (FindCircle(nums, i, isForward))
            {
                return true;
            }
        }

        return false;
    }
}

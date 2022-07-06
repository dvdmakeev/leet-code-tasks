public class Solution 
{
    // Given an array
    // Find all subarray
    // Sum of subarray mins
    //
    // 3, 1, 2, 4, 0
    // [3]                                     | 3         | 3
    // [3,1]       [1]                         | 1 1       | 2
    // [3,1,2]     [1,2]     [2]               | 1 1 2     | 4
    // [3,1,2,4]   [1,2,4]   [2,4]   [4]       | 1 1 2 4   | 8
    // [3,1,2,4,3] [1,2,4,3] [2,4,3] [4,3] [3] | 1 1 2 3 3 | 0
    // SubarraysCount([n]) = 1 + 2 + .. + (n - 1) + n = (n + 1) * n / 2

    public int SumSubarrayMins(int[] arr) 
    {
        var stack = new Stack<int>();
        int[] results = new int[arr.Length];
        for (int i = 0; i < arr.Length; ++i)
        {
            if (stack.Count == 0)
            {
                results[i] = arr[i];
                stack.Push(arr[i]);
            }
            else if (stack.Peek() <= arr[i])
            {
                results[i] = results[i - 1] + arr[i];
                stack.Push(arr[i]);
            }
            else
            {
                int removedCount = 0;
                while (stack.Count > 0 && stack.Peek() > arr[i])
                {
                    ++removedCount;
                    stack.Pop();
                }
                int res = i - removedCount - 1  >= 0 ? results[i - removedCount - 1] : 0;
                while (removedCount >= 0)
                {
                    stack.Push(arr[i]);
                    --removedCount;
                    res += arr[i];
                }
                
                results[i] = res;
            }
        }
        
        int module = (int)Math.Pow(10, 9) + 7;
        int result = 0;
        for (int i = 0; i < results.Length; ++i)
        {
            result += results[i];
            result %= module;
        }
        
        return result;
    }
}

public class Solution 
{
    public bool IsHappy(int n) 
    {
        int slow = n;
        int fast = GetNext(n);

        while (slow != fast)
        {
            slow = GetNext(slow);
            fast = GetNext(GetNext(fast));
        }

        return slow == 1;
    }

    private int GetNext(int n)
    {
        int next = 0;
        while(n > 0)
        {
            int digit = n % 10;
            next += digit * digit;

            n /= 10;
        }

        return next;
    }
}

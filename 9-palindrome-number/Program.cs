using System;

class Program
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        int cur = x;
        int res = 0;
        while (cur != 0)
        {
            int remainder = cur % 10;
            cur = cur / 10;

            res = res * 10 + remainder;
        }

        return x == res;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome(
            121));

        Console.ReadKey();
    }
}

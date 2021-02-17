using System;

class Program
{
    private static int Reverse(int x)
    {
        int result = 0;
        int sign = x >= 0 ? 1 : -1;
        x *= sign;
        while (x != 0)
        {
            int remainder = x % 10;
            x = x / 10;

            if ((int.MaxValue - remainder) / 10 < result)
            {
                return 0;
            }
            int temp = result * 10 + remainder;

            result = temp;
        }

        return result * sign;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Reverse(
            1463847412));

        Console.ReadKey();
    }
}

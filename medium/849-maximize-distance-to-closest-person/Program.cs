public class Solution 
{
    /*
        1 0 0 0 1 0 1 -> 2
        1 0 0 0       -> 3

        (j - i) / 2          : k <- [i, j] : a[k] == 0 && a[i - 1] == 1 && a[j + 1] == 1
        seat                 : i <- [0, seat - 1] a[i] = 0 
        len(seats)-1 - seat  : i <- [seat + 1, len(seats)] a[i] == 0
    */
    public int MaxDistToClosest(int[] seats) 
    {
        int seat = -1;
        int maxDist = 0;

        for (int i = 0; i < seats.Length; ++i)
        {
            if (seats[i] == 0)
            {
                continue;
            }

            if (seats[0] == 0)
            {
                if (seat == -1)
                {
                    maxDist = Math.Max(i, maxDist);
                    seat = i;
                }
            }

            maxDist = Math.Max((i - seat) / 2, maxDist);
            seat = i;
        }

        if (seats[seats.Length - 1] == 0)
        {
            maxDist = Math.Max(seats.Length - 1 - seat, maxDist);
        }

        return maxDist;
    }
}

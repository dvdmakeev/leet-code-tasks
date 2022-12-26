/**
 * // This is ArrayReader's API interface.
 * // You should not implement it, or speculate about its implementation
 * class ArrayReader {
 *     public int Get(int index) {}
 * }
 */

class Solution 
{
    private int GetUpperBound(ArrayReader reader, int target)
    {
        int current = 2;
        while (reader.Get(current) < target)
        {
            current *= 2;
        }

        return current;
    }

    public int Search(ArrayReader reader, int target) 
    {
        int upperBound = GetUpperBound(reader, target);

        int left = 0;
        int right = upperBound;

        while (left <= right)
        {
            int middle = (left + right) / 2;
            if (reader.Get(middle) == 2147483647 || reader.Get(middle) > target)
            {
                right = middle - 1;
            }
            else if (reader.Get(middle) < target)
            {
                left = middle + 1;
            }
            else
            {
                return middle;
            }
        }

        return -1;
    }
}

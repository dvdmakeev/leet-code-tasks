public class Solution 
{
    /*
       1 3 4 4 7 9
       5


    */
    private int FindClosestElement(int[] arr, int x)
    {
        int left = 0;
        int right = arr.Length - 1;
        
        while (left <= right)
        {
            int middle = (left + right) / 2;

            if (arr[middle] == x)
            {
                return middle;
            }

            if (arr[middle] > x)
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        if (left == 0)
        {
            return GetClosest(arr, x, 0, 1);
        }

        if (right == arr.Length - 1)
        {
            return GetClosest(arr, x, arr.Length - 2, arr.Length - 1);
        }

        int a = GetClosest(arr, x, left - 1, left);
        int b = GetClosest(arr, x, left, left + 1);

        return GetClosest(arr, x, a, b);
    }

    private int GetClosest(int[] arr, int x, int i, int j)
    {
        if (i < 0 || i > arr.Length - 1)
        {
            return j;
        }

        if (j < 0 || j > arr.Length - 1)
        {
            return i;
        }

        if (Math.Abs(arr[i] - x) <= Math.Abs(arr[j] - x))
        {
            return i;
        }
        else
        {
            return j;
        }
    }

    public IList<int> FindClosestElements(int[] arr, int k, int x) 
    {
        if (arr.Length == k)
        {
            return arr.ToList();
        }

        int closest = FindClosestElement(arr, x);

        int i = closest;
        int j = closest;

        Console.WriteLine($"{closest}; {arr[closest]}");

        while (j - i + 1 < k)
        {
            if (i <= 0)
            {
                ++j;
                continue;
            }

            if (j >= arr.Length - 1)
            {
                --i;
                continue;
            }

            if (Math.Abs(arr[i - 1] - x) <= Math.Abs(arr[j + 1] - x))
            {
                --i;
            }
            else
            {
                ++j;
            }
        }

        var result = new List<int>();
        for (int l = i; l <= j; ++l)
        {
            result.Add(arr[l]);
        }

        return result;
    }
}

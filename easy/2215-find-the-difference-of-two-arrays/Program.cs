public class Solution 
{
    private List<int> GetDifference(int[] a, int[] b)
    {
        var hashset = new HashSet<int>(b);

        var distinctElements = new HashSet<int>();
        var result = new List<int>();

        for (int i = 0; i < a.Length; ++i)
        {
            if (distinctElements.Contains(a[i]))
            {
                continue;
            }

            if (!hashset.Contains(a[i]))
            {
                distinctElements.Add(a[i]);
                result.Add(a[i]);
            }
        }

        return result;
    }

    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) 
    {
        var result = new List<IList<int>>();

        result.Add(GetDifference(nums1, nums2));
        result.Add(GetDifference(nums2, nums1));

        return result;
    }
}

/*
	2 arrays a[i] > 0:
	[5, 2, 6]
	[1, 2]
	return intersections:
	[2]
	
	=============================
	sort, iter
	O(n log n):
	O(1)
	
	=============================
	hashmap<int, int>
	O(n)
	O(n)
	
*/

public class Solution 
{
    private Dictionary<int, int> CreateMap(int[] arr)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; ++i)
        {
            if (!map.ContainsKey(arr[i]))
            {
                map[arr[i]] = 0;
            }

            ++map[arr[i]];
        }

        return map;
    }

    public int[] Intersect(int[] nums1, int[] nums2) 
    {
        int[] toMap = nums1.Length > nums2.Length ? nums2 : nums1;
        Dictionary<int, int> map = CreateMap(toMap);

        int[] toIter = nums1.Length > nums2.Length ? nums1 : nums2;

        List<int> intersections = new List<int>();
        for (int i = 0; i < toIter.Length; ++i)
        {
            if (map.ContainsKey(toIter[i]) && map[toIter[i]] > 0)
            {
                intersections.Add(toIter[i]);
                map[toIter[i]]--;
            }
        }

        return intersections.ToArray();
    }
}

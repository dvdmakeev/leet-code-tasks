public class Solution 
{
    public int[] Intersection(int[] nums1, int[] nums2) 
    {
        var nums1hash = new HashSet<int>(nums1);
        var intersections = new HashSet<int>();
        
        for (int i = 0; i < nums2.Length; ++i)
        {
            if (nums1hash.Contains(nums2[i]) && !intersections.Contains(nums2[i]))
            {
                intersections.Add(nums2[i]);
            }
        }
        
        return intersections.ToArray();
    }
}
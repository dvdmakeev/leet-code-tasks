public class SparseVector 
{
    public List<int[]> Vector { get; private set; }
    
    public SparseVector(int[] nums) 
    {
        Vector = new List<int[]>();
        
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] != 0)
            {
                Vector.Add(new [] { i, nums[i] });
            }
        }
    }
    
    // Return the dotProduct of two sparse vectors
    public int DotProduct(SparseVector vec) 
    {
        int i = 0;
        int j = 0;
        int product = 0;
        while (i < Vector.Count && j < vec.Vector.Count)
        {
            if (Vector[i][0] == vec.Vector[j][0])
            {
                product += Vector[i][1] * vec.Vector[j][1];

                ++i;
                ++j;
                
                continue;
            }
            
            if (Vector[i][0] < vec.Vector[j][0])
            {
                ++i;
            }
            else
            {
                ++j;
            }
        }
        
        return product;
    }
}

// Your SparseVector object will be instantiated and called as such:
// SparseVector v1 = new SparseVector(nums1);
// SparseVector v2 = new SparseVector(nums2);
// int ans = v1.DotProduct(v2);
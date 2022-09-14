/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution 
{
    private void KthSmallestRec(TreeNode node, int k, List<int> nums)
    {
        if (nums.Count == k)
        {
            return;
        }
        
        if (node == null)
        {
            return;
        }
        
        KthSmallestRec(node.left, k, nums);
        if (nums.Count == k)
        {
            return;
        }
        
        nums.Add(node.val);
        if (nums.Count == k)
        {
            return;
        }
        
        KthSmallestRec(node.right, k, nums);
    }
    
    public int KthSmallest(TreeNode root, int k)
    {
        var nums = new List<int>();
        
        KthSmallestRec(root, k, nums);
        
        return nums[k - 1];
    }
}

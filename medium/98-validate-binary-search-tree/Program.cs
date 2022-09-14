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
    private bool IsBinaryTreeBstRec(TreeNode node, int? minValue, int? maxValue)
    {
  	    if (node == null)
        {
    	    return true;
        }
    
        if (minValue.HasValue && node.val <= minValue.Value || maxValue.HasValue && node.val >= maxValue.Value)
        {
    	    return false;
        }
    
        return IsBinaryTreeBstRec(node.left, minValue, node.val) && IsBinaryTreeBstRec(node.right, node.val, maxValue);
    }
  
    public bool IsValidBST(TreeNode root)
    {
  	    return IsBinaryTreeBstRec(root, null, null);
    }
}

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
    public int MaxDepth(TreeNode root) 
    {
        int currentDepth = 0;
        int maxDepth = 0;

        InOrderTraverseRecursive(root, ref currentDepth, ref maxDepth);
            
        return maxDepth;
    }
    
    private void InOrderTraverseRecursive(TreeNode node, ref int currentDepth, ref int maxDepth)
    {
        if (node == null)
        {
            return;
        }
        
        ++currentDepth;
        maxDepth = Math.Max(currentDepth, maxDepth);
        
        InOrderTraverseRecursive(node.left, ref currentDepth, ref maxDepth);
        InOrderTraverseRecursive(node.right, ref currentDepth, ref maxDepth);
        
        --currentDepth;
    }
}
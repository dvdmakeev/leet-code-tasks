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
 
public class SolutionIterative
{
    public bool IsSymmetric(TreeNode root) 
    {
        if (root == null)
        {
            return true;
        }
        
        var nodesToCompare = new Stack<TreeNode>();
        nodesToCompare.Push(root.left);
        nodesToCompare.Push(root.right);
        while (nodesToCompare.Count > 0)
        {
            var right = nodesToCompare.Pop();
            if (nodesToCompare.Count == 0)
            {
                return false;
            }
            
            var left = nodesToCompare.Pop();
            if (right != null && left != null)
            {
                if (right.val != left.val)
                {
                    return false;
                }
                
                nodesToCompare.Push(left.left);
                nodesToCompare.Push(right.right);
                
                nodesToCompare.Push(right.left);
                nodesToCompare.Push(left.right);
            }
            else if (right == null && left == null)
            {
                continue;
            }
            else
            {
                return false;
            }
        }
        
        return true;
    }
}

public class Solution 
{
    public bool IsSymmetric(TreeNode root) 
    {
        return IsSymmetricRec(root.left, root.right);
    }
    
    private bool IsSymmetricRec(TreeNode left, TreeNode right)
    {
        if (left == null && right == null)
        {
            return true;
        }
        
        if (left == null || right == null)
        {
            return false;
        }
        
        if (left.val != right.val)
        {
            return false;
        }
        
        return IsSymmetricRec(left.left, right.right) &&
            IsSymmetricRec(left.right, right.left);
    }
}
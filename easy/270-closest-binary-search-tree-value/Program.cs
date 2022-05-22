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
    public int ClosestValue(TreeNode root, double target) 
    {
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        double diff = int.MaxValue;
        int closestValue = root.val;
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            double currentDiff = Math.Abs(node.val - target);
            if (currentDiff <= 0.5)
            {
                closestValue = node.val;
                break;
            }
            else if (currentDiff < diff)
            {
                diff = currentDiff;
                closestValue = node.val;
            }

            if (target > node.val && node.right != null)
            {
                stack.Push(node.right);
            }
            
            if (target < node.val && node.left != null)
            {
                stack.Push(node.left);
            }
        }
        
        return closestValue;
    }
}
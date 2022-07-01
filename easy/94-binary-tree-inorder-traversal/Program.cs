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
    /*
    
                5
             3      2
           1   2   7
              6   9
           
        1 3 6 2 5 9 7 2
    */
    
    public IList<int> InorderTraversal(TreeNode root) 
    {
        var stack = new Stack<TreeNode>();
        var result = new List<int>();
        
        PushAllLefts(root, stack);
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            result.Add(node.val);
            
            if (node.right != null)
            {
                PushAllLefts(node.right, stack);
            }
        }
        
        return result;
    }
    
    private void PushAllLefts(TreeNode node, Stack<TreeNode> stack)
    {
        while (node != null)
        {
            stack.Push(node);
            node = node.left;
        }
    }
}

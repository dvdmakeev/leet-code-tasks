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
    public IList<int> RightSideView(TreeNode root) 
    {
        var rightSideView = new List<int>();
        if (root == null)
        {
            return rightSideView;
        }
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            bool rightmostAdded = false;
            while (levelSize > 0)
            {
                TreeNode current = queue.Dequeue();;
                
                if (!rightmostAdded)
                {
                    rightSideView.Add(current.val);
                    
                    rightmostAdded = true;
                }
                
                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }
                
                --levelSize;
            }
        }
        
        return rightSideView;
    }
}

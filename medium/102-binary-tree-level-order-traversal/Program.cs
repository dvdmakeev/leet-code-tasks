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
    public IList<IList<int>> LevelOrder(TreeNode root) 
    {
        var traversal = new List<IList<int>>();
        if (root == null)
        {
            return traversal;
        }
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var level = new List<int>();
            for (int levelSize = queue.Count; levelSize > 0; --levelSize)
            {
                var node = queue.Dequeue();
                level.Add(node.val);
                
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            traversal.Add(level);
        }
        
        return traversal;
    }
}

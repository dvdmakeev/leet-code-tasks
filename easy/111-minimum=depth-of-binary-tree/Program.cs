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
    public int MinDepth(TreeNode root) 
    {
        if (root == null)
        {
            return 0;
        }

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        int currentLevel = 0;
        while (queue.Count > 0)
        {
            ++currentLevel;
            int nodesFromCurrentLevelCount = queue.Count;
            while (nodesFromCurrentLevelCount > 0)
            {
                var currentNode = queue.Dequeue();
                --nodesFromCurrentLevelCount;
                
                if (currentNode.left == null && currentNode.right == null)
                {
                    return currentLevel;
                }

                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }
                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }
        }

        return currentLevel;
    }
}

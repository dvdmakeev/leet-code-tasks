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
    public int SumEvenGrandparent(TreeNode root) 
    {
        int sumOfNodes = 0;
        Dfs(root, false, false, ref sumOfNodes);
        return sumOfNodes;
    }
    
    private void Dfs(TreeNode node, bool parentIsEven, bool grandParentIsEven, ref int sumOfNodes)
    {
        if (node == null)
        {
            return;
        }
        
        if (grandParentIsEven)
        {
            sumOfNodes += node.val;
        }
        
        bool isNodeEven = (node.val % 2) == 0;
        
        Dfs(node.left, isNodeEven, parentIsEven, ref sumOfNodes);
        Dfs(node.right, isNodeEven, parentIsEven, ref sumOfNodes);
    }
}


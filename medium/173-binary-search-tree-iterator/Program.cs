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
public class BSTIterator 
{
    private Stack<TreeNode> stack;
    
    private void AddAllLeftsIncludingNode(TreeNode node, Stack<TreeNode> stack)
    {
        while (node != null)
        {
            stack.Push(node);
            node = node.left;
        }
    }
    
    public BSTIterator(TreeNode root) 
    {
        stack = new Stack<TreeNode>();
        
        AddAllLeftsIncludingNode(root, stack);
    }

    public int Next() 
    {
        var node = stack.Pop();
        if (node.right != null)
        {
            AddAllLeftsIncludingNode(node.right, stack);
        }
        
        return node.val;
    }

    public bool HasNext() 
    {
        return stack.Count > 0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
 

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
    public class NodeThreshold
    {
        public TreeNode Node;
        public int Threshold;
        
        public static NodeThreshold Create(TreeNode node, int threshold)
        {
            return new NodeThreshold
            {
                Node = node,
                Threshold = threshold
            };
        }
    }
    
    public int GoodNodes(TreeNode root) 
    {
        int goodNodesCount = 0;
        
        var nodes = new Stack<NodeThreshold>();
        nodes.Push(NodeThreshold.Create(root, int.MinValue));
        while (nodes.Count > 0)
        {
            var nodeThreshold = nodes.Pop();
            var node = nodeThreshold.Node;
            if (nodeThreshold.Node.val >= nodeThreshold.Threshold)
            {
               ++goodNodesCount; 
            }
            
            int newThreshold = Math.Max(nodeThreshold.Threshold, node.val);
            if (node.left != null)
            {
                nodes.Push(NodeThreshold.Create(node.left, newThreshold));
            }
            if (node.right != null)
            {
                nodes.Push(NodeThreshold.Create(node.right, newThreshold));
            }
        }
        
        return goodNodesCount;
    }
}
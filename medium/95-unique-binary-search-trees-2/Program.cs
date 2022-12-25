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
    private IList<TreeNode> GenerateTreesRec(int start, int end)
    {
        var trees = new List<TreeNode>();
        if (start > end)
        {
            trees.Add(null);
            return trees;
        }

        for (int i = start; i <= end; ++i)
        {
            var leftTrees = GenerateTreesRec(start, i - 1);
            var rightTrees = GenerateTreesRec(i + 1, end);

            foreach (var left in leftTrees)
            {
                foreach (var right in rightTrees)
                {
                    var root = new TreeNode(i, left, right);
                    trees.Add(root);
                }
            }
        }

        return trees;
    }

    public IList<TreeNode> GenerateTrees(int n) 
    {
        return GenerateTreesRec(1, n);
    }
}

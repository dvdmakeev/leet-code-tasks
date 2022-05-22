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
  public int RangeSumBST(TreeNode root, int low, int high)
  {
    return RangeSumBSTRecursive(root, low, high);
  }

  private int RangeSumBSTRecursive(TreeNode node, int low, int high)
  {
    if (node == null)
    {
      return 0;
    }

    int sum = 0;
    if (node.val >= low && node.val <= high)
    {
      sum += node.val;
    }
    if (node.val >= low)
    {
      sum += RangeSumBSTRecursive(node.left, low, high);
    }
    if (node.val <= high)
    {
      sum += RangeSumBSTRecursive(node.right, low, high);
    }

    return sum;
  }
}
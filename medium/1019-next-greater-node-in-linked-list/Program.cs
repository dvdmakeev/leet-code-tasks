/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    public int[] NextLargerNodes(ListNode head) 
    {
        var arr = new List<int>();
        for (ListNode current = head; current != null; current = current.next)
        {
            arr.Add(current.val);
        }
        
        var result = new int[arr.Count];
        var stack = new Stack<int>();
        
        for (int i = 0; i < arr.Count; ++i)
        {
            while (stack.Count > 0 && arr[stack.Peek()] < arr[i])
            {
                var lessest = stack.Pop();
                result[lessest] = arr[i];
            }
            
            stack.Push(i);
        }
        
        return result;
    }
}

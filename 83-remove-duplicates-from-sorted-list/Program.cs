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
    public ListNode DeleteDuplicates(ListNode head) 
    {
        var node = head;
        while (node != null)
        {
            if (node.next != null && node.val == node.next.val)
            {
                node.next = node.next.next;
            }
            else
            {
                node = node.next;
            }
        }
        
        return head;
    }
}
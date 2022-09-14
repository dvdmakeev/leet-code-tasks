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
    public ListNode SwapPairs(ListNode head) 
    {
        if (head == null || head.next == null)
        {
            return head;
        }
        
        ListNode prev = null;
        ListNode current = head;
        
        ListNode newHead = null;
        while (current != null && current.next != null)
        {
            ListNode next = current.next;
            
            if (newHead == null)
            {
                newHead = next;
            }
            
            current.next = next.next;
            ListNode nextTmp = next.next;
            next.next = current;
            
            if (prev != null)
            {
                prev.next = next;
            }
            prev = current;
            
            current = nextTmp;
        }
        
        return newHead;
    }
}

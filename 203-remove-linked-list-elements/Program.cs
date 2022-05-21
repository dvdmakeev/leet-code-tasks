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
    public ListNode RemoveElements(ListNode head, int val) 
{
        ListNode prev = null;
        ListNode current = head;
        while (current != null)
        {
            if (current.val != val)
            {
                prev = current;
            }
            else
            {
                if (prev == null)
                {
                    head = current.next;
                }
                else
                {
                    prev.next = current.next;
                }
            }

            current = current.next;
        }
        
        return head;
    }
}

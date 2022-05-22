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
    public ListNode ReverseList(ListNode head) 
    {
        ListNode node = head;
        ListNode prev = null;
        while (node != null)
        {
            var nextNode = node.next;
            node.next = prev;
            prev = node;
            node = nextNode;
        }
        
        return prev;
    }
}
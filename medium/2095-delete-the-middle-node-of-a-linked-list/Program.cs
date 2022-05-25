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
    public ListNode DeleteMiddle(ListNode head)
    {
        ListNode middleFinder = head;
        ListNode tailFinder = head;
        ListNode preMiddle = null;
        
        while (tailFinder != null && tailFinder.next != null)
        {
            preMiddle = middleFinder;
            
            middleFinder = middleFinder.next;
            tailFinder = tailFinder.next.next;
        }
        
        if (preMiddle == null)
        {
            return null;
        }
        
        preMiddle.next = middleFinder.next;
        return head;
    }
}


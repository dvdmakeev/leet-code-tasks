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
    public ListNode ReverseBetween(ListNode head, int left, int right) 
    {
        if (left == right)
        {
            return head;
        }
        
        int i = 1;
        ListNode prev = null;
        ListNode cur = head;
        while (i < left)
        {
            prev = cur;
            cur = cur.next;
            ++i;
        }
        
        ListNode fstReversed = null;
        ListNode lastReversed = null;
        ListNode prevRev = null;
        while (i <= right)
        {
            if (fstReversed == null)
            {
                fstReversed = cur;
                prevRev = cur;
                cur = cur.next;
                fstReversed.next = null;
            }
            else
            {
                lastReversed = cur;
                ListNode tmp = cur.next;
                cur.next = prevRev;
                prevRev = cur;
                cur = tmp;   
            }
            ++i;
        }
        
        if (prev != null)
        {
            prev.next = lastReversed;
        }
        else
        {
            head = lastReversed;
        }

        fstReversed.next = cur;
        
        return head;
    }
}


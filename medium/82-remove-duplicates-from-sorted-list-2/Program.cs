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
    // 1 2 2 3 4 4 4 5 
    // 
    // 1 1 1
    // 1
    //
    //
    public ListNode DeleteDuplicates(ListNode head) 
    {
        if (head == null)
        {
            return null;
        }
        
        ListNode duplicatenessHead = null;

        ListNode lastDuplicateness = null;
        ListNode current = head;
        int duplicatedValue = -200;
        while (current.next != null)
        {
            if (current.val == duplicatedValue)
            {
                current = current.next;
                continue;
            }
            
            if (current.val != current.next.val)
            {
                if (lastDuplicateness == null)
                {
                    lastDuplicateness = current;
                    duplicatenessHead = current;
                }
                else
                {
                    lastDuplicateness.next = current;
                    lastDuplicateness = current;
                }
                
                current = current.next;
            }
            else
            {
                while (current != null && current.next != null && current.val == current.next.val)
                {
                    duplicatedValue = current.val;
                    current = current.next;
                }
            }
        }
        
        if (current != null)
        {
            if (duplicatedValue != current.val)
            {
                if (lastDuplicateness == null)
                {
                    lastDuplicateness = current;
                    duplicatenessHead = current;
                }
                else
                {
                    lastDuplicateness.next = current;
                    lastDuplicateness = current;
                }
            }
        }
        
        if (lastDuplicateness != null)
        {
            lastDuplicateness.next = null;
        }
        
        return duplicatenessHead;
    }
}

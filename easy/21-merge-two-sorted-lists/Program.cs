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
 public class RecursiveSolution 
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) 
    {
        ListNode preTail = new ListNode(0);
        MergeTwoListsRec(l1, l2, preTail);
            
        return preTail.next;
    }
    
    private void MergeTwoListsRec(ListNode l1, ListNode l2, ListNode mergedListTail)
    {
        if (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                mergedListTail.next = l1;
                MergeTwoListsRec(l1.next, l2, mergedListTail.next);
            }
            else
            {
                mergedListTail.next = l2;
                MergeTwoListsRec(l1, l2.next, mergedListTail.next);
            }
        }
        else if (l1 == null)
        {
            mergedListTail.next = l2;
        }
        else if (l2 == null)
        {
            mergedListTail.next = l1;
        }
    }
}
 
public class Solution 
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) 
    {
        ListNode result = null;
        ListNode resTail = null;
        if (l1 != null && (l2 == null || l1.val <= l2.val))
        {
            result = l1;
            l1 = l1.next;
        }
        else if (l2 != null)
        {
            result = l2;
            l2 = l2.next;
        }
        resTail = result;
        
        while (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                resTail.next = l1;
                resTail = resTail.next;
                l1 = l1.next;
            }
            else
            {
                resTail.next = l2;
                resTail = resTail.next;
                l2 = l2.next;
            }
        }
        
        while (l1 != null)
        {
            resTail.next = l1;
            resTail = resTail.next;
            l1 = l1.next;
        }
        
        while (l2 != null)
        {
            resTail.next = l2;
            resTail = resTail.next;
            l2 = l2.next;
        }
        
        return result;
    }
}
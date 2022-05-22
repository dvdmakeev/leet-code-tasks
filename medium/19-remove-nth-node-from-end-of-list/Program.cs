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
 public class SolutionOnePass
{
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        ListNode preN = null;
        var node = head;
        int i = 0;
        while (node != null)
        {
            if (i < n)
            {
                ++i;
            }
            else if (i == n)
            {
                preN = head;
                ++i;
            }
            else
            {
                preN = preN.next;
            }
            
            node = node.next;
        }
        if (preN != null)
        {
            preN.next = preN.next.next;
        }
        else
        {
            head = head.next;
        }
        
        return head;
    }
}

public class Solution 
{
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        int listSize = GetListSize(head);
        
        var node = head;
        int i = 0;
        int preN = listSize - n - 1;
        if (preN < 0)
        {
            return head?.next;
        }
        while (i < preN)
        {
            node = node.next;
            ++i;
        }
        node.next = node.next.next;
        
        return head;
    }
    
    private int GetListSize(ListNode head)
    {
        var node = head;
        int listSize = 0;
        while (node != null)
        {
            ++listSize;
            node = node.next;
        }

        return listSize;
    }
}
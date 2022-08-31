/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution 
{
    private ListNode FindCycle(ListNode head)
    {
        ListNode fast = head;
        ListNode slow = head;
        
        while (fast != null && fast.next != null)
        {   
            fast = fast.next.next;
            slow = slow.next;
            
            if (fast == slow)
            {
                return fast;
            }
        }
        
        return null;
    }
    
    private int FindCycleLength(ListNode cycleNode)
    {
        ListNode current = cycleNode.next;
        int length = 1;
        while (current != cycleNode)
        {
            current = current.next;
            ++length;
        }
        
        return length;
    }
    
    public ListNode DetectCycle(ListNode head) 
    {
        var cycleNode = FindCycle(head);
        if (cycleNode == null)
        {
            return null;
        }

        int cycleLength = FindCycleLength(cycleNode);
        ListNode startFinder = head;
        while (cycleLength > 0)
        {
            startFinder = startFinder.next;
            --cycleLength;
        }
        
        ListNode current = head;
        while (current != startFinder)
        {
            current = current.next;
            startFinder = startFinder.next;
        }
        
        return startFinder;
    }
}

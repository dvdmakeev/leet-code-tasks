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
    public bool HasCycle(ListNode head) 
    {
        if (head == null)
        {
            return false;
        }
        
        var slowIter = head;
        var fastIter = head.next;
        while (slowIter != fastIter)
        {
            if (fastIter == null || fastIter.next == null)
            {
                return false;
            }
            
            slowIter = slowIter.next;            
            fastIter = fastIter.next.next;
        }

        return true;
    }
}


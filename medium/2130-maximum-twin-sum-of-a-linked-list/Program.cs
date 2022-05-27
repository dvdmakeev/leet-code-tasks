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
    public int PairSum(ListNode head) 
    {
        ListNode halfEnd = FindHalfEnd(head);
        ListNode middle = halfEnd.next;
        halfEnd.next = null;
        ListNode reversedMiddle = ReverseList(middle);

        ListNode cur = head;
        ListNode curHalf = reversedMiddle;
        int maxTwinSum = int.MinValue;
        while (cur != null && curHalf != null)
        {
            if (cur.val + curHalf.val > maxTwinSum)
            {
                maxTwinSum = cur.val + curHalf.val;
            }
            
            cur = cur.next;
            curHalf = curHalf.next;
        }
        
        middle = ReverseList(reversedMiddle);
        halfEnd.next = middle;
        return maxTwinSum;
    }
    
    private ListNode FindHalfEnd(ListNode head)
    {
        ListNode halfEnd = head;
        ListNode middleFinder = head;
        ListNode tailFinder = head;
        while (tailFinder != null && tailFinder.next != null)
        {
            halfEnd = middleFinder;
            middleFinder = middleFinder.next;
            tailFinder = tailFinder.next.next;
        }
        
        return halfEnd;
    }
    
    private ListNode ReverseList(ListNode node)
    {
        ListNode prev = null;
        ListNode cur = node;
        
        while (cur != null)
        {
            ListNode tmp = cur.next;
            cur.next = prev;
            prev = cur;
            cur = tmp;
        }
        
        return prev;
    }
}


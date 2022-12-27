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
    private ListNode FindMiddle(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    private ListNode Reverse(ListNode head)
    {
        ListNode node  = head;
        ListNode prev = null;
        while (node != null)
        {
            ListNode next = node.next;

            node.next = prev;
            prev = node;

            node = next;
        }

        return prev;
    }
    
    public void ReorderList(ListNode head) 
    {
        ListNode middle = FindMiddle(head);

        ListNode curLeft = head;
        ListNode curRight = Reverse(middle);

        while(curLeft != null && curRight != null)
        {
            ListNode leftNext = curLeft.next;
            curLeft.next = curRight;
            curLeft = leftNext;

            ListNode rightNext = curRight.next;
            curRight.next = curLeft;
            curRight = rightNext;
        }

        if (curLeft != null)
        {
            curLeft.next = null;
        }
    }
}

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
    private ListNode Reverse(ListNode head)
    {
        ListNode prev = null;
        ListNode node = head;
        while (node != null)
        {
            ListNode next = node.next;
            node.next = prev;
            prev = node;

            node = next;
        }

        return prev;
    }

    public bool IsPalindrome(ListNode head) 
    {
        ListNode slow = head;
        ListNode fast = head.next;

        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode middle = slow;

        ListNode sndHalfHead = Reverse(middle.next);
        ListNode sndHalf = sndHalfHead;
        ListNode fstHalf = head;

        bool isPalindrome = true;
        while (sndHalf != null)
        {
            if (fstHalf.val != sndHalf.val)
            {
                isPalindrome = false;
                break;
            }

            sndHalf = sndHalf.next;
            fstHalf = fstHalf.next;
        }

        Reverse(sndHalfHead);

        return isPalindrome;
    }
}

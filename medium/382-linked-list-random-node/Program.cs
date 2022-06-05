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
    private ListNode head;
    
    public Solution(ListNode head) 
    {
        this.head = head;
    }
    
    public int GetRandom() 
    {
        int val = head.val;
        var rnd = new Random();
        ListNode cur = head;
        int i = 0;
        while (cur != null)
        {
            ++i;
            double probability = (double)1 / i;
            if (rnd.NextDouble() < probability)
            {
                val = cur.val;
            }
            cur = cur.next;
        }
        
        return val;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */


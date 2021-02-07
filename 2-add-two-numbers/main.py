class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:
    def add_two_numbers(self, l1: ListNode, l2: ListNode) -> ListNode:
        result = ListNode()
        cur_l1 = l1
        cur_l2 = l2
        overflow = 0
        current_res = None

        while cur_l1 is not None or cur_l2 is not None or overflow != 0:
            if current_res is None:
                current_res = result
            else:
                new_node = ListNode()
                current_res.next = new_node
                current_res = new_node

            current_digit = overflow
            if cur_l1 is not None:
                current_digit += cur_l1.val
                cur_l1 = cur_l1.next
            if cur_l2 is not None:
                current_digit += cur_l2.val
                cur_l2 = cur_l2.next

            current_res.val = current_digit % 10
            overflow = current_digit // 10

        return result

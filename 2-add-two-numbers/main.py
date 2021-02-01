class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def addTwoNumbers(self, l1: ListNode, l2: ListNode) -> ListNode:
        result = ListNode()
        curL1 = l1
        curL2 = l2
        overflow = 0
        currentRes = None

        while curL1 is not None or curL2 is not None or overflow != 0:
            if currentRes is None:
                currentRes = result
            else:
                newNode = ListNode()
                currentRes.next = newNode
                currentRes = newNode

            currentDigit = overflow
            if curL1 is not None:
                currentDigit += curL1.val
                curL1 = curL1.next
            if curL2 is not None:
                currentDigit += curL2.val
                curL2 = curL2.next

            currentRes.val = currentDigit % 10
            overflow = currentDigit // 10

        return result
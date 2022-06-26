# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def mergeKLists(self, lists: List[Optional[ListNode]]) -> Optional[ListNode]:
        ListNode.__eq__ = lambda self, other: self.val == other.val
        ListNode.__lt__ = lambda self, other: self.val < other.val

        heap = []
        for head in lists:
            if head:
                heapq.heappush(heap, head)

        resultHead = None
        currentNode = None
        while heap:
            node = heapq.heappop(heap)

            if not resultHead:
                resultHead = node
                currentNode = node
            else:
                currentNode.next = node
                currentNode = node

            if node.next:
                heapq.heappush(heap, node.next)

        return resultHead


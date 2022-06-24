from collections import deque

# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def zigzagLevelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        zigzagOrder = []
        if not root:
            return zigzagOrder
        
        queue = deque()
        queue.append(root)
        leftToRight = True
        while queue:
            levelSize = len(queue)
            level = []
            for _ in range(levelSize):
                node = queue.popleft()
                if leftToRight:
                    level.append(node.val)
                else:
                    level.insert(0, node.val)
                
                if node.left:
                    queue.append(node.left)
                if node.right:
                    queue.append(node.right)
                    
            leftToRight = not leftToRight
            zigzagOrder.append(level)
        
        return zigzagOrder

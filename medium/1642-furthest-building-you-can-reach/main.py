class Solution:
    def furthestBuilding(self, heights: List[int], bricks: int, ladders: int) -> int:
        heapLadders = []
        
        buildings = 0
        for i in range(len(heights) - 1):
            height = heights[i + 1] - heights[i]
            if height <= 0:
                buildings += 1
            else:
                if len(heapLadders) < ladders:
                    heappush(heapLadders, height)
                    buildings += 1
                else:
                    minLadder = heappop(heapLadders) if len(heapLadders) > 0 else maxsize
                    minHeight = min(minLadder, height)
                    if minHeight <= bricks:
                        bricks -= minHeight
                        heappush(heapLadders, max(minLadder, height))
                        buildings += 1
                    else:
                        return buildings
        return buildings
      

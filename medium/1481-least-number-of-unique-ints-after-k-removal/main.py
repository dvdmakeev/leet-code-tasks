class Element:
    def __init__(self, val, freq):
        self.val = val
        self.freq = freq

    def __lt__(self, other):
        return self.freq < other.freq

class Solution:
    def findLeastNumOfUniqueInts(self, arr: List[int], k: int) -> int:
        map = {}
        for i in arr:
            map[i] = map.get(i, 0) + 1

        heap = []

        for key, val in map.items():
            heappush(heap, Element(key, val))

        for i in range(k):
            if not heap:
                break
            toRemove = heappop(heap)
            toRemove.freq -= 1
            if toRemove.freq > 0:
                heappush(heap, toRemove)

        return len(heap)

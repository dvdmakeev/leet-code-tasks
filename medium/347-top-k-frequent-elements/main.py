class Element:
    def __init__(self, value, frequency):
        self.value = value
        self.frequency = frequency

    def __lt__(self, other):
        return self.frequency < other.frequency

    def __neg__(self):
        return Element(self.value, -self.frequency)

class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        map = {}
        for i in nums:
            map[i] = map.get(i, 0) + 1

        heap = []
        for key, val in map.items():
            if (len(heap) < k):
                heappush(heap, Element(key, val))
            elif heap[0].frequency < val:
                heappop(heap)
                heappush(heap, Element(key, val))

        return [x.value for x in heap]

class MedianFinder:
    def __init__(self):
        self.min_heap = []
        self.max_heap = []

    def _rebalance_heaps(self):
        if len(self.max_heap) > len(self.min_heap) + 1:
            heapq.heappush(self.min_heap, -heapq.heappop(self.max_heap))
        elif len(self.min_heap) > len(self.max_heap):
            heapq.heappush(self.max_heap, -heapq.heappop(self.min_heap))

    def add(self, num: int):
        if not self.max_heap or -self.max_heap[0] >= num:
            heapq.heappush(self.max_heap, -num)
        else:
            heapq.heappush(self.min_heap, num)

        self._rebalance_heaps()

    def getMedian(self) -> float:
        if len(self.min_heap) == len(self.max_heap):
            return (-self.max_heap[0] + self.min_heap[0]) / 2

        return -self.max_heap[0]

    def pop(self, num: int):
        if num <= -self.max_heap[0]:
            self._remove(self.max_heap, -num)
        else:
            self._remove(self.min_heap, num)

        self._rebalance_heaps()

    def _remove(self, heap, element):
        ind = heap.index(element)  # find the element
        # move the element to the end and delete it
        heap[ind] = heap[-1]
        del heap[-1]
        # we can use heapify to readjust the elements but that would be O(N),
        # instead, we will adjust only one element which will O(logN)
        if ind < len(heap):
            heapq.heapify(heap)

class Solution:
    def medianSlidingWindow(self, nums: List[int], k: int) -> List[float]:
        median_finder = MedianFinder()

        medians = []
        start = 0
        for end in range(len(nums)):
            median_finder.add(nums[end])

            if end - start + 1 > k:
                median_finder.pop(nums[start])
                start += 1

            if end - start + 1 == k:
                medians.append(median_finder.getMedian())

        return medians

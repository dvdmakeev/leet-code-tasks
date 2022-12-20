class Solution:
    def findRightInterval(self, intervals: List[List[int]]) -> List[int]:
        maxStart = []
        maxEnd = []

        for i in range(len(intervals)):
            heapq.heappush(maxStart, (-intervals[i][0], i))
            heapq.heappush(maxEnd, (-intervals[i][1], i))

        rightIntervals = [0 for x in range(len(intervals))]
        for _ in range(len(intervals)):
            curMaxEnd = heapq.heappop(maxEnd)

            rightInterval= -1
            if maxStart and -maxStart[0][0] >= -curMaxEnd[0]:
                topStart = heapq.heappop(maxStart)
                while maxStart and -maxStart[0][0] >= -curMaxEnd[0]:
                    topStart = heapq.heappop(maxStart)

                rightInterval = topStart[1]
                heapq.heappush(maxStart, topStart)

            rightIntervals[curMaxEnd[1]] = rightInterval

        return rightIntervals

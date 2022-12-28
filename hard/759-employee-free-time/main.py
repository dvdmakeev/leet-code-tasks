"""
# Definition for an Interval.
class Interval:
    def __init__(self, start: int = None, end: int = None):
        self.start = start
        self.end = end
"""

class Solution:
    def employeeFreeTime(self, schedule: '[[Interval]]') -> '[Interval]':
        Interval.__lt__ = lambda a, b: a.start < b.start

        freeTime = []
        minHeap = []

        for i in range(len(schedule)):
            interval = schedule[i][0]
            interval.employeeIndex = i
            interval.intervalIndex = 0

            heapq.heappush(minHeap, interval)

        lastInterval = minHeap[0]
        while minHeap:
            topInterval = heapq.heappop(minHeap)
            if lastInterval.end < topInterval.start:
                freeTime.append(Interval(lastInterval.end, topInterval.start))
                lastInterval = topInterval
            else:
                if lastInterval.end < topInterval.end:
                    lastInterval = topInterval

            if topInterval.intervalIndex + 1 < len(schedule[topInterval.employeeIndex]):
                nextInterval = schedule[topInterval.employeeIndex][topInterval.intervalIndex + 1]
                interval = Interval(nextInterval.start, nextInterval.end)
                interval.employeeIndex = topInterval.employeeIndex
                interval.intervalIndex = topInterval.intervalIndex + 1
                heapq.heappush(minHeap, interval)

        return freeTime

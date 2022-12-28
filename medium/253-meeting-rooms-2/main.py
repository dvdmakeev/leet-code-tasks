class Solution:
    def minMeetingRooms(self, intervals: List[List[int]]) -> int:
        minRooms = 0
        intervals.sort()

        overlappedMeetings = []

        for i in range(len(intervals)):
            while len(overlappedMeetings) > 0 and overlappedMeetings[0] <= intervals[i][0]:
                heapq.heappop(overlappedMeetings)
            
            heapq.heappush(overlappedMeetings, intervals[i][1])
            minRooms = max(len(overlappedMeetings), minRooms)

        return minRooms

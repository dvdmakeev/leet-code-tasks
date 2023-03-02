class Trip:
    def __init__(self, capacity: int, start: int = None, end: int = None):
        self.capacity = capacity
        self.start = start
        self.end = end

class Solution:
    def carPooling(self, trips: List[List[int]], capacity: int) -> bool:
        trips.sort(key=lambda x: x[1])
        Trip.__lt__ = lambda a, b: a.end < b.end

        currentCapacity = 0        
        currentTrips = []
        
        for trip in trips:
            while len(currentTrips) > 0 and currentTrips[0].end <= trip[1]:
                tripToRemove = heapq.heappop(currentTrips)
                currentCapacity -= tripToRemove.capacity
            
            currentCapacity += trip[0]
            heapq.heappush(currentTrips, Trip(trip[0], trip[1], trip[2]))
            if currentCapacity > capacity:
                return False
    
        return True

class Solution:
    def findMaximizedCapital(self, k: int, w: int, profits: List[int], capital: List[int]) -> int:
        maxProfits = []
        minCapitals = []

        for i in range(len(capital)):
            heapq.heappush(minCapitals, (capital[i], i))

        currentCapital = w
        for _ in range(k):
            while minCapitals and minCapitals[0][0] <= currentCapital:
                minCapital = heapq.heappop(minCapitals)
                heapq.heappush(maxProfits, -profits[minCapital[1]])

            if not maxProfits:
                break

            currentCapital += -heapq.heappop(maxProfits)
        return currentCapital

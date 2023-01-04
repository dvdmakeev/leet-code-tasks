class MyPoint:
    def __init__(self, p: List[int]):
        self.p = p

    @staticmethod
    def _calc_distance(x: List[int], y: List[int]):
        return math.sqrt(abs(x[0] - y[0]) ** 2 + abs(x[1] - y[1]) ** 2)

    def __lt__(self, other):
        return MyPoint._calc_distance(self.p, [0, 0]) < MyPoint._calc_distance(other.p, [0, 0])

class Solution:
    def kClosest(self, points: List[List[int]], k: int) -> List[List[int]]:
        heap = []

        for point in points:
            heappush(heap, MyPoint(point))

        closest = []
        for i in range(k):
            closest.append(heappop(heap).p)
        return closest

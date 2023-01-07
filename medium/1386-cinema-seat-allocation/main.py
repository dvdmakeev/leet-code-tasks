class Solution:
    def maxNumberOfFamilies(self, n: int, reservedSeats: List[List[int]]) -> int:
        map = defaultdict(set)
        for i, j in reservedSeats:
            if j in [2,3,4,5]:
                map[i].add(0)
            if j in [4,5,6,7]:
                map[i].add(1)
            if j in [6,7,8,9]:
                map[i].add(2)

        totalFamilySeats = n * 2
        for i in map:
            if len(map[i]) == 3:
                totalFamilySeats -= 2
            else:
                totalFamilySeats -= 1

        return totalFamilySeats

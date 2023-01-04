class Elem:
    def __init__(self, value, freq):
        self.value = value
        self.freq = freq

    def __lt__(self, other):
        return self.freq < other.freq

class Solution:
    def frequencySort(self, s: str) -> str:
        map = {}
        for c in s:
            map[c] = map.get(c, 0) + 1

        heap = []
        for k, v in map.items():
            heappush(heap, Elem(k, v))

        charsToConcat = []
        while heap:
            elem = heappop(heap)
            
            for _ in range(elem.freq):
                charsToConcat.append(elem.value)

        charsToConcat.reverse()
        return ''.join(charsToConcat)

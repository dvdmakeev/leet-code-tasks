class Char:
    def __init__(self, char, count):
        self.char = char
        self.count = count

    def __lt__(self, other):
        return self.count < other.count


class Solution:
    def reorganizeString(self, s: str) -> str:
        map = {}
        for c in s:
            map[c] = map.get(c, 0) + 1

        heap = []
        for key, val in map.items():
            heappush(heap, Char(key, -val))

        prevChar = None
        resultChars = []
        while heap:
            curChar = heappop(heap)
            if prevChar and -prevChar.count > 0:
                heappush(heap, prevChar)
            resultChars.append(curChar.char)
            curChar.count += 1
            prevChar = curChar

        return ''.join(resultChars) if len(resultChars) == len(s) else ''

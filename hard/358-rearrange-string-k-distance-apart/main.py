class Char:
    def __init__(self, char, count):
        self.char = char
        self.count = count

    def __lt__(self, other):
        return self.count < other.count


class Solution:
    def rearrangeString(self, s: str, k: int) -> str:
        if k == 0:
            return s

        map = {}
        for c in s:
            map[c] = map.get(c, 0) + 1

        heap = []
        for char, freq in map.items():
            heappush(heap, Char(char, -freq))

        result = []
        queue = deque()
        while heap:
            char = heappop(heap)
            result.append(char.char)
            char.count += 1
            queue.append(char)

            if len(queue) == k:
                char = queue.popleft()
                if -char.count > 0:
                    heappush(heap, char)

        return ''.join(result) if len(result) == len(s) else ''

class Letter:
    def __init__(self, char, count):
        self.char = char
        self.count = count

    def __lt__(self, other):
        return self.count < other.count

class Solution:
    def _get_max_chars(self, letter: Letter, prevLetter: Letter):
        chars = []

        if not prevLetter or -letter.count > -prevLetter.count:
            for i in range(2):
                if -letter.count == 0:
                    break

                letter.count += 1
                chars.append(letter.char)
        else:
            letter.count += 1
            chars.append(letter.char)

        return chars

    def _add_to_heap(self, heap, char, count):
        if (count > 0):
            heappush(heap, Letter(char, -count))

    def longestDiverseString(self, a: int, b: int, c: int) -> str:
        heap = []
        self._add_to_heap(heap, 'a', a)
        self._add_to_heap(heap, 'b', b)
        self._add_to_heap(heap, 'c', c)

        result = []
        prevChar = None
        while heap:
            char = heappop(heap)
            result += self._get_max_chars(char, prevChar)

            if prevChar and -prevChar.count > 0:
                heappush(heap, prevChar)
            prevChar = char

        return ''.join(result)

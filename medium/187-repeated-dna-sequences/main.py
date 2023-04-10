class Solution:
    def findRepeatedDnaSequences(self, s: str) -> List[str]:
        sequenceLength = 10

        dnas = {}

        start = 0
        for end in range(len(s)):
            if end - start + 1 < sequenceLength:
                continue

            dna = s[start:end+1]
            dnas[dna] = dnas.get(dna, 0) + 1

            start += 1

        return [key for key, value in dnas.items() if value > 1]

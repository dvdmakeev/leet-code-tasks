class Solution:
    def bitwiseComplement(self, n: int) -> int:
        if n == 0:
            return 1

        numOfBits = 0
        current = n
        while current > 0:
            current = current >> 1
            numOfBits += 1
        mask = (2 ** numOfBits) - 1

        return mask ^ n

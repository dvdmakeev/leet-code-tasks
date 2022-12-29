class Solution:
    def singleNumber(self, nums: List[int]) -> List[int]:
        xorNums = 0
        for i in nums:
            xorNums ^= i

        distinguishedBit = 1
        while (xorNums & distinguishedBit) == 0:
            distinguishedBit = distinguishedBit << 1

        num1 = 0
        num2 = 0

        for i in nums:
            if i & distinguishedBit == 0:
                num1 ^= i
            else:
                num2 ^= i

        return [num1, num2]

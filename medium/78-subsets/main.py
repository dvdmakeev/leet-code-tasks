class Solution:
    def subsets(self, nums: List[int]) -> List[List[int]]:
        result = []

        result.append([])
        for i in range(len(nums)):
            newElements = []
            for current in result:
                elementToUpdate = current[:]
                elementToUpdate.append(nums[i])
                newElements.append(elementToUpdate)
            result += newElements

        return result

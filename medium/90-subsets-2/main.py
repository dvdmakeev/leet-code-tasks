class Solution:
    def subsetsWithDup(self, nums: List[int]) -> List[List[int]]:
        nums.sort()
        subsets = []
        subsets.append([])
        prevLength = 0
        for i in range(len(nums)):
            addFrom = 0
            if i > 0 and nums[i] == nums[i - 1]:
                addFrom = prevLength

            newSubsets = []
            prevLength = len(subsets)
            for j in range(addFrom, len(subsets)):
                newSubset = subsets[j][:]
                newSubset.append(nums[i])
                newSubsets.append(newSubset)
            subsets += newSubsets

        return subsets

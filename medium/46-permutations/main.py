class Solution:
    def permute(self, nums: List[int]) -> List[List[int]]:
        permutations = []
        
        permutations.append([])
        for i in range(len(nums)):
            updatedPermutations = []
            for j in range(len(permutations)):
                permutationLength = len(permutations[j])
                for k in range(permutationLength + 1):
                    newPermutation = permutations[j][:]
                    newPermutation.insert(k, nums[i])
                    updatedPermutations.append(newPermutation)
            permutations = updatedPermutations


        return permutations

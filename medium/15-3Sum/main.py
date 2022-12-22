class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        triplets = []
        nums.sort()

        for i in range(len(nums)):
            if i > 0 and nums[i] == nums[i - 1]:
                continue

            j = i + 1
            k = len(nums) - 1

            while j < k:
                tripletSum = nums[i] + nums[j] + nums[k]
                if tripletSum > 0:
                    k -= 1
                elif tripletSum < 0:
                    j += 1
                elif tripletSum == 0:
                    triplets.append([nums[i], nums[j], nums[k]])

                    j += 1
                    while j < k and nums[j] == nums[j - 1]:
                        j += 1
                    k -= 1
                    while k > j and nums[k] == nums[k + 1]:
                        k -= 1                    

        return triplets

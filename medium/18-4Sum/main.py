class Solution:
    def fourSum(self, nums: List[int], target: int) -> List[List[int]]:
        quadriplets = []
        nums.sort()

        for a in range(len(nums)):
            if a > 0 and nums[a] == nums[a - 1]:
                continue

            for i in range(a + 1, len(nums)):
                if i > a + 1 and nums[i] == nums[i - 1]:
                    continue

                j = i + 1
                k = len(nums) - 1

                while j < k:
                    quadripletSum = nums[a] + nums[i] + nums[j] + nums[k]
                    if quadripletSum > target:
                        k -= 1
                    elif quadripletSum < target:
                        j += 1
                    elif quadripletSum == target:
                        quadriplets.append([nums[a], nums[i], nums[j], nums[k]])

                        j += 1
                        while j < k and nums[j] == nums[j - 1]:
                            j += 1
                        k -= 1
                        while k > j and nums[k] == nums[k + 1]:
                            k -= 1                    

        return quadriplets

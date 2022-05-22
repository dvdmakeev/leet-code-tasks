class Solution:
    def length_of_longest_substring(self, s: str) -> int:
        if not s:
            return 0

        num = 0
        for i in range(len(s)):
            j = i + 1
            while j < len(s) and s[j] not in s[i:j]:
                j += 1
            num = max(num, j - i)
        return num

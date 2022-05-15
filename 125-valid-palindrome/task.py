class Solution:
    def _isDelimiter(self, c):
        return not c.isalpha() and not c.isnumeric()

    def isPalindrome(self, s: str) -> bool:
        i = 0
        j = len(s) - 1
        while i <= j:
            if self._isDelimiter(s[i]):
                i += 1
                continue
            if self._isDelimiter(s[j]):
                j -= 1
                continue
            if s[i].lower() != s[j].lower():
                return False
            i += 1
            j -= 1
        return True

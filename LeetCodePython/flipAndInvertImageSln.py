class Solution:
    def flipAndInvertImage(self, A):
        """
        :type A: List[List[int]]
        :rtype: List[List[int]]
        """
        result = []
        for row in A:
            r = []
            for item in row:
                r.append(item^1)
            r.reverse()
            result.append(r)
        return result

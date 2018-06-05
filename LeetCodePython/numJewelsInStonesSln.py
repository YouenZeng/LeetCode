class Solution:
    def numJewelsInStones(self, J, S):
        """
        :type J: str
        :type S: str
        :rtype: int
        """
        count = 0
        jewels = set(J)
        for s in S:
            if s in jewels:
                count = count + 1

        return count

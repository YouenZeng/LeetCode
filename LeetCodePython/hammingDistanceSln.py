class Solution:
    def hammingDistance(self, x, y):
        """
        :type x: int
        :type y: int
        :rtype: int
        """
        count = 0
        while(x != 0 or y != 0):
            if x % 2 != y % 2:
                count = count + 1
            x = int(x / 2)
            y = int(y / 2)

        return count

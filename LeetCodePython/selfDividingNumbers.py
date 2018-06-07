class Solution:

    def selfDividingNumbers(self, left, right):
        """
        :type left: int
        :type right: int
        :rtype: List[int]
        """
        result = []
        for citem in range(left, right+1):
            item = citem
            while item != 0:
                mod = item % 10
                if(mod == 0):
                    break

                if citem % mod != 0:
                    break
                item = int(item / 10)

            if item == 0:
                result.append(citem)
        return result

class Solution:

    def skipAndClose(self, startIndex, step, count):
        """
        :type startIndex: int
        :type step: int
        :type count: int
        :rtype: List[int]
        """
        inputArray = list(range(1, count+1))

        itemLeft = 0
        result = []

        while(len(inputArray) > 0):
            startIndex = step - itemLeft - 1
            if startIndex > len(inputArray):
                startIndex = startIndex % len(inputArray)
            itemLeft = (len(inputArray) - startIndex - 1) % step

            result.extend(inputArray[startIndex:: step])
            del inputArray[startIndex:: step]

        return result

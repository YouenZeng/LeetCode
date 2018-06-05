class Solution:
    def uniqueMorseRepresentations(self, words):
        """
        :type words: List[str]
        :rtype: int
        """
        asciiTable = [".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..",
                      "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."]
        s = ''
        result = set()
        for w in words:
            for c in w:
                s =s + asciiTable[ord(c) - ord('a')]
            
            result.add(s)
            s=''

        return len(result)

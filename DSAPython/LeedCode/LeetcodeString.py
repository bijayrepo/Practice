class LeetcodeString:
    def RomanToInteger(self, s: str) -> int:
        roman_dict = {
            'I': 1,
            'V': 5,
            'X': 10,
            'L': 50,
            'C': 100,
            'D': 500,
            'M': 1000
        }
        result=0
        for i in range(len(s)):
            if i+1<len(s) and roman_dict[s[i]]< roman_dict[s[i+1]]:
                result-=roman_dict[s[i]]
            else:
                result+=roman_dict[s[i]]

        return result

    def LengthOfLastWord(self,s:str)->int:
        l=len(s)-1
        while l>=0 and s[l]==' ':
            l-=1
        length=0
        while l>=0 and s[l]!=' ':
            length+=1
            l-=1
        return length

class Solution:
    def restoreString(self, s, indices):
        ret = [0] * len(s)
        for i in range(len(s)):
            ret[indices[i]] = s[i]
        
        return "".join(ret)

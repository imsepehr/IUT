def permute(s):
    s = ''.join(sorted(s))
    result = []
    used = [False] * len(s)
    
    def backtrack(path):
        if len(path) == len(s):
            result.append(''.join(path))
            return
        for i in range(len(s)):
            if used[i]:
                continue
            if i > 0 and s[i] == s[i - 1] and not used[i - 1]:
                continue
            used[i] = True
            path.append(s[i])
            backtrack(path)
            path.pop()
            used[i] = False
    
    backtrack([])
    return result

s1 = input()
print("\n".join(permute(s1)))

line = list(input())

l = 0
r = len(line) - 1 
ans = ""

while (l <= r):
    while (line[r] != 'x' and l <= r):
        ans = line[r] + ans
        r = r - 1
    if (line[r] == 'x' and l <= r):
        ans = line[r] + ans
        r = r - 1
    while (line[l] != 'x' and l <= r):
        ans = line[l] + ans
        l = l + 1
    if (line[l] == 'x' and l <= r):
        ans = line[l] + ans  
        l = l + 1
print(ans)        
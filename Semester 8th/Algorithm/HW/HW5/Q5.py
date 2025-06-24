def backtrack(souvenirs, n, k, current_max, groups, index):
    if index == n:
        return current_max
    
    min_unfairness = float('inf')
    for i in range(k):
        groups[i] += souvenirs[index]
        min_unfairness = min(min_unfairness, backtrack(souvenirs, n, k, max(current_max, groups[i]), groups, index + 1))
        groups[i] -= souvenirs[index]
        if groups[i] == 0:
            break
    
    return min_unfairness

def find_min_unfairness(n, k, souvenirs):
    groups = [0] * k
    return backtrack(souvenirs, n, k, 0, groups, 0)

n, k = map(int, input().split())
souvenirs = list(map(int, input().split()))

result = find_min_unfairness(n, k, souvenirs)
print(result)

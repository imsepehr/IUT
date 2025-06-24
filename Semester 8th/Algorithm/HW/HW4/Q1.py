import heapq

def min_energy_to_remove_weeds(n, m, k, W, weeds):
    energy_spent = 0

    weed_count = [[0] * m for _ in range(n)]
    
    for x, y in weeds:
        weed_count[x][y] += 1

    heap = []
    for i in range(n):
        for j in range(m):
            if weed_count[i][j] > 0:
                heapq.heappush(heap, (W[i][j], i, j))

    while heap:
        current_energy, x, y = heapq.heappop(heap)

        if weed_count[x][y] == 0:
            continue

        if weed_count[x][y] == 1:
            energy_spent += current_energy
            weed_count[x][y] = 0
        else:
            new_x1 = (x + 1) % n
            new_y1 = y
            new_x2 = x
            new_y2 = (y + 1) % m
            
            weed_count[x][y] -= 1
            weed_count[new_x1][new_y1] += 1
            weed_count[new_x2][new_y2] += 1

            if weed_count[new_x1][new_y1] == 1:
                heapq.heappush(heap, (W[new_x1][new_y1], new_x1, new_y1))
            if weed_count[new_x2][new_y2] == 1:
                heapq.heappush(heap, (W[new_x2][new_y2], new_x2, new_y2))
                
            heapq.heappush(heap, (current_energy, x, y))

    return energy_spent

n, m, k = map(int, input().split())
W = [list(map(int, input().split())) for _ in range(n)]
weeds = [tuple(map(int, input().split())) for _ in range(k)]

result = min_energy_to_remove_weeds(n, m, k, W, weeds) -1
print(result)



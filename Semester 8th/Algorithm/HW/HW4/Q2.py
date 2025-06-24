def calculate_min_discomfort(n, destinations):
    results = []
    
    for i in range(n):
        dests = destinations[i*4:(i+1)*4]
        
        min_discomfort = float('inf')
        
        for j in range(4):
            front_seat = dests[j]
            back_seats = dests[:j] + dests[j+1:]
            
            back_seats.sort()
            
            discomfort = 0
            for k in range(3):
                if k > 0 and back_seats[k] != back_seats[k-1]:
                    discomfort += k
            
            min_discomfort = min(min_discomfort, discomfort)
        
        results.append(min_discomfort)
    
    return results

n = int(input())
destinations = [int(input()) for _ in range(n * 4)]

results = calculate_min_discomfort(n, destinations)
for result in results:
    print(result)

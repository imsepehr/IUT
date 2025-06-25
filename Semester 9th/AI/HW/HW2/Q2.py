# HW2 AI 
# Athour            : Sepehr Ebadi
# Student Number    : 9933243
# Semester          : Fall 1403

import random
from collections import deque

def print_world(n, m, dirt_positions):
    for i in range(n):
        for j in range(m):
            if (i, j) in dirt_positions:
                print('X', end=' ')  
            else:
                print('-', end=' ')  
        print()

def bfs(n, m, d_count):
    positions = [(i, j) for i in range(n) for j in range(m)]
    random.shuffle(positions)   
    d0 = set(positions[:d_count])  

    b0 = {
        "positions": [(0, 0)],  
        "dirt": d0  
    }

    print_world(n, m, d0)  

    goal = {"positions": [(i, j) for i in range(n) for j in range(m)], "dirt": set()}

    queue = deque([(b0, [])])  
    visited = set()  

    while queue:
        b1, actions = queue.popleft()

        if b1["dirt"] == goal["dirt"]:
            return actions  

        current_positions = b1["positions"]
        d1 = b1["dirt"]

        for pos in current_positions:
            if pos in d1:
                d2 = d1 - {pos}  
                b2 = {"positions": current_positions, "dirt": d2}
                if str(b2) not in visited:
                    visited.add(str(b2))
                    queue.append((b2, actions + [("clean", pos)]))

        for pos in current_positions:
            x, y = pos
            neighbors = [
                (x + dx, y + dy)
                for dx, dy in [(-1, 0), (1, 0), (0, -1), (0, 1)] 
                if 0 <= x + dx < n and 0 <= y + dy < m
            ]
            for i in neighbors:
                new_positions = [i]   
                b2 = {"positions": new_positions, "dirt": d1}
                if str(b2) not in visited:
                    visited.add(str(b2))
                    queue.append((b2, actions + [("move", pos, i)]))

    return None  

n, m, d_count = 3, 3, 5
actions = bfs(n, m, d_count)
print("Actions:")
if actions:
    for i in actions:
        print(i)
else:
    print("No solution found.")

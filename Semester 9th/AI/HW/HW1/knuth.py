import math
from bfs import BFS
from ids import IDS

class KnuthProblem:
    def __init__(self, initial=4):
        self.initial_state = initial
        self.operations = [
            ("sqrt", self.sqrt),
            ("factorial", self.factorial),
            ("floor", self.floor)
        ]

    def factorial(self, n):
        if n < 0 or n > 100:
            return None
        try:
            return math.factorial(n)
        except (ValueError, OverflowError):
            return None

    def sqrt(self, n):
        if n >= 0:
            return math.isqrt(n)
        return None

    def floor(self, n):
        return math.floor(n)

    def problemSearch(self, target):
        print("\nBreadth-First Search:")
        bfs = BFS(self.initial_state, self.operations)
        bfs_solution = bfs.search(target)
        if bfs_solution:
            for step in bfs_solution:
                print(step)
        else:
            print("No solution")

        print("\nIterative Deepening Search:")
        ids = IDS(self.initial_state, self.operations)
        ids_solution = ids.search(target)
        if ids_solution:
            for step in ids_solution:
                print(step)
        else:
            print("No solution")



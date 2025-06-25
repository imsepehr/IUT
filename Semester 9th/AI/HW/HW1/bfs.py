from collections import deque

class BFS:
    def __init__(self, initial_state, operations):
        self.initial_state = initial_state
        self.operations = operations

    def search(self, target):
        frontier = deque([(self.initial_state, [self.initial_state])])
        reached = {self.initial_state}

        while frontier:
            state, path = frontier.popleft()

            if state == target:
                return path

            for name, op in self.operations:
                new_state = op(state)
                if new_state is not None and new_state not in reached:
                    reached.add(new_state)
                    frontier.append((new_state, path + [f"{name}({state}) = {new_state}"]))
        
        return None

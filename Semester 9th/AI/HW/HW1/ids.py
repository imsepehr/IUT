class IDS:
    def __init__(self, initial_state, operations):
        self.initial_state = initial_state
        self.operations = operations

    def search(self, target):
        def dls(state, path, depth_limit):
            if state == target:
                return path
            if depth_limit == 0:
                return None
            
            for name, op in self.operations:
                new_state = op(state)
                if new_state is not None and new_state not in set(path):
                    new_path = path + [f"{name}({state}) = {new_state}"]
                    result = dls(new_state, new_path, depth_limit - 1)
                    if result:
                        return result
            return None

        for depth in range(100):
            result = dls(self.initial_state, [self.initial_state], depth)
            if result:
                return result
        
        return None

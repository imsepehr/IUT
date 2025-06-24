def is_valid_partial(candidate, attempts):
    for attempt, correct in attempts:
        if sum(a == b for a, b in zip(candidate, attempt)) > correct:
            return False
    return True

def count_possible_codes(n, m, attempts):
    def backtrack(candidate):
        if len(candidate) == n:
            if is_valid_partial(candidate, attempts) and all(
                sum(a == b for a, b in zip(candidate, attempt)) == correct
                for attempt, correct in attempts
            ):
                return 1
            else:
                return 0
        
        count = 0
        for digit in '01':
            new_candidate = candidate + digit
            if is_valid_partial(new_candidate, attempts):
                count += backtrack(new_candidate)
        
        return count

    return backtrack("")

n, m = map(int, input().split())
attempts = []
for _ in range(m):
    attempt, correct = input().split()
    attempts.append((attempt, int(correct)))

result = count_possible_codes(n, m, attempts)
print(result)

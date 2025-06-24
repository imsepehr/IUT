def is_valid(board, row, col, num):
    for x in range(9):
        if board[row][x] == num:
            return False

    for x in range(9):
        if board[x][col] == num:
            return False

    start_row = row - row % 3
    start_col = col - col % 3
    for i in range(3):
        for j in range(3):
            if board[i + start_row][j + start_col] == num:
                return False

    return True

def find_empty_location_with_least_candidates(board):
    min_candidates = 10
    best_pos = None
    for i in range(9):
        for j in range(9):
            if board[i][j] == 0:
                candidates = sum(1 for num in range(1, 10) if is_valid(board, i, j, num))
                if candidates < min_candidates:
                    min_candidates = candidates
                    best_pos = (i, j)
    return best_pos

def solve_sudoku(board):
    empty = find_empty_location_with_least_candidates(board)
    if not empty:
        return True  

    row, col = empty

    for num in range(1, 10):
        if is_valid(board, row, col, num):
            board[row][col] = num

            if solve_sudoku(board):
                return True

            board[row][col] = 0  

    return False

def print_board(board):
    for row in board:
        print(" ".join(str(num) for num in row))

input_board = []
for _ in range(9):
    line = list(map(int, input().split()))
    input_board.append(line)

if solve_sudoku(input_board):
    print_board(input_board)
else:
    print("No solution exists")

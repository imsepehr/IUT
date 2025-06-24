def matrix_chain_order(p, n):
    m = [[0 for x in range(n)] for x in range(n)]

    for L in range(2, n + 1): 
        for i in range(1, n - L + 2):
            j = i + L - 1
            m[i-1][j-1] = float('inf')
            for k in range(i, j):
                q = m[i-1][k-1] + m[k][j-1] + p[i-1] * p[k] * p[j]
                if q < m[i-1][j-1]:
                    m[i-1][j-1] = q

    return m[0][n-1]

n = int(input())
dims = list(map(int, input().split()))

result = matrix_chain_order(dims, n)
print(result)

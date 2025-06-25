# HW2 AI 
# Athour            : Sepehr Ebadi
# Student Number    : 9933243
# Semester          : Fall 1403

import numpy as np

def sinc(x, y):
    r = np.sqrt(x**2 + y**2)
    if r == 0:
        return 1  
    return np.sin(r**2) / r

def simulated_annealing(sinc, x0, y0, T=1000, alpha=0.99, max=1000):
    x, y = x0, y0
    v0 = sinc(x, y)
    x1, y1, v1 = x, y, v0

    for i in range(max):
        dx = np.random.uniform(-1, 1)
        dy = np.random.uniform(-1, 1)
        x2, y2 = x + dx, y + dy

        v2 = sinc(x2, y2)

        delta = v2 - v0
        if delta > 0 or np.exp(delta / T) > np.random.rand():
            x, y, v0 = x2, y2, v2

        if v0 > v1:
            x1, y1, v1 = x, y, v0

        T *= alpha

        if T < 1e-3:
            break

    return x1, y1, v1

np.random.seed(42)
global_max = 1  
found_global_max = False
results = []

for i in range(10):
    x0 = np.random.uniform(-10, 10)
    y0 = np.random.uniform(-10, 10)
    x1, y1, v1 = simulated_annealing(sinc, x0, y0)
    results.append((x1, y1, v1))
    if np.isclose(v1, global_max, atol=1e-3):
        found_global_max = True

print("Results : ")
for i, (x, y, value) in enumerate(results, 1):
    print(f"{i}: Max in --> ({x:.4f}, {y:.4f}) with the value --> {value:.4f}.")

if found_global_max:
    print("✅ Reach to global Max.")
else:
    print("❌ Not Reach to global Max.")

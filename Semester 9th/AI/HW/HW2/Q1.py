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

def sinc_gradian(x, y):
    r = np.sqrt(x**2 + y**2)
    if r == 0:
        return (0, 0)  
    res = 2 * np.cos(r**2) / r - np.sin(r**2) / (r**3)
    x_gradian = x * res
    y_gradian = y * res
    return x_gradian, y_gradian

def add_gradian(x0, y0, alpha=0.01, n=1000, max=1e-6):
    x, y = x0, y0
    for i in range(n):
        x_gradian, y_gradian = sinc_gradian(x, y)
        x1 = x + alpha * x_gradian
        y1 = y + alpha * y_gradian

        if np.sqrt((x1 - x)**2 + (y1 - y)**2) < max:
            break
        x, y = x1, y1
    return x, y, sinc(x, y)

np.random.seed(13)  
global_max = 1  
found_global_max = False
results = []

for i in range(10):
    x0 = np.random.uniform(-10, 10)
    y0 = np.random.uniform(-10, 10)
    max_x, max_y, max_value = add_gradian(x0, y0)
    results.append((max_x, max_y, max_value))
    if np.isclose(max_value, global_max, atol=1e-3):  
        found_global_max = True

print("Results : ")
for i, (x, y, value) in enumerate(results, 1):
    print(f"{i}: Max in --> ({x:.4f}, {y:.4f}) with the value --> {value:.4f}.")

if found_global_max:
    print("✅ Reach to global Max.")
else:
    print("❌ Not Reach to global Max.")

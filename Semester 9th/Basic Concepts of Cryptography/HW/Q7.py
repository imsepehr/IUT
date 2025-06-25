# Author : Sepehr Ebadi
# Student ID : 9933243
# Semester : Fall 2024
# Professor : Dr Dakhilalian

def extended_euclidean_algorithm(r0, r1):
    s0, t0 = 1, 0
    s1, t1 = 0, 1
    i = 1

    while r1 != 0:
        i += 1
        ri = r0 % r1
        q = r0 // r1
        r0, r1 = r1, ri

        s = s0 - q * s1
        t = t0 - q * t1

        s0, s1 = s1, s
        t0, t1 = t1, t

    gcd = r0
    s, t = s0, t0
    return gcd, s, t

a = int(input("Enter the first number (a): "))
b = int(input("Enter the second number (b): "))

gcd, s, t = extended_euclidean_algorithm(a, b)

print(f"GCD({a}, {b}) = {gcd}")
print(f"Coefficients: s = {s}, t = {t}")
print(f"Verification: {s} * {a} + {t} * {b} = {s * a + t * b}")

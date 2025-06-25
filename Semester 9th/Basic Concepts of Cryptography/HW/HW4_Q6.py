import random
from math import gcd

def modular_exponentiation(base, exp, mod):
    result = 1
    base = base % mod
    while exp > 0:
        if exp % 2 == 1:  
            result = (result * base) % mod
        exp = exp >> 1  
        base = (base * base) % mod
    return result

# Miller-Rabin 
def is_prime(n, k=5): 
    if n <= 1:
        return False
    if n <= 3:
        return True
    if n % 2 == 0:
        return False

    # n as d*2^r + 1
    r, d = 0, n - 1
    while d % 2 == 0:
        r += 1
        d //= 2

    for _ in range(k):
        a = random.randint(2, n - 2)
        x = modular_exponentiation(a, d, n)  
        if x == 1 or x == n - 1:
            continue
        for _ in range(r - 1):
            x = modular_exponentiation(x, 2, n)
            if x == n - 1:
                break
        else:
            return False
    return True

def generate_large_prime(bits=1024):
    while True:
        prime_candidate = random.getrandbits(bits)
        if is_prime(prime_candidate):
            return prime_candidate

def generate_rsa_keys(bits=1024):
    p = generate_large_prime(bits // 2)
    q = generate_large_prime(bits // 2)
    n = p * q
    phi = (p - 1) * (q - 1)

    e = random.randint(2, phi - 1)
    while gcd(e, phi) != 1:
        e = random.randint(2, phi - 1)

    # Compute d, the modular inverse of e mod phi
    d = modular_inverse(e, phi)
    return (e, n), (d, n)

def modular_inverse(a, m):
    m0, x0, x1 = m, 0, 1
    while a > 1:
        q = a // m
        a, m = m, a % m
        x0, x1 = x1 - q * x0, x0
    if x1 < 0:
        x1 += m0
    return x1

def encrypt(public_key, plaintext):
    e, n = public_key
    plaintext_ascii = [ord(char) for char in plaintext]
    ciphertext = [modular_exponentiation(char, e, n) for char in plaintext_ascii]
    return ciphertext

def decrypt(private_key, ciphertext):
    d, n = private_key
    decrypted_ascii = [modular_exponentiation(char, d, n) for char in ciphertext]
    plaintext = ''.join(chr(char) for char in decrypted_ascii)
    return plaintext

if __name__ == "__main__":
    public_key, private_key = generate_rsa_keys(bits=16)  
    print("Public Key:", public_key)
    print("Private Key:", private_key[0])

    message = "HW4 Cryptography"
    print("\nOriginal Message:", message)
    ciphertext = encrypt(public_key, message)
    print("Ciphertext:", ciphertext)

    decrypted_message = decrypt(private_key, ciphertext)
    print("Decrypted Message:", decrypted_message)

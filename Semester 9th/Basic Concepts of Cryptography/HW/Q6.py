# Author : Sepehr Ebadi
# Student ID : 9933243
# Semester : Fall 2024
# Professor : Dr Dakhilalian

from Crypto.Cipher import AES
from Crypto.Random import get_random_bytes
import base64

def pad(data):
    padding_length = AES.block_size - len(data) % AES.block_size
    padding = chr(padding_length) * padding_length
    return data + padding.encode()

def unpad(data):
    padding_length = data[-1]
    return data[:-padding_length]

def aes_encrypt_cbc(plaintext, key):
    iv = get_random_bytes(AES.block_size)
    cipher = AES.new(key, AES.MODE_CBC, iv)
    padded_plaintext = pad(plaintext.encode())
    ciphertext = cipher.encrypt(padded_plaintext)
    return base64.b64encode(iv + ciphertext).decode()

def aes_decrypt_cbc(ciphertext, key):
    raw_data = base64.b64decode(ciphertext)
    iv = raw_data[:AES.block_size]
    actual_ciphertext = raw_data[AES.block_size:]
    cipher = AES.new(key, AES.MODE_CBC, iv)
    decrypted_data = cipher.decrypt(actual_ciphertext)
    return unpad(decrypted_data).decode()

key = get_random_bytes(16)

plaintext = "this is plain text test."

ciphertext = aes_encrypt_cbc(plaintext, key)
print("cipher text : ", ciphertext)

decrypted_text = aes_decrypt_cbc(ciphertext, key)
print("decrypted text : ", decrypted_text)

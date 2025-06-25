from Crypto.Cipher import DES
from Crypto.Random import get_random_bytes
import random

# myFirstname: Sepehr 
# my Lastname: Ebadi
def generate_key():
    key_str = "SepEbad"
    key_bytes = bytes(key_str, 'ascii')  # Convert to bytes
    # Ensure the key is 8 bytes (64 bits)
    if len(key_bytes) < 8:
        key_bytes += b'\0' * (8 - len(key_bytes))  # Pad with zeros if needed
    return key_bytes[:8]  # Take only the first 8 bytes for DES

def des_encrypt(text, key):
    cipher = DES.new(key, DES.MODE_ECB)
    padded_text = text + b' ' * (8 - len(text) % 8)
    encrypted_text = cipher.encrypt(padded_text)
    return encrypted_text

def compare_diffusion(original, modified):
    differences = sum(b1 != b2 for b1, b2 in zip(original, modified))
    return differences

def test_confusion_and_diffusion(key, num_tests=5):
    results = []
    for _ in range(num_tests):
        # Generate random text
        original_text = get_random_bytes(8)
        #plain_text = input()
        encrypted_original = des_encrypt(original_text, key)

        modified_text = bytearray(original_text)
        bit_to_flip = random.randint(0, 63)
        byte_index = bit_to_flip // 8
        bit_index = bit_to_flip % 8
        modified_text[byte_index] ^= 1 << bit_index  
        encrypted_modified = des_encrypt(bytes(modified_text), key)

        # Compare bit differences
        bit_changes = compare_diffusion(encrypted_original, encrypted_modified) * 8  # Convert to bits
        results.append((original_text, modified_text, bit_changes))

    return results


key = generate_key()
results = test_confusion_and_diffusion(key)
for i, (original, modified, bit_changes) in enumerate(results, 1):
    print(f"Test {i}:")
    print(f"Original text: {original}")
    print(f"Modified text: {modified}")
    print(f"Bit changes in encryption: {bit_changes}")
    print("="*40)

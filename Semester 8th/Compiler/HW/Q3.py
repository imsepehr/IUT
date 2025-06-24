def decode_morse(morse_code):
    morse_dict = {
        "A": ".-",
        "B": "-...",
        "C": "-.-.",
        "D": "-..",
        "E": ".",
        "F": "..-.",
        "G": "--.",
        "H": "....",
        "I": "..",
        "J": ".---",
        "K": "-.-",
        "L": ".-..",
        "M": "--",
        "N": "-.",
        "O": "---",
        "P": ".--.",
        "Q": "--.-",
        "R": ".-.",
        "S": "...",
        "T": "-",
        "U": "..-",
        "V": "...-",
        "W": ".--",
        "X": "-..-",
        "Y": "-.--",
        "Z": "--..",
    }

    reverse_morse_dict = {v: k for k, v in morse_dict.items()}

    words = morse_code.split(" / ")
    decoded_text = ""
    for word in words:
        characters = word.split()
        for character in characters:
            if character in reverse_morse_dict:
                decoded_text += reverse_morse_dict[character]
        decoded_text += " "  
    return decoded_text.strip().lower()

with open("input_morse.txt", "r") as input_file:
    morse_code_input = input_file.read().strip()

decoded_text = decode_morse(morse_code_input)

with open("output_plain.txt", "w") as output_file:
    output_file.write(decoded_text)

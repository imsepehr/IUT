def max_value_of_words(words, letters, values):
    from itertools import combinations
    
    letter_count = {}
    for letter in letters:
        if letter in letter_count:
            letter_count[letter] += 1
        else:
            letter_count[letter] = 1
    
    def can_form_word(word, letter_count):
        word_count = {}
        for letter in word:
            if letter in word_count:
                word_count[letter] += 1
            else:
                word_count[letter] = 1
        
        for letter, count in word_count.items():
            if letter not in letter_count or letter_count[letter] < count:
                return False
        return True
    
    def word_value(word, values):
        value = 0
        for letter in word:
            value += values[ord(letter) - ord('a')]
        return value

    max_value = 0

    for r in range(1, len(words) + 1):
        for subset in combinations(words, r):
            combined_word = ''.join(subset)
            if can_form_word(combined_word, letter_count):
                subset_value = sum(word_value(word, values) for word in subset)
                if subset_value > max_value:
                    max_value = subset_value

    return max_value

n, m = map(int, input().split())
words = input().split()
letters = input().split()
values = list(map(int, input().split()))

result = max_value_of_words(words, letters, values)
print(result)

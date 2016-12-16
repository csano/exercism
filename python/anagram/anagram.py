def sort_letters_in_word(word):
  return ''.join(sorted(word.lower()))

def is_anagram(word, comparedTo):
  sorted_word = sort_letters_in_word(word)
  compared_to_word = sort_letters_in_word(comparedTo)
  return sorted_word == compared_to_word and word.lower() != comparedTo.lower()

def detect_anagrams(word, sublist):
  return [item for item in sublist if is_anagram(word, item)]
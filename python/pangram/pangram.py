def is_alphabetical_char(int_value):
  return int_value >= ord('A') and int_value <= ord('Z')

def is_pangram(s):
  chars = [0] * 26
  for char in s:
    int_value = ord(char.upper())
    if is_alphabetical_char(int_value):
      chars[(int_value - ord('A'))] += 1

  return all(x > 0 for x in chars)
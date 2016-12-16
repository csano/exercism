# -*- coding: utf-8 -*-

def encode(s):
  count = 0
  previous_char = None
  output = ''
  for char in s + '\0':
    if not previous_char is None and previous_char != char:
      if count == 1:
        output += previous_char
      else:
        output += str(count) + previous_char
      count = 0

    previous_char = char
    count += 1

  return output

def decode(s):
  count = 0;
  output = ''
  x = 0
  while x < len(s):
    while s[x].isdigit():
      count = int(str(count) + s[x])
      x += 1

    output = output + (s[x] * (1 if count == 0 else count))
    x += 1
    count = 0

  return output
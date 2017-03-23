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
    count = 0
    output = ''
    for x in list(s):
        if x.isdigit():
            count = int(str(count) + x)
            continue

        output = output + (x * (1 if count == 0 else count))
        count = 0
    return output

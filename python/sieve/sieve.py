def sieve(max):
  table = dict.fromkeys(range(2, max+1))

  for current_num in range(2, max + 1):
    if not table[current_num] is None:
      continue
    table[current_num] = True
    for m in range(current_num * 2, max+1, current_num):
        table[m] = False

  return [key for key in table.keys() if table[key]]
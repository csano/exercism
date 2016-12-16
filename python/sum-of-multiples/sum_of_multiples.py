def sum_of_multiples(up_to, factors):
  return sum(x for x in range(1, up_to) if any(x % factor == 0 for factor in factors if factor))
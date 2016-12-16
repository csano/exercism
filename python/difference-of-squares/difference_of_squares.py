def difference(num):
  return abs(sum_of_squares(num) - square_of_sum(num))

def get_range(num):
  return range(1, num + 1)

def square_of_sum(num):
  return sum([x for x in get_range(num)]) ** 2

def sum_of_squares(num):
  return sum([x**2 for x in get_range(num)])
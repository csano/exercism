def slices(string, items_per_series):
  if not items_per_series or items_per_series > len(string):
    raise ValueError()
  output = []
  for i in range(0, len(string) - items_per_series + 1):
    output.append(map(int, string[i:i + items_per_series]))
  return output
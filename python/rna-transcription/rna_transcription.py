def to_rna(input):
  mapping = { 'G': 'C', 'C': 'G', 'T': 'A', 'A': 'U' }
  return ''.join(map(lambda x: mapping[x], input))
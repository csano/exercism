import re

def abbreviate(str):
  return ''.join(x[0].upper() for x in re.findall('[A-Z]+[a-z]*|[a-z]+', str))
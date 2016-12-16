from collections import Counter
import re

SPLIT_PATTERN = re.compile(r'[\W_]+', re.UNICODE)

def words(sentence):
  words = SPLIT_PATTERN.split(unicode(sentence, 'utf-8').lower())
  return [word for word in words if word != '']

def word_count(sentence):
  return dict(Counter(words(sentence)))
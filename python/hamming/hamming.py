def distance(strand1, strand2):
    return sum(s1 != s2 for s1, s2 in zip(strand1, strand2))
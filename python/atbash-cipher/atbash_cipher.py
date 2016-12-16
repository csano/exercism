PLAIN = 'abcdefghijklmnopqrstuvwxyz0123456789'
ENCODED = 'zyxwvutsrqponmlkjihgfedcba0123456789'
CIPHER = dict(zip(PLAIN, ENCODED))

def encode(str):
  output = do_encode(str)
  return ' '.join(output[i:i+5] for i in range(0, len(output), 5))

def do_encode(str):
  return ''.join([CIPHER[x] for x in str.lower() if x in CIPHER])

def decode(str):
  return do_encode(str)
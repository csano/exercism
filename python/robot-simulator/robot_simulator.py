NORTH, EAST, SOUTH, WEST = range(4)

class Robot:
  def __init__(self, bearing=NORTH, x=0, y=0):
    self.bearing = bearing
    self.x = x
    self.y = y

  @property
  def coordinates(self):
    return self.x, self.y

  def turn_right(self):
    self.bearing = (self.bearing + 1) % 4

  def turn_left(self):
    self.bearing = (self.bearing - 1) % 4

  def advance(self):
    if self.bearing == NORTH:
      self.y += 1
    elif self.bearing == SOUTH:
      self.y -= 1
    elif self.bearing == EAST:
      self.x += 1
    else:
      self.x -= 1

  def simulate(self, command_string):
    cmd_map = {
      'L': 'turn_left',
      'R': 'turn_right',
      'A': 'advance'
    }
    for cmd in command_string:
      getattr(self, cmd_map[cmd])()
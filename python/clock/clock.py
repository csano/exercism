class Clock:
  def __init__(self, hours, minutes):
    self.minutes = minutes + (hours * 60)

  def stringify(self):
    total_minutes = self.minutes
    calculated_hours = (total_minutes / 60) % 24
    calculated_minutes = total_minutes % 60

    return '{:02d}:{:02d}'.format(calculated_hours, calculated_minutes)

  def add(self, minutes):
    self.minutes += minutes
    return self

  def __repr__(self):
    return self.stringify()

  def __eq__(self, other):
    return str(self) == str(other)
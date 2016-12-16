class Allergies:
  def __init__(self, allergy_index):
    self.allergy_index = allergy_index
    self.allergies = {
      'eggs': 1,
      'peanuts': 2,
      'shellfish': 4,
      'strawberries': 8,
      'tomatoes': 16,
      'chocolate': 32,
      'pollen': 64,
      'cats': 128
    }

  @property
  def lst(self):
    return [allergy for allergy in self.allergies if self.is_allergic_to(allergy)]

  def is_allergic_to(self, item):
    return self.allergy_index & self.allergies[item]
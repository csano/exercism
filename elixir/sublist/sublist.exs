defmodule Sublist do
  def is_sublist_of(a, b) do
    cond do
      length(a) > length(b) -> false
      Enum.take(b, length(a)) === a -> true
      true -> is_sublist_of(a, tl(b))
    end
  end

  def compare(a, b) do
    cond do
      a === b -> :equal
      is_sublist_of(a, b) -> :sublist
      is_sublist_of(b, a) -> :superlist
      true -> :unequal
    end
  end
end

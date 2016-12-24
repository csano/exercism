defmodule Accumulate do
  def accumulate([head | tail], action) do
    [action.(head) | accumulate(tail, action)]
  end
  def accumulate([], _) do
    []
  end
end

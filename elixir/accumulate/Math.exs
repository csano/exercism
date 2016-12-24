defmodule Math do
  def sum_list([head | tail], accumulator) do
    sum_list(tail, head + accumulator)
  end

  def sum_list([], accumulator) do
    accumulator
  end

  def double_each([head | tail], f) do
    [f.(head) | double_each(tail, f)]
  end

  def double_each([], f) do
    []
  end
end

IO.inspect Math.sum_list([1, 2, 3], 0) #=> 6
IO.inspect Math.double_each([1, 2, 3], fn(n) -> n * n end)
defmodule SumOfMultiples do
  @spec to(non_neg_integer, [non_neg_integer]) :: non_neg_integer
  def to(limit, factors) do
    1..(limit - 1)
    |> Enum.filter(fn(x) -> 
      Enum.any?(factors, &(rem(x, &1) == 0)) 
    end) 
    |> Enum.sum
  end
end

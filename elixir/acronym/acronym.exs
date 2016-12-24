defmodule Acronym do
  def insert_space_before_capital_letter(string) do
    String.replace(string, ~r/(\p{Lu})/u, " \\1")
  end

  def abbreviate(string) do
    string
    |> insert_space_before_capital_letter()
    |> String.split()
    |> Enum.map(fn(string) -> String.slice(string, 0, 1) end) 
    |> Enum.join
    |> String.upcase()
  end
end

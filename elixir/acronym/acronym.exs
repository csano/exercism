defmodule Acronym do
  def insert_space_before_capital_letter(string) do
    String.replace(string, ~r/(\p{Lu})/u, " \\1")
  end

  def abbreviate(string) do
    string
    |> insert_space_before_capital_letter()
    |> String.split()
    |> Enum.map(&String.first/1) 
    |> Enum.join()
    |> String.upcase()
  end
end

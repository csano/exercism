defmodule Acronym do
  def slice_first_character_and_uppercase(string) do
    string
    |> String.capitalize()
    |> String.slice(0, 1)  
  end

  def insert_space_before_capital_letter(string) do
    String.replace(string, ~r/(\p{Lu})/u, " \\1")
  end

  def abbreviate(string) do
    string
    |> insert_space_before_capital_letter()
    |> String.split()
    |> Enum.map(&slice_first_character_and_uppercase/1) 
    |> Enum.join
  end
end

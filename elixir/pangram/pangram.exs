defmodule Pangram do
  def pangram?(sentence) do
    unique = 
      sentence
      |> String.downcase
      |> String.replace(~r/[^a-z]/, "")
      |> String.graphemes
      |> Enum.uniq
      |> Enum.count

    unique == 26
  end
end
defmodule Words do
  @to_split_on ~r/[^\p{L}0-9\-]+/u

  defp string_to_word_list(str) do
    String.downcase(str) 
    |> String.split(@to_split_on, trim: true)
  end

  def count(sentence) do
    string_to_word_list(sentence) 
    |> Enum.reduce(%{}, fn(word, map) ->
        Map.update(map, word, 1, &(&1 + 1))
      end)
  end
end
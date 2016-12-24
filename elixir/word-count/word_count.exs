defmodule Words do
  defp string_to_word_list(str) do
    String.downcase(str) |> String.split(~r/(_|[^\w\p{Pd}])+/u, trim: true)
  end

  defp update_map(word, map) do
    Map.update(map, word, 1, &(&1 + 1))
  end

  def count(sentence) do
    string_to_word_list(sentence) |> Enum.reduce(%{}, &update_map/2)
  end
end
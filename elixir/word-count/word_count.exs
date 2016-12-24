defmodule Words do
  defp string_to_word_list(str) do
    str |> String.downcase |> String.split(~r/(_|[^\w\p{Pd}])+/u, trim: true)
  end

  defp add_to_dict(x, acc) do
    Dict.update(acc, x, 1, &(&1 + 1))
  end

  def count(sentence) do
    string_to_word_list(sentence) |> Enum.reduce(%{}, &add_to_dict/2)
  end
end
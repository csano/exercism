defmodule Anagram do
  defp sort_characters_in_word(word) do
    word
    |> String.graphemes
    |> Enum.sort
    |> Enum.join
  end

  defp is_anagram?(word1, word2) do
    lower_word1 = String.downcase(word1) 
    lower_word2 = String.downcase(word2) 

    lower_word1 != lower_word2 &&
    sort_characters_in_word(lower_word1) == sort_characters_in_word(lower_word2) 
  end

  def match(base, candidates) do
    candidates
    |> Enum.filter(fn(word) ->
      word
      |> is_anagram?(base)
    end)
  end
end

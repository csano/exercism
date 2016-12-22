defmodule Bob do
  defp is_all_caps(str) do
    String.upcase(str) == str and String.match?(str, ~r/\p{L}/)
  end

  defp is_question(str) do
   String.ends_with?(str, "?") 
  end

  defp is_pause(str) do
    String.trim(str) == ""
  end

  def hey(input) do
    cond do
        is_question(input) -> "Sure."
        is_pause(input) -> "Fine. Be that way!"
        is_all_caps(input) -> "Whoa, chill out!"
        true -> "Whatever."
    end
  end
end

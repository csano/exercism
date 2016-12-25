defmodule Raindrops do
  @sound_mapping %{ 3 => "Pling", 5 => "Plang", 7 => "Plong" }
  @empty_string ""
  def convert(input) do
    sounds = 
      @sound_mapping
      |> Enum.reduce(@empty_string, fn
        ({number, value}, output) when rem(input, number) == 0 -> output <> value 
        (_, output) -> output
      end)
    
    if sounds == @empty_string do
      to_string(input)
    else
      sounds
    end
  end
end
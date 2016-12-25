defmodule Raindrops do
  @sound_mapping %{ 3 => "Pling", 5 => "Plang", 7 => "Plong" }
  def convert(number) do
    sounds = 
      @sound_mapping
      |> Enum.filter(fn({k,_}) -> rem(number, k) == 0 end)
      |> Enum.reduce([], fn({_,v}, acc) -> [acc,v] end)
      |> List.flatten
    
    if sounds == [] do
      to_string(number)
    else
      sounds |> Enum.join
    end
  end
end

IO.inspect Raindrops.convert(15)

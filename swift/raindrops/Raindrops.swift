
class Raindrops {
    var raindrops : Int = 0
    var sound_dict : [Int: String] = [3: "Pling", 5: "Plang", 7: "Plong"]    
    init(_ raindrops : Int) {
        self.raindrops = raindrops
    }
    var sounds : String {
        var output = "";
        for key in sound_dict.keys.filter({ x in self.raindrops % x == 0 }).sorted() {
            output += sound_dict[key]!
        }
        return output != "" ? output : String(raindrops)
    }
}

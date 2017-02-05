
class Raindrops {
    let sound_dict : [Int: String] = [3: "Pling", 5: "Plang", 7: "Plong"]

    var sounds : String

    init(_ raindrops : Int) {
        var output = "";
        for key in sound_dict.keys.filter({ x in raindrops % x == 0 }).sorted() {
            output += sound_dict[key]!
        }
        self.sounds = output != "" ? output : String(raindrops)
    }
}

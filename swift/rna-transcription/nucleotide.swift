
class Nucleotide {
    let mapping: [String : String] = [ "G" : "C", "C" : "G", "T" : "A", "A" : "U" ]
    let strand : String
    var complementOfDNA : String {
        get {
            return strand.characters.map({ String($0) }).map({ x -> String in mapping[x]! }).joined(separator: "")
        }
    }
    init(_ strand : String) {
        self.strand = strand;
    }
}

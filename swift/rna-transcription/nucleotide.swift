
class Nucleotide {
    let mapping: [Character : Character] = [ "G" : "C", "C" : "G", "T" : "A", "A" : "U" ]
    let strand : String
    var complementOfDNA : String {
        get {
            return String(strand.characters.map({ mapping[$0]! }))
        }
    }
    init(_ strand : String) {
        self.strand = strand;
    }
}

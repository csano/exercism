import Foundation

class DNA {
    var dictionary : [String:Int] = ["A": 0, "G": 0, "T": 0, "C": 0]
    
    init?(strand: String) {
        for (_, value) in strand.characters.enumerated() {
            let nucleotide = String(value)
            if dictionary[nucleotide] == nil {
                return nil
            }
            dictionary[nucleotide]! += 1
        }
    }
    
    func count(_ nucleotide : String) -> Int? {
        return dictionary[String(nucleotide)];
    }
    
    func counts() -> [String:Int] {
        return dictionary;
    }
}

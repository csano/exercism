import Foundation

extension Sequence {
    func groupBy<T: Hashable>(key: (Iterator.Element) -> T) -> [T: Int] {
        var output : [T: Int] = [:]
        for element in self {
            let key = key(element)
            if case output[key] = nil {
                output[key] = 1
            } else {
                output[key]! += 1
            }
        }
        return output
    }
}

extension String {
    func stripCharacters(_ characters: CharacterSet) -> String {
        return String(self.characters.filter({characters.contains(String($0).unicodeScalars.first!)}))
    }
}

extension CharacterSet {
    static var LettersNumbersAndWhitespace : CharacterSet {
        return CharacterSet.letters.union(CharacterSet.decimalDigits).union(CharacterSet(charactersIn:" "))
    }
}

class WordCount {
    let words : String
    init(words words : String) {
        self.words = words
    }
    func count() -> [String:Int] {
        return self.words.stripCharacters(CharacterSet.LettersNumbersAndWhitespace).components(separatedBy:CharacterSet.whitespaces).filter({ !$0.isEmpty }).groupBy(key: { $0.lowercased() })
    }
}


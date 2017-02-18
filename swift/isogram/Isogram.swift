import Foundation

class Isogram {
    static func isIsogram(_ input : String) -> Bool {
        var filtered = input.lowercased().components(separatedBy: CharacterSet.lowercaseLetters.inverted).joined()
        return Set(filtered.characters).count == filtered.characters.count
    }
}

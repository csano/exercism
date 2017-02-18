import Foundation

class Isogram {
    static func isIsogram(_ input : String) -> Bool {
        var filtered = input.lowercased().characters.filter({ CharacterSet.lowercaseLetters.contains(UnicodeScalar(String($0))!)})
        return Set(filtered).count == filtered.count
    }
}

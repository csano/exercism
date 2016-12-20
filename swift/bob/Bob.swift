import Foundation

class Bob {
    static func stringIsAllLetters(_ input : String) -> Bool {
        return input.rangeOfCharacter(from: NSCharacterSet.letters, options: String.CompareOptions.caseInsensitive) != nil
    }
    
    static func hey(_ input : String) -> String {
        if input.trimmingCharacters(in: CharacterSet.whitespacesAndNewlines).isEmpty {
            return "Fine, be that way."
        }
        if stringIsAllLetters(input) && input.uppercased() == input {
            return "Woah, chill out!"
        }
        if input.hasSuffix("?") {
            return "Sure."
        }
        return "Whatever."
    }
}

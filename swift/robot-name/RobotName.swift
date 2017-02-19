import Foundation

class Robot {
    var name : String = ""
    static var usedNames : [String] = []

    init() {
        resetName()
    }

    func resetName() {
        name = Robot.setName()
    }

    static func generateNumbers() -> String {
        return String(format: "%3d", (randomize(999) + 1))
    }

    static func generateLetters() -> String {
        return String("\(getRandomLetter())\(getRandomLetter())")
    }

    static func getRandomLetter() -> String {
       return String(describing: UnicodeScalar(randomize(26) + 65)!)
    }

    static func randomize(_ upperBound: UInt32) -> UInt32 {
        return arc4random_uniform(upperBound)
    }

    static func buildString() -> String {
       return "\(generateLetters())\(generateNumbers())"
    }

    static func setName() -> String {
        var newName : String
        repeat {
            newName = buildString()
        } while usedNames.contains(where: { $0 == newName })
        return newName
    }
}

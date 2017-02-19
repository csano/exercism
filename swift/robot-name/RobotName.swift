import Foundation

class Robot {
    var name : String = ""

    init() {
        resetName()
    }

    func resetName() {
        name = setName()
    }

    func generateNumbers() -> String {
        return String(format: "%3d", (randomize(999) + 1))
    }

    func generateLetters() -> String {
        return String("\(getRandomLetter())\(getRandomLetter())")
    }

    func getRandomLetter() -> String {
       return String(describing: UnicodeScalar(randomize(26) + 65)!)
    }

    func randomize(_ upperBound: UInt32) -> UInt32 {
        return arc4random_uniform(upperBound)
    }

    func setName() -> String {
        return "\(generateLetters())\(generateNumbers())"
    }
}

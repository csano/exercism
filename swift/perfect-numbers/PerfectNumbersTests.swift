import XCTest

enum Classification {
    case abundant
    case deficient
    case perfect
}

class NumberClassifier {
    let number : Int

    init(number number: Int) {
        self.number = number
    }

    var classification : Classification {
        var sum = (1..<number).filter({ number % $0 == 0}).reduce(0, +)

        if sum == number {
            return .perfect
        } else if sum > number {
            return .abundant
        }
        return .deficient
    }
}

class PerfectNumbersTests: XCTestCase {
    func testPerfect() {
        let numberClassifier = NumberClassifier(number: 6)
        XCTAssertEqual([.perfect], [numberClassifier.classification])
    }

    func testPerfectAgain() {
        let numberClassifier = NumberClassifier(number: 28)
        XCTAssertEqual([.perfect], [numberClassifier.classification])
    }

    func testDeficient() {
        let numberClassifier = NumberClassifier(number: 13)
        XCTAssertEqual([.deficient], [numberClassifier.classification])

    }

    func testAbundant() {
        let numberClassifier = NumberClassifier(number: 12)
        XCTAssertEqual([.abundant], [numberClassifier.classification])
    }

    static var allTests: [(String, (PerfectNumbersTests) -> () throws -> Void)] {
        return [
            ("testPerfect", testPerfect),
            ("testPerfectAgain", testPerfectAgain),
            ("testDeficient", testDeficient),
            ("testAbundant", testAbundant),
        ]
    }
}

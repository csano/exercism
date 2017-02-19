import XCTest



class Queens : CustomStringConvertible {

    struct Point : Equatable {
        let x : Int
        let y : Int

        init(_ x : Int, _ y: Int) {
            self.x = x
            self.y = y
        }

        static func ==(lhs: Point, rhs: Point) -> Bool {
            return lhs.x == rhs.x && lhs.y == rhs.y
        }
    }

    enum InitError : Error {
        case invalidCoordinates
        case incorrectNumberOfCoordinates
        case sameSpace
    }

    var white : [Int]
    var black : [Int]

    convenience init() {
        try! self.init(white: [0, 3], black: [7, 3])
    }

    init(white white: [Int], black black: [Int]) throws {

        guard white.count == 2 && black.count == 2 else {
           throw InitError.incorrectNumberOfCoordinates
        }

        guard (white + black).filter({ $0 < 0 }).count == 0 else {
            throw InitError.invalidCoordinates
        }

        guard (white != black) else {
            throw InitError.sameSpace
        }

        self.white = white
        self.black = black
    }

    var description : String {
        var lines : [String] = []
        for x in 0..<8 {
            var newline = ""
            for y in 0..<8 {
                newline += getMarker(currentCoordinate: Point(x, y), white: Point(white[0], white[1]), black: Point(black[0], black[1]))
                if (y != 7) {
                    newline += " "
                }
            }
            lines.append(newline)
        }
        return lines.joined(separator:"\n")
    }

    func getMarker(currentCoordinate : Point, white : Point, black: Point) -> String {

        if currentCoordinate == white {
            return "W"
        }

        if currentCoordinate == black {
            return "B"
        }

        return "_"
    }

    var canAttack : Bool {
        if white[0] == black[0] || white[1] == black[1] {
            return true
        }
        
        if abs(white[0] + white[1]) == abs(black[0] + black[1]) {
            return true
        }

        if abs(white[0] - white[1]) == abs(black[0] - black[1]) {
            return true
        }
        return false
    }
}

class QueenAttackTests: XCTestCase {
    func testDefaultPositions() {
        let queens = try! Queens()
        XCTAssertEqual([0, 3], queens.white)
        XCTAssertEqual([7, 3], queens.black)
    }

    func testSpecificPlacement() {
        let queens = try! Queens(white: [3, 7], black: [6, 1])
        XCTAssertEqual([3, 7], queens.white)
        XCTAssertEqual([6, 1], queens.black)
    }

    func testMultipleBoardsSimultaneously() {
        let queens1 = try! Queens(white: [3, 7], black: [6, 1])
        let queens2 = try! Queens(white: [5, 4], black: [7, 7])

        XCTAssertEqual([3, 7], queens1.white)
        XCTAssertEqual([6, 1], queens1.black)
        XCTAssertEqual([5, 4], queens2.white)
        XCTAssertEqual([7, 7], queens2.black)
    }

    func testIncorrectNumberOfCoordinates() {
        XCTAssertThrowsError(_ = try Queens(white: [1, 2, 3], black: [4, 5])) { error in
            XCTAssertEqual(error as? Queens.InitError, .incorrectNumberOfCoordinates)
        }
    }

    func testInvalidCoordinates() {
        XCTAssertThrowsError(_ = try Queens(white: [-3, 0], black: [2, 481])) { error in
            XCTAssertEqual(error as? Queens.InitError, .invalidCoordinates)
        }
    }

    func testCannotOccupySameSpace() {
        XCTAssertThrowsError(_ = try Queens(white: [2, 4], black: [2, 4])) { error in
            XCTAssertEqual(error as? Queens.InitError, .sameSpace)
        }
    }

    func testStringRepresentation() {
        let queens = try! Queens(white: [2, 4], black: [6, 6])
        let board = "_ _ _ _ _ _ _ _\n" +
            "_ _ _ _ _ _ _ _\n" +
            "_ _ _ _ W _ _ _\n" +
            "_ _ _ _ _ _ _ _\n" +
            "_ _ _ _ _ _ _ _\n" +
            "_ _ _ _ _ _ _ _\n" +
            "_ _ _ _ _ _ B _\n" +
        "_ _ _ _ _ _ _ _"
        XCTAssertEqual(board, queens.description)
    }

    func testAnotherStringRepresentation() {
        let queens = try! Queens(white: [7, 1], black: [0, 0])
        let board = "B _ _ _ _ _ _ _\n" +
            "_ _ _ _ _ _ _ _\n" +
            "_ _ _ _ _ _ _ _\n" +
            "_ _ _ _ _ _ _ _\n" +
            "_ _ _ _ _ _ _ _\n" +
            "_ _ _ _ _ _ _ _\n" +
            "_ _ _ _ _ _ _ _\n" +
        "_ W _ _ _ _ _ _"
        XCTAssertEqual(board, queens.description)
    }

    func testYetAnotherStringRepresentation() {
        let queens = try! Queens(white: [4, 3], black: [3, 4])
        let board = "_ _ _ _ _ _ _ _\n" +
            "_ _ _ _ _ _ _ _\n" +
            "_ _ _ _ _ _ _ _\n" +
            "_ _ _ _ B _ _ _\n" +
            "_ _ _ W _ _ _ _\n" +
            "_ _ _ _ _ _ _ _\n" +
            "_ _ _ _ _ _ _ _\n" +
        "_ _ _ _ _ _ _ _"
        XCTAssertEqual(board, queens.description)
    }

    func testCannotAttack() {
        let queens = try! Queens(white: [2, 3], black: [4, 7])
        XCTAssertFalse(queens.canAttack)
    }

    func testCanAttackOnSameRow() {
        let queens = try! Queens(white: [2, 4], black: [2, 7])
        XCTAssertTrue(queens.canAttack)
    }

    func testCanAttackOnSameColumn() {
        let queens = try! Queens(white: [5, 4], black: [2, 4])
        XCTAssertTrue(queens.canAttack)
    }

    func testCanAttackOnDiagonal() {
        let queens = try! Queens(white: [1, 1], black: [6, 6])
        XCTAssertTrue(queens.canAttack)
    }

    func testCanAttackOnOtherDiagonal() {
        let queens = try! Queens(white: [0, 6], black: [1, 7])
        XCTAssertTrue(queens.canAttack)
    }

    func testCanAttackOnYetAnotherDiagonal() {
        let queens = try! Queens(white: [4, 1], black: [6, 3])
        XCTAssertTrue(queens.canAttack)
    }

    func testCanAttackOnADiagonalSlantedTheOtherWay() {
        let queens = try! Queens(white: [6, 1], black: [1, 6])
        XCTAssertTrue(queens.canAttack)
    }

    static var allTests: [(String, (QueenAttackTests) -> () throws -> Void)] {
        return [
            ("testDefaultPositions", testDefaultPositions),
            ("testSpecificPlacement", testSpecificPlacement),
            ("testMultipleBoardsSimultaneously", testMultipleBoardsSimultaneously),
            ("testIncorrectNumberOfCoordinates", testIncorrectNumberOfCoordinates),
            ("testInvalidCoordinates", testInvalidCoordinates),
            ("testCannotOccupySameSpace", testCannotOccupySameSpace),
            ("testStringRepresentation", testStringRepresentation),
            ("testAnotherStringRepresentation", testAnotherStringRepresentation),
            ("testYetAnotherStringRepresentation", testYetAnotherStringRepresentation),
            ("testCannotAttack", testCannotAttack),
            ("testCanAttackOnSameRow", testCanAttackOnSameRow),
            ("testCanAttackOnSameColumn", testCanAttackOnSameColumn),
            ("testCanAttackOnDiagonal", testCanAttackOnDiagonal),
            ("testCanAttackOnOtherDiagonal", testCanAttackOnOtherDiagonal),
            ("testCanAttackOnYetAnotherDiagonal", testCanAttackOnYetAnotherDiagonal),
            ("testCanAttackOnADiagonalSlantedTheOtherWay", testCanAttackOnADiagonalSlantedTheOtherWay),
        ]
    }
}

class Queens : CustomStringConvertible {

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
                newline += getMarker(currentCoordinate: [x, y], white: white, black: black)
                if (y != 7) {
                    newline += " "
                }
            }
            lines.append(newline)
        }
        return lines.joined(separator:"\n")
    }

    func getMarker(currentCoordinate : [Int], white : [Int], black: [Int]) -> String {

        if currentCoordinate[0] == white[0] && currentCoordinate[1] == white[1] {
            return "W"
        }

        if currentCoordinate[0] == black[0] && currentCoordinate[1] == black[1] {
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

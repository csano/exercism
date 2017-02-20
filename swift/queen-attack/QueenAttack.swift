class Queens : CustomStringConvertible {

    enum InitError : Error {
        case invalidCoordinates
        case incorrectNumberOfCoordinates
        case sameSpace
    }

    var white : [Int]
    var black : [Int]

    init(white white: [Int] = [0, 3], black black: [Int] = [7, 3]) throws {

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
            var markers : [String] = []
            for y in 0..<8 {
                markers.append(getMarker(currentCoordinate: [x, y], white: white, black: black))
            }
            lines.append(markers.joined(separator: " "))
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
        var positions = zip(white, black).map( { abs($0.0 - $0.1) })

        if positions.all({ $0 == positions[0] }) || positions.any({ $0 == 0 }) {
            return true
        }

        return false
    }
}

private extension Sequence where Iterator.Element == Int {
    func all(_ predicate: (Iterator.Element) -> Bool) -> Bool {
        for element in self {
            if !predicate(element) {
                return false
            }
        }
        return true
    }

    func any(_ predicate: (Iterator.Element) -> Bool) -> Bool {
        return contains(where: predicate)
    }
}

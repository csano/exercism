struct Triangle {
    let sides : [Double]

    init(_ side1 : Double, _ side2 : Double, _ side3 : Double) {
        sides = [side1, side2, side3]
    }

    var kind : String {
        let sidesMax : Double! = sides.max()

        if sides.filter({ $0 <= 0 }).count == 0 && (sides.reduce(0, +) - sidesMax) > sidesMax {
            switch getNumberOfEqualSides() {
                case 3:
                    return "Equilateral"
                case 2:
                    return "Isosceles"
                case 0:
                    return "Scalene"
                default:
                    break
            }
        }

        return "ErrorKind"
    }

    func getNumberOfEqualSides() -> Int {
        var equalSides = 4 - Set(sides).count
        return equalSides == 1 ? 0 : equalSides
    }
}


class SimulatedRobot {

    enum Bearing : Int {
        case north = 0
        case east
        case south
        case west
    }

    enum Instruction : Character {
        case TurnLeft = "L"
        case TurnRight = "R"
        case Advance = "A"

        static func fromString(_ instructions : String) -> [Instruction] {
            return instructions.characters.flatMap({ Instruction(rawValue: $0) })
        }
    }

    var bearing = Bearing.north
    var coordinates : [Int] = []

    func orient(_ bearing : Bearing) {
        self.bearing = bearing
    }

    func at(x: Int, y: Int) {
        coordinates = [x, y]
    }

    func place(x: Int, y: Int, direction : Bearing) {
        at(x: x, y: y)
        orient(direction)
    }

    func turnLeft() {
        let value = (bearing.rawValue - 1) % 4
        bearing = Bearing(rawValue: value < 0 ? 3 : value)!
    }

    func turnRight() {
        bearing = Bearing(rawValue: (bearing.rawValue + 1) % 4)!
    }

    func advance() {
        switch(bearing) {
            case .north:
                coordinates[1] += 1
            case .south:
                coordinates[1] -= 1
            case .west:
                coordinates[0] -= 1
            case .east:
                coordinates[0] += 1
        }
    }

    func instructions(_ instructions : String) -> [Instruction] {
        return Instruction.fromString(instructions)
    }

    func evaluate(_ raw : String) {
        for instruction in instructions(raw) {
            switch(instruction) {
                case .Advance:
                    advance()
                case .TurnLeft:
                    turnLeft()
                case .TurnRight:
                    turnRight()
                default:
                    break
            }
        }
    }
}


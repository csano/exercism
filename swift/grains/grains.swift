import Foundation

class Grains {
    static func createErrorMessage(_ input : Int) -> String {
        return "Input[\(input)] invalid. Input should be between 1 and 64 (inclusive)"
    }
    static func square(_ squares : Int) throws -> UInt {
        guard squares > 0 else {
            throw GrainsError.inputTooLow(message: createErrorMessage(squares))
        }
        guard squares < 65 else {
            throw GrainsError.inputTooHigh(message: createErrorMessage(squares))
        }
        return grainsOnSquare(squares)
    }
    static func grainsOnSquare(_ squares : Int) -> UInt {
        return UInt(pow(2, Double(squares - 1)))

    }
    static var total : UInt {
        return (1...64).map(grainsOnSquare).reduce(0, +)
    }
    enum GrainsError : Error {
        case inputTooLow(message : String)
        case inputTooHigh(message : String)
    }
}

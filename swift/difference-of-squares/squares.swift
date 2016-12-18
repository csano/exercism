
import Foundation

class Squares {
    let max : Int
    init(_ max : Int) {
        self.max = max
    }
    var squareOfSums : Int {
        get {
            let num = (1...max).reduce(0, +)
            return num * num
        }
    }
    var sumOfSquares : Int {
        get {
            return (1...max).map({ $0 * $0 }).reduce(0, +);
        }
    }
    var differenceOfSquares : Int {
        get {
            return squareOfSums - sumOfSquares
        }
    }
    
}

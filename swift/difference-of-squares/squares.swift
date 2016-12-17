
import Foundation

class Squares {
    let max : Int
    init(_ max : Int) {
        self.max = max
    }
    var squareOfSums : Int {
        get {
            var sum = 0;
            for index in 1...max {
                sum += index
            }
            return Int(pow(Double(sum), Double(2)))
        }
    }
    var sumOfSquares : Int {
        get {
            var sum = 0;
            for index in 1...max {
                sum += Int(pow(Double(index), Double(2)))
            }
            return sum
        }
    }
    var differenceOfSquares : Int {
        get {
            return squareOfSums - sumOfSquares
        }
    }
    
}


class SumOfMultiples {
    static func toLimit(_ limit : Int, inMultiples: Array<Int>) -> Int {
        var sum = 0
        for index in 1..<limit {
            for factor in inMultiples {
                if factor != 0 && index % factor == 0 {
                    sum += index
                    break
                }
            }
        }
        return sum
    }
}

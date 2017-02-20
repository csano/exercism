
class Sieve {
    let upTo : Int
    
    init(_ upTo: Int) {
        self.upTo = upTo
    }

    var primes : [Int] {
        var map = [Int: Bool?]()
        let last = self.upTo + 1
        for i in 2..<last  {
            if !map.contains(where: { $0.key == i }) {
                map[i] = true
                for j in ((i + 1)..<last).filter({ $0 % i == 0 }) {
                    map[j] = false
                }
            }
        }
        return map.filter({ $0.value! }).map({ $0.key }).sorted(by: { $0 < $1 })
    }
}

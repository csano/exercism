
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
                var j = i * 2
                while j < last {
                    map[j] = false
                    j += i
                }
            }
        }
        return map.filter({ $0.value! == true }).map({ $0.key }).sorted(by: { $0 < $1 })
    }
}

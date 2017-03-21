class ETL {
    static func transform(_ old: [Int: [String]]) -> [String:Int] {
        var output : [String : Int] = [:]
        for (points, chars) in old {
            for char in chars {
                output[char.lowercased()] = points
            }
        }
        return output
    }
}

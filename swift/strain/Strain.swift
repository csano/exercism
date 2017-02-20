
extension Sequence {
    func keep(_ predicate: (Iterator.Element) -> Bool) -> [Iterator.Element] {
        return filter({ predicate($0) })
    }

    func discard(_ predicate: (Iterator.Element) -> Bool) -> [Iterator.Element] {
        return filter({ !predicate($0) })
    }

    func filter(_ predicate: (Iterator.Element) -> Bool) -> [Iterator.Element] {
        var out : [Iterator.Element] = []
        for element in self {
            if predicate(element) {
                out.append(element)
            }
        }
        return out
    }
}

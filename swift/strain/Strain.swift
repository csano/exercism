
extension Array {
    func keep(_ predicate: (Element) -> Bool) -> [Element] {
        return filter({ predicate($0) })
    }

    func discard(_ predicate: (Iterator.Element) -> Bool) -> [Element] {
        return filter({ !predicate($0) })
    }

    func filter(_ predicate: (Element) -> Bool) -> [Element] {
        var out = [Element]()
        for element in self {
            if predicate(element) {
                out.append(element)
            }
        }
        return out
    }
}

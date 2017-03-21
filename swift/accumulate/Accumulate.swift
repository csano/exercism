public extension Array {
    func accumulate<T>(_ f: (Element) -> T) -> [T]  {
        var output = [T]()
        for item in self {
            output.append(f(item));
        }
        return output;
    }
}

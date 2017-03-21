func flattenArray<T>(_ array: [Any?]) -> [T] {
    var output = [T]()
    for i in array {
        if let x = i as? [Any?] {
            output += flattenArray(x)
        } else if let x = i as? T {
            output.append(x)
        }
    }
    return output
}


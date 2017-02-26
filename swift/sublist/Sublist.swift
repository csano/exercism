
enum Result {
    case equal
    case unequal
    case sublist
    case superlist
}

func compareLists(_ list1 : [Int], _ list2 : [Int], _ result : Result) -> Result? {
    if list1.count < list2.count {
        if list1.count == 0 {
            return result
        }
        for i in 0..<(list2.count - list1.count + 1) {
            if Array(list2[i...(i+list1.count)-1]) == list1 {
                return result
            }
        }
    }

    return nil
}

func classifier(listOne list1 : [Int], listTwo list2 : [Int]) -> Result {

    if list1 == list2 {
        return .equal
    }

    if let x = compareLists(list1, list2, .sublist) {
        return x
    }

    if let x = compareLists(list2, list1, .superlist) {
        return x
    }

    return Result.unequal;
}


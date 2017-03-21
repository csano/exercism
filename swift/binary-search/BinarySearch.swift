extension Array where Element : Comparable {
    func isSorted() -> Bool {
        var previousIndex = self.startIndex
        var currentIndex = self.startIndex + 1

        while currentIndex != self.endIndex {
            if self[currentIndex] < self[previousIndex] {
                return false
            }
            currentIndex += 1
        }
        return true
    }
}

enum BinarySearchError : Error {
    case unsorted
}

class BinarySearch {

    init(_ numbers : [Int]) throws {

        guard numbers.isSorted() else {
            throw BinarySearchError.unsorted
        }

        list = numbers
    }

    func doSearch(_ searchFor : Int, _ start : Int, _ end : Int) -> Int? {

        if (start > end) {
            return nil
        }

        let midpoint = (start + end) / 2

        if searchFor > list[midpoint] {
            return doSearch(searchFor, midpoint + 1, end)
        } else if searchFor < list[midpoint] {
            return doSearch(searchFor, start, midpoint - 1)
        }

        return midpoint
    }

    func searchFor(_ number : Int) -> Int? {
        return doSearch(number, 0, list.count - 1)
    }

    var list : [Int]

    var middle : Int {
       return list.count / 2
    }
}


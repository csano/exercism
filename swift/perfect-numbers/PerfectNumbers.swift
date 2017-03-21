enum Classification {
    case abundant
    case deficient
    case perfect
}

class NumberClassifier {
    let number : Int

    init(number number: Int) {
        self.number = number
    }

    var classification : Classification {
        let sum = (1..<number).filter({ number % $0 == 0}).reduce(0, +)

        switch (sum) {
            case _ where sum == number:
                return .perfect
            case _ where sum > number:
                return .abundant
            default:
                return .deficient
        }
    }
}


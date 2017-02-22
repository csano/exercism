class PhoneNumber {
    let startingNumber : String

    init(_ startingNumber : String) {
        var number = String(startingNumber.characters.filter({ Set("0123456789".characters).contains($0) }))

        if number.characters.count == 11 && number.characters.first == "1" {
            let index = number.index(number.endIndex, offsetBy: 1)
            number = number.substring(from: index)
        }

        if number.characters.count != 10 {
            number = "0000000000"
        }

        self.startingNumber = number
    }

    var number : String {
        return startingNumber
    }

    var areaCode : String {
        let index = startingNumber.index(startingNumber.startIndex, offsetBy: 3)
        return startingNumber.substring(to: index)
    }
}

extension PhoneNumber : CustomStringConvertible {
    var description : String {
        let areaCodeIndex = startingNumber.index(startingNumber.startIndex, offsetBy: 3)
        let firstIndex = startingNumber.index(areaCodeIndex, offsetBy: 3)
        let lastIndex = startingNumber.index(firstIndex, offsetBy: 4)

        let areaCode = startingNumber.substring(to: areaCodeIndex)
        let first = startingNumber.substring(with:areaCodeIndex..<firstIndex)
        let last = startingNumber.substring(with:firstIndex..<lastIndex)

        return "(\(areaCode)) \(first)-\(last)"
    }
}

class SecretHandshake {
    let moves : Int

    var mapping : [Int:String]  = [
        0x1: "wink",
        0x2: "double blink",
        0x4: "close your eyes",
        0x8: "jump"
    ]

    init(_ moves : Int) {
        self.moves = moves
    }

    var commands : [String] {
        var output = mapping.filter({ $0.key & moves > 0 }).sorted(by: { $0 < $1 }).map({ $0.value })

        return self.moves & 0x10 > 0 ?  Array(output.reversed()) : output
    }
}


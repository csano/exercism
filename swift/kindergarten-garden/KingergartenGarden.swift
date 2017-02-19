enum Plant {
    case Clover
    case Grass
    case Radishes
    case Violets
}

class Garden {

    let plantMapping : [String: Plant] = [
        "C": Plant.Clover,
        "G": Plant.Grass,
        "R": Plant.Radishes,
        "V": Plant.Violets
    ]

    static let students : [String] = [
        "Alice",
        "Bob",
        "Charlie",
        "David",
        "Eve",
        "Fred",
        "Ginny",
        "Harriet",
        "Ileana",
        "Joseph",
        "Kincaid",
        "Larry"
    ]

    let pattern : String
    let students: [String]

    init(_ pattern : String, children students: [String] = students) {
        self.pattern = pattern
        self.students = students.sorted(by: { $0 < $1 })
    }

    func plantsForChild(_ name : String) -> [Plant] {
        var plants : [Plant] = []

        if let index = students.index(where: { x in x == name }) {
            for line in self.pattern.components(separatedBy: "\n") {
                let startIndex = line.index(line.startIndex, offsetBy: index * 2)
                let endIndex = line.index(startIndex, offsetBy: 2)
                let studentPlot = line.substring(with: startIndex..<endIndex)
                studentPlot.characters.map({ position in
                    plants.append(plantMapping[String(position)]!)
                })
            }
        }

        return plants
    }
}


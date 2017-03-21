class Clock : Equatable, CustomStringConvertible {
    let minutes : Int;

    init (hours : Int, minutes: Int = 0) {
        var calculatedMinutes = minutes + (hours * 60)

        if calculatedMinutes < 0 {
            calculatedMinutes = 1440 - (abs(calculatedMinutes) % 1440)
        }

        self.minutes = calculatedMinutes
    }

    var description : String {
        let hours = (self.minutes / 60) % 24
        let minutes = self.minutes % 60

        return String(format: "%02d:%02d", hours, minutes)
    }

    func subtract(minutes: Int) -> Clock {
        return Clock(hours:0, minutes: self.minutes - minutes)
    }

    func add(minutes: Int) -> Clock {
        return Clock(hours:0, minutes: self.minutes + minutes)
    }

    static func ==(lhs: Clock, rhs: Clock) -> Bool {
        return lhs.description == rhs.description
    }
}


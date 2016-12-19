import Foundation

extension Double {
    func roundTwoPlaces() -> Double {
        return (100.0 * self).rounded() / 100.0
    }
}

class SpaceAge {
    let ageInSeconds : Int
    init(_ ageInSeconds : Int) {
        self.ageInSeconds = ageInSeconds
    }

    var seconds : Int {
        return ageInSeconds
    }
    var onEarth : Double {
        return (Double(ageInSeconds) / 31557600).roundTwoPlaces()
    }
    var onMercury : Double {
        return (onEarth / 0.2408467).roundTwoPlaces()
    }
    var onVenus : Double {
        return (onEarth / 0.61519726).roundTwoPlaces()
    }
    var onMars : Double {
        return (onEarth / 1.8808158).roundTwoPlaces()
    }
    var onJupiter : Double {
        return (onEarth / 11.862615).roundTwoPlaces()
    }
    var onSaturn : Double {
        return (onEarth / 29.447498).roundTwoPlaces()
    }
    var onUranus : Double {
        return (onEarth / 84.016846).roundTwoPlaces()
    }
    var onNeptune : Double {
        return (onEarth /  164.79132).roundTwoPlaces()
    }
}

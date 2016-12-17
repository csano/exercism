
import Foundation

class Gigasecond {
    init? (from: String) {
        let dateFormatter = DateFormatter()
        dateFormatter.timeZone = TimeZone(secondsFromGMT: 0)
        dateFormatter.dateFormat = "yyyy-MM-dd'T'HH:mm:ss"
        
        if let date = dateFormatter.date(from: from) {
            description = dateFormatter.string(from: date.addingTimeInterval(pow(10, 9)))
        } else {
            return nil;
        }
    }
    
    var description : String = ""
}

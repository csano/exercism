import Foundation

class Hamming {
    class func compute(_ strand : String, against: String) -> Int?  {
        if (strand.characters.count != against.characters.count) {
            return nil;
        }
        return zip(strand.characters, against.characters).filter({$0 != $1}).count
    }
}

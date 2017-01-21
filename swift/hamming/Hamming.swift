import Foundation

class Hamming {
    class func compute(_ strand : String, against strand2: String) -> Int?  {
        guard (strand.characters.count == strand2.characters.count) else {
            return nil;
        }
        return zip(strand.characters, strand2.characters).filter(!=).count
    }
}

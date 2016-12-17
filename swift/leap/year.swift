
class Year {
    var calendarYear : Int32;
    init(calendarYear : Int32) {
        self.calendarYear = calendarYear;
    }
    var isLeapYear : Bool {
        get {
            if (calendarYear % 4 == 0) {
                if (calendarYear % 100 != 0 || calendarYear % 400 == 0) {
                    return true;
                }
            }
            return false;
        }
    }
}

class GradeSchool {
    var roster : [Int : Set<String>] = [:]
    
    var sortedRoster : [Int : Set<String>] {
        return roster;
    }
    
    func hasRosterForGrade(_ studentGrade: Int) -> Bool {
        return roster[studentGrade] != nil
    }
    
    func addStudent(_ studentName: String, grade studentGrade: Int) {
        if hasRosterForGrade(studentGrade) {
            roster[studentGrade]!.insert(studentName)
        } else {
            roster[studentGrade] = [studentName]
        }
    }
    
    func studentsInGrade(_ studentGrade: Int) -> Set<String> {
        return hasRosterForGrade(studentGrade) ? roster[studentGrade]! : []
    }
}

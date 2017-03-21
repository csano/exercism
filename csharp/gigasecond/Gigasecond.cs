using System;

public class Gigasecond {
    public static DateTime Date(DateTime birthdate) {
		return birthdate.AddSeconds(1000000000);
    }
}
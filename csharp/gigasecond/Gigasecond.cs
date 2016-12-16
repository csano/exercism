using System;
using NUnit.Framework;

public class Gigasecond {
    public static DateTime Date(DateTime birthdate) {
		return birthdate.AddSeconds(1000000000);
    }
}
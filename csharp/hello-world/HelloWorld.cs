using System;

public class HelloWorld {
  public static string Hello(string name) {
		var display = !String.IsNullOrEmpty(name) ? name : "World";
  	return $"Hello, {display}!";
  }
}
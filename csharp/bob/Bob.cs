using System.Text.RegularExpressions;

public class Bob
{
	public static string Hey(string s)
	{
		if (string.IsNullOrEmpty(s.Trim()))
		{
			return "Fine. Be that way!";
		}

		if (Regex.IsMatch(s, "[a-zA-Z]") && s.Equals(s.ToUpper()))
		{
			return "Whoa, chill out!";
		}

		if (s.Trim().EndsWith("?", System.StringComparison.CurrentCulture))
		{
			return "Sure.";
		}

		return "Whatever.";
	}
}
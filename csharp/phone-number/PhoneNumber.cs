using System.Text.RegularExpressions;

public class PhoneNumber
{
    public PhoneNumber(string phoneNumber)
    {
        var strippedNumber = Regex.Replace(phoneNumber, "[^0-9]+", "");
        if (strippedNumber.Length == 10)
        {
            Number = strippedNumber;
        }
        else if (strippedNumber.Length == 11 && strippedNumber.StartsWith("1"))
        {
            Number = strippedNumber.Substring(1);
        }
    }

    public string AreaCode => Number.Substring(0, 3);

    public string Exchange => Number.Substring(3);

    public string Number { get; } = "000000000";

    public override string ToString()
    {
        return $"({AreaCode}) {Exchange.Substring(0, 3)}-{Exchange.Substring(3)}";
    }
}
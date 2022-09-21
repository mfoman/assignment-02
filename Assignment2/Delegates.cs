namespace Assignment2;

public class Delegates
{
    public static readonly Func<string, string> Reverse = s => new string(s.ToCharArray().Reverse().ToArray());
    public static readonly Func<int, int> Square = x => x * x;
    public static readonly Func<string, int> StringToInt = Int32.Parse;
}

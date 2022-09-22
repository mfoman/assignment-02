namespace Assignment2;

public class Delegates
{ 
    //public static readonly Func<string, string> Reverse = s => new string(s.ToCharArray().Reverse().ToArray());
    //public static readonly Func<double, double, double> Product = (x, y) => x * y;
    //public static readonly Func<string, int> StringToInt = Int32.Parse;

    public delegate string Reverse(string stringToReverse);

    public delegate double Product(double x, double y);

    public delegate int StringToInt(string stringInput);
}

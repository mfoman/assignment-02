namespace Assignment2;

public static class Extensions
{
    public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items) => items.SelectMany(x => x);
    public static IEnumerable<int> GetNumbersDivisibleBy7AndGreaterThan42(this IEnumerable<int> numbers) => numbers.Where(x => x > 42 && x % 7 == 0);
    public static IEnumerable<int> GetLeapYearsOfNumbers(this IEnumerable<int> numbers) => numbers.Where(IsLeapYear);
    
    private static bool IsLeapYear(int year)
    {
        if(year < 1582) return false;
        if(year % 400 == 0) return true;
        if(year % 100 == 0) return false;
        return (year % 4 == 0);
    }
}

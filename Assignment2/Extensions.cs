namespace Assignment2;

public static class Extensions
{
    public static IEnumerable<T> Flatten<T>(this IEnumerable<T>[] items) => items.SelectMany(x => x);
}

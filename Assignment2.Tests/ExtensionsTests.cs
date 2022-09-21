namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void LeapYearMethodTest()
    {
        var numbers = new int[] { 4, 1696, 1697, 1698, 1699, 1700, 1701, 1702, 1999, 2000, 2001 };
        var output = numbers.GetLeapYearsOfNumbers();
        output.Should().BeEquivalentTo(new int[] { 1696, 2000 });
    }
    
    [Fact]
    public void IsSecure_returns_true_on_https_and_false_on_http()
    {
        var uriSecure = new Uri("https://example.com");
        var uriUnsecure = new Uri("http://example.com");

        var resultsSecure = uriSecure.IsSecure();
        var resultsUnsecure = uriUnsecure.IsSecure();

        resultsSecure.Should().BeTrue();
        resultsUnsecure.Should().BeFalse();
    }

    [Fact]
    public void WordCount_works()
    {
        var someString = "This is a string with 7 words!";

        var results = someString.WordCount();

        results.Should().Be(7);
    }
}

namespace Lib.Tests;
using Lib;

public class ExtensionMethodsTest
{
    [Fact]
    public void IsSecure_works()
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

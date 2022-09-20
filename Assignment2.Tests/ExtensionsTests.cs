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
}

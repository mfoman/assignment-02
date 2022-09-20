namespace Assignment2.Tests;
using Assignment2;
public class DelegatesTests
{
    [Fact]
    public void ReverseStringTest()
    {
        string input = "My test string!";
        string output = Delegates.Reverse(input);
        output.Should().Be("!gnirts tset yM");
    }

    [Fact]
    public void SquareOf4ShouldBe16()
    {
        int input = 4;
        int output = Delegates.Square(input);
        output.Should().Be(16);
    }

    [Fact]
    public void String_0042ShouldBeInt42()
    {
        Delegates.StringToInt(" 0042").Should().Be(42);
    }
}

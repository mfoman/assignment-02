namespace Assignment2.Tests;
using Assignment2;
public class DelegatesTests
{
    [Fact]
    public void ReverseStringTest()
    {
        Delegates.Reverse reverse = s => new string(s.ToCharArray().Reverse().ToArray());
        
        const string input = "My test string!";
        var output = reverse(input);
        output.Should().Be("!gnirts tset yM");
    }

    [Fact]
    public void FivePoint5Times6Point5ShouldBe37Point5()
    {
        Delegates.Product product = (x, y) => x * y;
        
        var output = product(5.5, 6.5);
        output.Should().Be(35.75);
    }

    [Fact]
    public void String_0042ShouldBeInt42()
    {
        Delegates.StringToInt parse = int.Parse;

        parse(" 0042").Should().Be(42);
    }
}

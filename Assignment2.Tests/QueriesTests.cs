namespace Assignment2.Tests;

using Assignment2;

public class QueriesTests
{
    [Fact]
    public void Test1_extension()
    {
        var allwiz = WizardCollection.Create();

        var filtered = Queries.GetRowlingWizardsNamesByExtension(allwiz);

        var expected = new List<String> {
            "Harry",
            "Ron",
            "Hermie",
            "Harry",
            "Swoldemort",
            "Neville",
        };

        filtered.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test1()
    {
        var allwiz = WizardCollection.Create();

        var filtered = Queries.GetRowlingWizardsNames(allwiz);

        var expected = new List<String> {
            "Harry",
            "Ron",
            "Hermie",
            "Harry",
            "Swoldemort",
            "Neville",
        };

        filtered.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test2_extension()
    {
        var allwiz = WizardCollection.Create();

        var filtered = Queries.GetFirstSithLordByExtension(allwiz);

        var expected = 1975;

        filtered.Should().Be(expected);
    }

    [Fact]
    public void Test2()
    {
        var allwiz = WizardCollection.Create();

        var filtered = Queries.GetFirstSithLord(allwiz);

        var expected = 1975;

        filtered.Should().Be(expected);
    }

    [Fact]
    public void Test3_extension()
    {
        var allwiz = WizardCollection.Create();

        var filtered = Queries.GetUniqueFromHarryPotterByExtension(allwiz);

        var expected = new List<(String, int?)> {
            ("Harry",1954),
            ("Ron",1954),
            ("Hermie",1954),
            ("Swoldemort",1954),
            ("Neville",1954),
        };

        filtered.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test3()
    {
        var allwiz = WizardCollection.Create();

        var filtered = Queries.GetUniqueFromHarryPotter(allwiz);

        var expected = new List<(String, int?)> {
            ("Harry",1954),
            ("Ron",1954),
            ("Hermie",1954),
            ("Swoldemort",1954),
            ("Neville",1954),
        };

        filtered.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test4_extension()
    {
        var allwiz = WizardCollection.Create();

        var filtered = Queries.ListByCreatorReversedByExtension(allwiz).ToList();

        var expected = new List<(String, String)> {
            ("George Lucas", "Darth Vader"),
            ("J.R.R. Tolkien", "Sauron"),
            ("J.R.R. Tolkien", "Gandalf"),
            ("J.R.R. Tolkien", "Michael Mouse"),
            ("Rowling", "Harry"),
            ("Rowling", "Ron"),
            ("Rowling", "Hermie"),
            ("Rowling", "Harry"),
            ("Rowling", "Swoldemort"),
            ("Rowling", "Neville"),
            ("J.R.R. Tolkien", "Smeagle"),
            ("George Lucas", "Darth Ron"),
            ("J.R.R. Tolkien", "William the gray"),
        };

        filtered[0].Should().BeEquivalentTo(("Rowling", "Swoldemort"));
        filtered[12].Should().BeEquivalentTo(("George Lucas", "Darth Ron"));
    }

    [Fact]
    public void Test4()
    {
        var allwiz = WizardCollection.Create();

        var filtered = Queries.ListByCreatorReversed(allwiz).ToList();

        var expected = new List<(String, String)> {
            ("George Lucas", "Darth Vader"),
            ("J.R.R. Tolkien", "Sauron"),
            ("J.R.R. Tolkien", "Gandalf"),
            ("J.R.R. Tolkien", "Michael Mouse"),
            ("Rowling", "Harry"),
            ("Rowling", "Ron"),
            ("Rowling", "Hermie"),
            ("Rowling", "Harry"),
            ("Rowling", "Swoldemort"),
            ("Rowling", "Neville"),
            ("J.R.R. Tolkien", "Smeagle"),
            ("George Lucas", "Darth Ron"),
            ("J.R.R. Tolkien", "William the gray"),
        };

        filtered[0].Should().BeEquivalentTo(("Rowling", "Swoldemort"));
        filtered[12].Should().BeEquivalentTo(("George Lucas", "Darth Ron"));
    }
}

namespace Assignment2.Tests;

using Assignment2;

public class QueriesTests
{
    [Fact]
    public void GetRowlingWizardsNamesByExtension_will_return_list_of_names_from_rowling()
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
    public void GetRowlingWizardsNames_will_return_list_of_names_from_rowling()
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
    public void GetFirstSithLordByExtension_will_return_the_first_sith_lord()
    {
        var allwiz = WizardCollection.Create();

        var filtered = Queries.GetFirstSithLordByExtension(allwiz);

        var expected = 1975;

        filtered.Should().Be(expected);
    }

    [Fact]
    public void GetFirstSithLordBy_will_return_the_first_sith_lord()
    {
        var allwiz = WizardCollection.Create();

        var filtered = Queries.GetFirstSithLord(allwiz);

        var expected = 1975;

        filtered.Should().Be(expected);
    }

    [Fact]
    public void GetUniqueFromHarryPotterByExtension_will_return_list_unique_tuples_name_year()
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
    public void GetUniqueFromHarryPotterBy_will_return_list_unique_tuples_name_year()
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
    public void ListByCreatorReversedByExtension_will_return_list_tuple_creator_name_in_reverse_order()
    {
        var allwiz = WizardCollection.Create();

        var filtered = Queries.ListByCreatorReversedByExtension(allwiz).ToList();

        var expected = new List<(String, String)> {
            ("Rowling", "Swoldemort"),
            ("Rowling", "Ron"),
            ("Rowling", "Neville"),
            ("Rowling", "Hermie"),
            ("Rowling", "Harry"),
            ("Rowling", "Harry"),
            ("J.R.R. Tolkien", "William the gray"),
            ("J.R.R. Tolkien", "Smeagle"),
            ("J.R.R. Tolkien", "Sauron"),
            ("J.R.R. Tolkien", "Michael Mouse"),
            ("J.R.R. Tolkien", "Gandalf"),
            ("George Lucas", "Darth Vader"),
            ("George Lucas", "Darth Ron"),
        };

        Assert.Equal(filtered, expected);
    }

    [Fact]
    public void ListByCreatorReversedBy_will_return_list_tuple_creator_name_in_reverse_order()
    {
        var allwiz = WizardCollection.Create();

        var filtered = Queries.ListByCreatorReversed(allwiz).ToList();

        var expected = new List<(String, String)> {
            ("Rowling", "Swoldemort"),
            ("Rowling", "Ron"),
            ("Rowling", "Neville"),
            ("Rowling", "Hermie"),
            ("Rowling", "Harry"),
            ("Rowling", "Harry"),
            ("J.R.R. Tolkien", "William the gray"),
            ("J.R.R. Tolkien", "Smeagle"),
            ("J.R.R. Tolkien", "Sauron"),
            ("J.R.R. Tolkien", "Michael Mouse"),
            ("J.R.R. Tolkien", "Gandalf"),
            ("George Lucas", "Darth Vader"),
            ("George Lucas", "Darth Ron"),
        };

        Assert.Equal(filtered, expected);
    }
}

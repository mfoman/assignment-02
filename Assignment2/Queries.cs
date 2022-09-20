namespace Assignment2;

using System.Linq;

public static class Queries
{
    public static IEnumerable<String> GetRowlingWizardsNames(IEnumerable<Wizard> wizards)
    {
        return from wiz in wizards
               where wiz.Creator == "Rowling"
               select wiz.Name;
    }

    public static int? GetFirstSithLord(IEnumerable<Wizard> wizards)
    {
        return (from wiz in wizards
                where wiz.Medium == "Star Wars" && wiz.Name.StartsWith("Darth")
                orderby wiz.Year
                select wiz.Year).First();
    }

    public static IEnumerable<(string, int?)> GetUniqueFromHarryPotter(IEnumerable<Wizard> wizards)
    {
        return (from wiz in wizards
                where wiz.Medium == "Harry Potter"
                select (wiz.Name, wiz.Year)).Distinct();
    }

    public static IEnumerable<(string, string)> ListByCreatorReversed(IEnumerable<Wizard> wizards)
    {
        var groups = from wiz in wizards
                     orderby wiz.Creator descending, wiz.Name descending
                     group wiz by wiz.Creator into g
                     select g;

        foreach (var creatorGroup in groups)
        {
            foreach (var wiz in creatorGroup)
            {
                yield return (wiz.Creator, wiz.Name);
            }
        }
    }
}

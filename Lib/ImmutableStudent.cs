namespace Lib;

public record ImmutableStudent(int Id, string? GivenName, string? Surname,
    DateTime? StartDate, DateTime? EndDate, DateTime? GraduationDate)
{
    public Status Status => GetStatus();

    private Status GetStatus()
    {
        if (GraduationDate is DateTime) return Status.Graduated;
        if (DateTime.Now > EndDate) return Status.Dropout;
        if (DateTime.Now < EndDate) return Status.Active;

        return Status.New;
    }
}

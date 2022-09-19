namespace Lib;
public enum Status
{
    New, Active, Dropout, Graduated
}

public record ImmutableStudent(int Id, string GivenName, string Surname,
    Status Status, DateTime StartDate, DateTime EndDate, DateTime GraduationDate);

public class Student
{
    public int Id { get; init; }

    public string? GivenName { get; init; }

    public string? SurName { get; init; }

    public Status Status => GetStatus();

    public DateTime? StartDate { get; init; }

    public DateTime? EndDate { get; init; }

    public DateTime? GraduationDate { get; init; }

    private Status GetStatus()
    {
        if (GraduationDate is DateTime) return Status.Graduated;
        if (DateTime.Now > EndDate) return Status.Dropout;
        if (DateTime.Now < EndDate) return Status.Active;

        return Status.New;
    }

    public override string ToString()
    {
        return $@"
        Student {{
            Id: {Id}
            GivenName: {GivenName}
            SurName: {SurName}
            Status: {Status}
            StartDate: {StartDate}
            EndDate: {EndDate}
            GraduationDate: {GraduationDate}
        }}";
    }
}

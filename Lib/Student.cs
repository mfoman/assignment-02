namespace Lib;
public enum Status
{
    New, Active, Dropout, Graduated
}

public class Student
{
    public Student(int id)
    {
        Id = id;
    }

    public int Id { get; private set; }

    public string? GivenName { get; set; }

    public string? SurName { get; set; }

    public Status Status { get; } = Status.New;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime GraduationDate { get; set; }

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

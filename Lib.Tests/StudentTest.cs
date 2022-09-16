namespace Lib.Tests;

public class StudentTest
{
    [Fact]
    public void Student_returns_right_state_depending_on_dates()
    {
        // Given
        var date = new DateTime();

        var student = new Student(42)
        {
            GivenName = "Frederik",
            SurName = "Raisa",
            StartDate = date,
            EndDate = date,
            GraduationDate = date
        };

        // When

        // If graduationdate is set - set grad
        // if date now is between start and enddate - set active
        // if time is after enddate but no graddate - set dropout
        // if no start or enddate - set new

        // Then
    }

    [Fact]
    public void ToString_stringify_student_works()
    {
        var date = new DateTime();

        var student = new Student(42)
        {
            GivenName = "Frederik",
            SurName = "Raisa",
            StartDate = date,
            EndDate = date,
            GraduationDate = date
        };

        var result = student.ToString();

        var expected = $@"
        Student {{
            Id: 42
            GivenName: Frederik
            SurName: Raisa
            Status: New
            StartDate: {date}
            EndDate: {date}
            GraduationDate: {date}
        }}";

        result.Should().Be(expected);
    }
}

namespace Lib.Tests;

public class StudentTest
{
    [Fact]
    public void Student_with_graduration_date_has_status_gradurated()
    {
        // Given
        var yesterday = DateTime.Now.AddDays(-1);
        var tomorrow = DateTime.Now.AddDays(1);
        var now = DateTime.Now;

        // When
        var studentGraduate = new Student
        {
            Id = 42,
            GivenName = "Frederik",
            SurName = "Raisa",
            StartDate = yesterday,
            EndDate = tomorrow,
            GraduationDate = tomorrow
        };

        // Then
        studentGraduate.Status.Should().Be(Status.Graduated);
    }

    [Fact]
    public void Student_with_enddate_after_today_is_active()
    {
        // Given
        var yesterday = DateTime.Now.AddDays(-1);
        var tomorrow = DateTime.Now.AddDays(1);
        var now = DateTime.Now;

        // When
        var studentGraduate = new Student
        {
            Id = 42,
            GivenName = "Frederik",
            SurName = "Raisa",
            StartDate = yesterday,
            EndDate = tomorrow,
        };

        // Then
        studentGraduate.Status.Should().Be(Status.Active);
    }

    [Fact]
    public void Student_with_no_gradurate_date_and_enddate_before_today_is_dropout()
    {
        // Given
        var yesterday = DateTime.Now.AddDays(-1);
        var tomorrow = DateTime.Now.AddDays(1);
        var now = DateTime.Now;

        // When
        var studentGraduate = new Student
        {
            Id = 42,
            GivenName = "Frederik",
            SurName = "Raisa",
            StartDate = yesterday,
            EndDate = yesterday,
        };

        // Then
        studentGraduate.Status.Should().Be(Status.Dropout);
    }

    [Fact]
    public void Student_with_no_end_date_is_new()
    {
        // Given
        var yesterday = DateTime.Now.AddDays(-1);
        var tomorrow = DateTime.Now.AddDays(1);
        var now = DateTime.Now;

        // When
        var studentGraduate = new Student
        {
            Id = 42,
            GivenName = "Frederik",
            SurName = "Raisa",
            StartDate = yesterday,
        };

        // Then
        studentGraduate.Status.Should().Be(Status.New);
    }

    [Fact]
    public void ToString_stringify_student_works()
    {
        var date = new DateTime();

        var student = new Student
        {
            Id = 42,
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
            Status: Graduated
            StartDate: {date}
            EndDate: {date}
            GraduationDate: {date}
        }}";

        result.Should().Be(expected);
    }

    [Fact]
    public void ToString_Stringify_Immutable_Student_Record_Works()
    {
        var date = new DateTime();

        var student = new ImmutableStudent(42, "Frederik", "Raisa", Status.Graduated, date, date, date);

        var result = student.ToString();

        var expected = @"ImmutableStudent { Id = 42, GivenName = Frederik, Surname = Raisa, Status = Graduated, StartDate = 01/01/0001 00.00.00, EndDate = 01/01/0001 00.00.00, GraduationDate = 01/01/0001 00.00.00 }";
        
        result.Should().Be(expected);
    }

}

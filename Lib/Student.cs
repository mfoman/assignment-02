﻿namespace Lib;
public enum Status
{
    New, Active, Dropout, Graduated
}

public class Student
{
    public int Id { get; init; }

    public string? GivenName { get; set; }

    public string? SurName { get; set; }

    public Status Status => GetStatus();

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? GraduationDate { get; set; }

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

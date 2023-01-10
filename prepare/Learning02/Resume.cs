using System;

public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();
    
    public Resume()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        Console.WriteLine($"{_jobs[0]._jobTitle} ({_jobs[0]._company}) {_jobs[0]._startYear} - {_jobs[0]._endYear}");
        Console.WriteLine($"{_jobs[1]._jobTitle} ({_jobs[1]._company}) {_jobs[1]._startYear} - {_jobs[1]._endYear}");
    }
}


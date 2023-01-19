using System;

public class Job
{
  public string _jobTitle;
  public string _company;
  public string _starYear;
  public string _endYear;

  public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_starYear}-{_endYear}");
    }

}
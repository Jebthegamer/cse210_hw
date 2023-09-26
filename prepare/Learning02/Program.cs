using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            JobTitle = "Janitor",
            Company = "Time Travel Inc.",
            EndYear = 2050,
            StartYear = 2060
        };
        Job job2 = new Job
        {
            JobTitle = "Cabbage merchant",
            Company = "Independently Run",
            StartYear = 2020,
            EndYear = 2020
        };
        Resume myResume = new Resume();
        myResume.Name = "Jacob Buffington";
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);
        myResume.DisplayResume();
    }
}
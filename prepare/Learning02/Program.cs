using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.JobTitle = "Janitor";
        job1.Company = "Time Travel Inc.";
        job1.EndYear = 2050;
        job1.StartYear = 2060;
        Job job2 = new Job();
        job2.JobTitle = "Cabbage merchant";
        job2.Company = "Independently Run";
        job2.StartYear = 2020;
        job2.EndYear = 2020;
        Resume myResume = new Resume();
        myResume.Name = "Jacob Buffington";
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);
        myResume.DisplayResume();
    }
}
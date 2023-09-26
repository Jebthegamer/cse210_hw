using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Janitor";
        job1._company = "Time Travel Inc.";
        job1._endYear = 2050;
        job1._startYear = 2060;
        Job job2 = new Job();
        job2._jobTitle = "Cabbage merchant";
        job2._company = "Independently Run";
        job2._startYear = 2020;
        job2._endYear = 2020;
        Resume myResume = new Resume();
        myResume._name = "Jacob Buffington";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();
    }
}